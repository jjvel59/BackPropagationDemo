using System;
using System.Threading.Tasks;

namespace BackPropagationDemo.NeuralNetwork
{
    [Serializable]
    public class Network
    {
        private Layer[] _layers = null;
        private double _alpha = 2;
        private int _iteration = 0;
        private double _error = 0;
        private bool _run = true;

        public Network()
        {
        }
        public Network(int datainputs, int inputs, int outputs, int[] hidden, double alpha)
        {
            _layers = new Layer[2 + ((hidden != null) ? hidden.Length : 0)];
            _layers[0] = new Layer(datainputs, inputs, alpha);
            Layer prev = _layers[0];
            if ((hidden != null) && (hidden.Length > 0))
            {
                for (int h = 0; h < hidden.Length; h++)
                {
                    _layers[1 + h] = new Layer(hidden[h], alpha, prev);
                    prev = _layers[1 + h];
                }
            }
            _layers[_layers.Length - 1] = new Layer(outputs, alpha, prev);
            _alpha = alpha;
        }        
        public event EventHandler ReportProgress = null;
        public int InputCount
        {
            get
            {
                return _layers[0].InputCount;
            }
        }
        public int OutputCount
        {
            get
            {
                return _layers[_layers.Length - 1].OutputCount;
            }
        }
        public int TrainIteration
        {
            get
            {
                return _iteration;
            }
        }
        public double TrainError
        {
            get
            {
                return _error;
            }
        }
        public void Break()
        {
            _run = false;
        }
        public void SetMomentum(double m)
        {
            for (int l = 0; l < _layers.Length; l++)
            {
                _layers[l].Momentum = m;
            }
        }
        private Task<double> TrainSample(double[] inputs, double[] finaloutputs, double learningrate)
        {
            return Task.Run(() =>
            {
                _layers[0].Process(inputs);
                double error = _layers[_layers.Length - 1].ComputeError(finaloutputs);
                _layers[0].ComputeUpdates(inputs, learningrate);
                _layers[0].ApplyUpdates();
                return error;
            });
        }
        public async Task<double> TrainNetwork(double[][] inputs, double[][] outputs, double learningrate, double momentum, int iterations, double minerror)
        {
            try
            {
                _run = true;
                SetMomentum(momentum);
                for (_iteration = 0; _iteration < iterations; _iteration++)
                {
                    double error = 0;
                    for (int s = 0; s < inputs.Length; s++)
                    {
                        if (!_run)
                        {
                            return _error;
                        }
                        error += await TrainSample(inputs[s], outputs[s], learningrate);
                    }
                    _error = error / inputs.Length;
                    ReportProgress?.Invoke(this, EventArgs.Empty);
                    if (_error < minerror)
                    {
                        break;
                    }
                }
                return _error;
            }
            finally
            {
                ReportProgress = null;
            }
        }
        public double[] Compute(double[] inputs)
        {
            _layers[0].Process(inputs);
            return _layers[_layers.Length - 1].Outputs;
        }
        public double[][] Compute(double[][] inputs)
        {
            double[][] result = new double[inputs.Length][];
            for (int ix = 0; ix < inputs.Length; ix++)
            {
                _layers[0].Process(inputs[ix]);
                result[ix] = new double[_layers[_layers.Length - 1].Outputs.Length];
                _layers[_layers.Length - 1].Outputs.CopyTo(result[ix], 0);
            }
            return result;
        }
    }
}
