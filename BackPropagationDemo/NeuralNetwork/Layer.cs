using System;

namespace BackPropagationDemo.NeuralNetwork
{
    [Serializable]
    public class Layer
    {
        private Neuron[] _neurons = null;
        private Layer _prevLayer = null;
        private Layer _nextLayer = null;
        private double[] _outputs = null;
        private double[] _errors = null;
        private double _momentum = 0;

        public Layer()
        {
        }
        public Layer(int inputs, int neurons, double alpha)
        {
            SetNeurons(inputs, neurons, alpha);
        }
        public Layer(int neurons, double alpha, Layer prevlayer)
        {
            SetNeurons(prevlayer.OutputCount, neurons, alpha);
            _prevLayer = prevlayer;
            _prevLayer.NextLayer = this;
        }
        public double Momentum
        {
            get
            {
                return _momentum;
            }
            set
            {
                _momentum = Math.Max(0, Math.Min(1.0, value));
            }
        }
        public int InputCount
        {
            get
            {
                return _neurons[0].InputCount;
            }
        }
        public int OutputCount
        {
            get
            {
                return _neurons.Length;
            }
        }
        public Layer NextLayer
        {
            get
            {
                return _nextLayer;
            }
            protected set
            {
                _nextLayer = value;
            }
        }
        public double[] Errors
        {
            get
            {
                return _errors;
            }
        }
        public double[] Outputs
        {
            get
            {
                return _outputs;
            }
        }
        private void SetNeurons(int inputs, int neurons, double alpha)
        {
            _neurons = new Neuron[neurons];
            _outputs = new double[neurons];
            _errors = new double[neurons];
            for (int n = 0; n < neurons; n++)
            {
                _neurons[n] = new Neuron(inputs, alpha);
            }
        }
        public double GetWeight(int neuron, int input)
        {
            return _neurons[neuron].GetWeight(input);
        }
        public void Process(double [] inputs)
        {
            for(int n = 0; n < _neurons.Length; n++)
            {
                _outputs[n] = _neurons[n].CalculateOutput(inputs);                
            }
            if (_nextLayer != null)
            {
                _nextLayer.Process(Outputs);
            }
        }
        public double ComputeError(double[] finaloutput)
        {
            double error = 0;
            for (int n = 0; n < _neurons.Length; n++)
            {
                double e = finaloutput[n] - _outputs[n];
                _errors[n] = e * _neurons[n].Delta;
                error += e * e;
            }
            _prevLayer.ComputeError();
            return error / 2;
        }
        private void ComputeError()
        {
            for (int n = 0; n <_neurons.Length; n++)
            {
               double esum = 0;
               for (int e = 0; e < _nextLayer.Errors.Length; e++)
               {
                   esum += _nextLayer.Errors[e] * _nextLayer.GetWeight(e, n);
               }
               _errors[n] = esum * _neurons[n].Delta;
            }
            if (_prevLayer != null)
            {
                _prevLayer.ComputeError();
            }
        }
        public void ComputeUpdates(double[] inputs, double learningrate)
        {
            for(int n = 0; n < _neurons.Length; n++)
            {
                for (int w = 0; w < _neurons[n].InputCount; w++)
                {
                    _neurons[n].SetWeightUpdate(w, learningrate *
                        (_momentum * _neurons[n].GetWeightUpdate(w) +
                        (1 - _momentum) * _errors[n] * inputs[w]));
                }
                _neurons[n].ThresholdUpdate = learningrate *
                    (_momentum * _neurons[n].ThresholdUpdate +
                    (1 - _momentum) * _errors[n]);
            }
            if (_nextLayer != null)
            {
                _nextLayer.ComputeUpdates(Outputs, learningrate);
            }
        }
        public void ApplyUpdates()
        {
            for(int n = 0; n < _neurons.Length; n++)
            {
                _neurons[n].ApplyUpdates();
            }
            if (_nextLayer != null)
            {
                _nextLayer.ApplyUpdates();
            }
        }
    }
}
