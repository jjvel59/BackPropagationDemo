using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackPropagationDemo.NeuralNetwork;
using BackPropagationDemo.Data;

namespace BackPropagationDemo
{
    public partial class BPDemo : Form
    {
        private Network _network = null;
        private CSVReader _data = new CSVReader();
        private Bitmap _bmpErrors = null;
        private int _iterations = 0;
        private double _maxError = 0f;
        private double _prevError = 0f;
        private double _devError = 0.1;

        public BPDemo()
        {
            InitializeComponent();
        }
        private void InitializeFeedback()
        {
            if (_bmpErrors != null)
            {
                _bmpErrors.Dispose();
            }
            _bmpErrors = new Bitmap(pbErrors.Width, pbErrors.Height);
            using (Graphics gr = Graphics.FromImage(_bmpErrors))
            {
                gr.FillRectangle(Brushes.White, new Rectangle(0, 0, _bmpErrors.Width, _bmpErrors.Height));
            }
            pbProgress.Value = 0;
            pbProgress.Maximum = _iterations;
            lIterations.Text = "0";
            _network.ReportProgress += new EventHandler(TrainingFeedback);
        }
        private void BuildNetwork()
        {
            int ninput = 0;
            if ((!int.TryParse(tbInput.Text, out ninput)) || (ninput <= 0))
            {
                tcData.SelectedIndex = 0;
                tbInput.Focus();                
                throw new Exception("Wrong number of input neurons");
            }
            int[] nhidden = null;
            if (!string.IsNullOrEmpty(tbHidden.Text))
            {
                string[] shidden = tbHidden.Text.Split(',');
                nhidden = new int[shidden.Length];
                for (int h = 0; h < shidden.Length; h++)
                {
                    if ((!int.TryParse(shidden[h].Trim(), out nhidden[h])) || (nhidden[h] <= 0))
                    {
                        tcData.SelectedIndex = 0;
                        tbHidden.Focus();                        
                        throw new Exception("Wrong number of hidden neurons");
                    }
                }
            }
            int noutput = 0;
            if ((!int.TryParse(tbOutput.Text, out noutput)) || (noutput <= 0))
            {
                tcData.SelectedIndex = 0;
                tbOutput.Focus();                
                throw new Exception("Wrong number of output neurons");
            }
            double alpha = 0;
            if (!double.TryParse(tbAlpha.Text, out alpha))
            {
                tcData.SelectedIndex = 0;
                tbAlpha.Focus();                
                throw new Exception("Wrong alpha value");
            }
            alpha = Math.Max(0.001, Math.Min(50, alpha));
            tbAlpha.Text = alpha.ToString();
            if (_data != null)
            {
                if (noutput > _data.ValueCount)
                {
                    throw new Exception("Data has not enough values");
                }
                _network = new Network(_data.ValueCount - noutput, ninput, noutput, nhidden, alpha);
            }
            else
            {
                throw new Exception("You must load a data set first");
            }            
        }
        private async Task TrainNetwork()
        {
            _iterations = 1000;
            if (!int.TryParse(tbIterations.Text, out _iterations))
            {
                tcData.SelectedIndex = 1;
                tbIterations.Focus();                
                throw new Exception("Wrong number of iterations");
            }
            _iterations = Math.Max(100, _iterations);
            tbIterations.Text = _iterations.ToString();            
            double learningrate = 0;
            if (!double.TryParse(tbLR.Text, out learningrate))
            {
                tcData.SelectedIndex = 1;
                tbLR.Focus();                
                throw new Exception("Wrong learning rate");
            }
            learningrate = Math.Max(0.00001, Math.Min(1, learningrate));
            tbLR.Text = learningrate.ToString();
            double momentum = 0;
            if (!double.TryParse(tbMomentum.Text, out momentum))
            {
                tcData.SelectedIndex = 1;
                tbMomentum.Focus();                
                throw new Exception("Wrong momentum");
            }
            momentum = Math.Max(0, Math.Min(0.5, momentum));
            tbMomentum.Text = momentum.ToString();
            _devError = 0.1;
            if (!double.TryParse(tbError.Text, out _devError))
            {
                tcData.SelectedIndex = 1;
                tbError.Focus();                
                throw new Exception("Wrong max. error value");
            }
            _devError = Math.Max(0, _devError);
            tbError.Text = _devError.ToString();            
            if (_data != null)
            {
                InitializeFeedback();
                double error = await _network.TrainNetwork(_data.GetDataInputs(_network.InputCount, true), _data.GetDataOutputs(_network.OutputCount, true), learningrate, momentum, _iterations, _devError);
            }
            else
            {
                throw new Exception("No data loaded");
            }
        }
        private void EnableControls(bool enable)
        {
            bOpen.Enabled = enable;
            bSave.Enabled = enable;
            bBuild.Enabled = enable;
            bTrain.Enabled = enable;
            bCompute.Enabled = enable;
            bStopTraining.Enabled = !enable;

        }
        private void TrainingFeedback(object sender, EventArgs e)
        {
            if (_network.TrainIteration == 0)
            {
                _maxError = _network.TrainError;
                _prevError = _maxError;
            }
            else
            {
                float ix = (float)_bmpErrors.Width / (float)_iterations;
                float iy = (float)_bmpErrors.Height / (float)_maxError;
                using (Graphics gr = Graphics.FromImage(_bmpErrors))
                {
                    gr.DrawLine(Pens.Black,
                        new PointF((_network.TrainIteration - 1f) * ix, _bmpErrors.Height - (float)_prevError * iy),
                        new PointF(_network.TrainIteration * ix, _bmpErrors.Height - (float)_network.TrainError * iy));
                }
                pbProgress.Value = _network.TrainIteration + 1;
                lIterations.Text = (_network.TrainIteration + 1).ToString();
                _prevError = _network.TrainError;
                pbErrors.Image = _bmpErrors.Clone() as Bitmap;
            }
        }
        private void bOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofDlg.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(ofDlg.FileName).ToLower().EndsWith("csv"))
                    {
                        int pc = 70;
                        if (int.TryParse(tbPD.Text, out pc))
                        {
                            pc = Math.Min(90, Math.Max(10, pc));
                        }
                        tbPD.Text = pc.ToString();
                        _data = new CSVReader(ofDlg.FileName, pc);
                        if ((_network != null) && 
                            (_network.InputCount != (_data.ValueCount - _network.OutputCount)))
                        {
                            _network = null;
                        }
                        MessageBox.Show("Data loaded");
                        return;
                    }
                    FileStream fs = null;
                    try
                    {
                        BinaryFormatter fmt = new BinaryFormatter();
                        fs = new FileStream(ofDlg.FileName, FileMode.Open, FileAccess.ReadWrite);
                        _network = fmt.Deserialize(fs) as NeuralNetwork.Network;
                        MessageBox.Show("Network loaded");
                    }
                    catch
                    {
                        throw new Exception("Unknown file format");
                    }
                    finally
                    {
                        if (fs != null)
                        {
                            fs.Close();
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (_network != null)
            {
                FileStream fs = null;
                try
                {
                    if (sfDlg.ShowDialog() == DialogResult.OK)
                    {
                        BinaryFormatter fmt = new BinaryFormatter();
                        fs = new FileStream(sfDlg.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        fmt.Serialize(fs, _network);
                        MessageBox.Show("Network saved");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            try
            {
                BuildNetwork();
                MessageBox.Show("Network built");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void bTrain_Click(object sender, EventArgs e)
        {
            try
            {
                EnableControls(false);
                tcData.SelectedIndex = 2;
                BuildNetwork();
                await TrainNetwork();
                MessageBox.Show("Network trained");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                EnableControls(true);
            }
        }

        private void bCompute_Click(object sender, EventArgs e)
        {
            try
            {
                if (_network == null)
                {
                    throw new Exception("No network present");
                }
                if (_data == null)
                {
                    throw new Exception("No data present");
                }
                if (_network.InputCount != (_data.ValueCount - _network.OutputCount))
                {
                    throw new Exception("Number of data values and network input does not match");
                }
                double[][] dinputs = _data.GetDataInputs(_network.InputCount, false);
                double[][] outputs = _data.GetDataOutputs(_network.OutputCount, false);
                double[][] results = _network.Compute(dinputs);

                double maxerr = 0;
                for (int ie = 0; ie < results.Length; ie++)
                {
                    maxerr = Math.Max(maxerr, Math.Abs(results[ie][0] - outputs[ie][0]));
                }
                int[] deciles = new int[10];
                for (int ie = 0; ie < results.Length; ie++)
                {
                    int id = (int)(10 * Math.Abs(results[ie][0] - outputs[ie][0]) / maxerr);
                    deciles[id < 10 ? id : 9]++;
                }
                string dec = "Decile      1     2     3     4     5     6     7     8     9    10\n       ";

                for (int d = 0; d < 10; d++)
                {
                    string dn = deciles[d].ToString();
                    dec += new string(' ', 6 - dn.Length) + dn;
                }

                lDecil.Text = dec;

                Bitmap bmp = new Bitmap(pbSet.Width, pbSet.Height);
                float h = (pbSet.Height - 10f) / 2f;
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    gr.FillRectangle(Brushes.White, new Rectangle(0, 0, pbSet.Width, pbSet.Height));
                    using (Pen p = new Pen(Color.Black, 1f) { EndCap = LineCap.ArrowAnchor })
                    {
                        for (int ix = 0; ix < Math.Min(pbSet.Width, outputs.Length); ix++)
                        {
                            double[] netoutput = results[ix];
                            gr.DrawLine(p, ix, h - ((float)outputs[ix][0] * h), ix, h - ((float)netoutput[0] * h));
                            if (Math.Abs(outputs[ix][0] * h - netoutput[0] * h) < 2)
                            {
                                gr.DrawLine(Pens.Green, ix, pbSet.Height, ix, pbSet.Height - 5);
                            }
                        }
                    }
                }
                pbSet.Image = bmp;
                tcData.SelectedIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bStopTraining_Click(object sender, EventArgs e)
        {
            try
            {
                _network.Break();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
