using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace BackPropagationDemo.Data
{
    public class CSVReader
    {
        private double[][] _traindata = null;
        private double[][] _testdata = null;
        public CSVReader()
        {
            _traindata = new double[500][];
            double x = 0;
            for (int ix = 0; ix < _traindata.Length; ix++)
            {
                _traindata[ix] = new double[2];
                _traindata[ix][0] = (x * 2) - 1;
                _traindata[ix][1] = ((x * 3.95 * (1 - x)) * 1.7) - 0.85;
                x += (double)1 / 500;
            }
            _testdata = new double[10][];
            x = 0;
            for (int ix = 0; ix < _testdata.Length; ix++)
            {
                _testdata[ix] = new double[2];
                _testdata[ix][0] = (x * 2) - 1;
                _testdata[ix][1] = ((x * 3.95 * (1 - x)) * 1.7) - 0.85;
                x += (double)1 / 10;
            }
        }
        public CSVReader(string filename, int trainpc)
        {
            StreamReader rdr = null;
            try
            {
                rdr = new StreamReader(filename);
                List<string> ldata = new List<string>();
                string data;
                while ((data = rdr.ReadLine()) != null)
                {
                    ldata.Add(data);
                }
                int td = (trainpc * ldata.Count) / 100;
                if (td == ldata.Count)
                {
                    td--;
                }
                _traindata = new double[td][];
                _testdata = new double[ldata.Count - td][];
                Random r = new Random();
                double max = double.MinValue;
                double min = double.MaxValue;
                int ctrain = 0;
                int ctest = 0;
                while (ldata.Count > 0)
                {
                    int rn = r.Next(ldata.Count);
                    string[] values = ldata[rn].Split(ldata[rn].Contains(";") ? ';' : ',');
                    ldata.RemoveAt(rn);
                    if ((ctrain > 0) && (_traindata[0].Length != values.Length))
                    {
                        throw new Exception(string.Format("Wrong number of values in line {0}", string.Join(";", values)));
                    }
                    double[][] ttdata = (ctrain < td) ? _traindata: _testdata;
                    int ix = (ctrain < td) ? ctrain : ctest;
                    ttdata[ix] = new double[values.Length];
                    string ds = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                    for (int n = 0; n < values.Length; n++)
                    {
                        ttdata[ix][n] = double.Parse(values[n].Replace(",", ds).Replace(".", ds));
                        max = Math.Max(max, ttdata[ix][n]);
                        min = Math.Min(min, ttdata[ix][n]);
                    }
                    if (ctrain < td)
                    {
                        ctrain++;
                    }
                    else
                    {
                        ctest++;
                    }
                }
                double range = max - min;
                for(int l = 0; l < _traindata.Length; l++)
                {
                    for (int v = 0; v < _traindata[0].Length; v++)
                    {
                        _traindata[l][v] = (2 * (_traindata[l][v] - min) / range) - 1;
                    }
                }
                for (int l = 0; l < _testdata.Length; l++)
                {
                    for (int v = 0; v < _testdata[0].Length; v++)
                    {
                        _testdata[l][v] = (2 * (_testdata[l][v] - min) / range) - 1;
                    }
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }
        public int ValueCount
        {
            get
            {
                return _traindata[0].Length;
            }
        }
        public double[][] GetDataInputs(int inputs, bool train)
        {
            double[][] data = new double[train ? _traindata.Length : _testdata.Length][];
            for (int l = 0; l < data.Length; l++)
            {
                data[l] = new double[inputs];
                for (int i = 0; i < inputs; i++)
                {
                    data[l][i] = train ? _traindata[l][i] : _testdata[l][i];
                }
            }
            return data;
        }
        public double[][] GetDataOutputs(int outputs, bool train)
        {
            double[][] data = new double[train ? _traindata.Length : _testdata.Length][];
            for (int l = 0; l < data.Length; l++)
            {
                data[l] = new double[outputs];
                for (int o = 0; o < outputs; o++)
                {
                    data[l][o] = train ? _traindata[l][(_traindata[0].Length - outputs) + o] : 
                        _testdata[l][(_testdata[0].Length - outputs) + o];
                }
            }
            return data;
        }
    }
}
