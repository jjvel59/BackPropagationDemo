using System;

namespace BackPropagationDemo.NeuralNetwork
{
    [Serializable]
    public class Neuron
    {
        private double[] _weights = null;
        private double[] _weightUpdates = null;
        private double _threshold = 0;
        private double _thresholdUpdate = 0;
        private double _alpha = 0;
        private double _output = 0;

        public Neuron()
        {
        }
        public Neuron(int inputs, double alpha)
        {
            _weights = new double[inputs];
            InitialWeights();
            _weightUpdates = new double[inputs];
            _alpha = alpha;
        }
        public double Threshold
        {
            get
            {
                return _threshold;
            }
            set
            {
                _threshold = value;
            }
        }
        public double ThresholdUpdate
        {
            get
            {
                return _thresholdUpdate;
            }
            set
            {
                _thresholdUpdate = value;
            }
        }
        public int InputCount
        {
            get
            {
                return _weights.Length;
            }
        }
        public double Output
        {
            get
            {
                return _output;
            }
        }
        public double Delta
        {
            get
            {
                return _alpha * (1 - (_output * _output)) / 2;
            }
        }

        private void InitialWeights()
        {
            Random r = new Random();
            for (int w = 0; w < _weights.Length; w++)
            {
                _weights[w] = r.NextDouble();
            }
        }
        public double GetWeight(int input)
        {
            return _weights[input];
        }
        public double GetWeightUpdate(int input)
        {
            return _weightUpdates[input];
        }
        public void SetWeightUpdate(int input, double update)
        {
            _weightUpdates[input] = update;
        }
        public double CalculateOutput(double[] inputs)
        {
            double sum = 0;
            for (int w = 0; w < _weights.Length; w++)
            {
                sum += inputs[w] * _weights[w];
            }
            _output = Sigmoid(sum + _threshold);
            return _output;
        }
        private double Sigmoid(double x)
        {
            return (2 / (1 + Math.Exp(-_alpha * x))) - 1;
        }
        public void ApplyUpdates()
        {
            for (int w = 0; w < _weights.Length; w++)
            {
                _weights[w] += _weightUpdates[w];
            }
            Threshold += _thresholdUpdate;
        }
    }
}
