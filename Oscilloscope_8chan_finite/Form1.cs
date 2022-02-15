using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using System.Windows.Forms.DataVisualization.Charting;

namespace Oscilloscope_8chan_finite
{
    public partial class Form1 : Form
    {
        AnalogMultiChannelReader reader;
        NationalInstruments.DAQmx.Task readTask;

        //NationalInstruments.DAQmx.A2D_MAXTIME = 10;
        //A2D_MAXRATE = 10;

        double rangeMinimum;
        double rangeMaximum;
        string strTermConfig;
        int termConfigNum;
        double[,] dataIn;
        
        int numberOfSamples;
        int sampleRate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDevice.Items.AddRange(DaqSystem.Local.Devices);
            cboDevice.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTermConfig.Items.Add("Differential");
            cboTermConfig.Items.Add("NRSE");
            cboTermConfig.Items.Add("RSE");
            cboTermConfig.SelectedIndex = 0;


            cboVoltageRange.Items.Add("+/- 0.2");
            cboVoltageRange.Items.Add("+/- 1");
            cboVoltageRange.Items.Add("+/- 5");
            cboVoltageRange.Items.Add("+/- 10");
            cboVoltageRange.SelectedIndex = 3;

            cboDevice.SelectedIndex = 0;



            nudHighChan.Maximum = 7;
            nudHighChan.Minimum = 0;
            nudLowChan.Maximum = 7;
            nudLowChan.Minimum = 0;
            nudHighChan.Value = 0;
            nudLowChan.Value = 0;

            nudSampRate.Maximum = 500000;
            nudSampRate.Minimum = 1;
            nudSampRate.Value = 10000;
            nudSampsPerChan.Value = 100;
            nudSampsPerChan.Maximum = 10000;
            nudSampsPerChan.Minimum = 1;

            Title title = chtChart.Titles.Add("Voltage vs Time");
            title.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = System.Drawing.Color.FromArgb(255, 0, 255); // rgb color code (red, green, blue)

            // start X axes at zero
            chtChart.ChartAreas[0].AxisX.Minimum = 0.0;
            


            // change font of NUMBERS on x axis
            chtChart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            // change font of numbers on y axis
            chtChart.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);

            chtChart.ChartAreas[0].AxisX.Title = "Time(s)";
            chtChart.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            chtChart.ChartAreas[0].AxisY.Title = "Voltage(volts)";
            chtChart.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            // Set up legend
            chtChart.Legends[0].Alignment = StringAlignment.Center;
            chtChart.Legends[0].Docking = Docking.Right;
            chtChart.Legends[0].LegendStyle = LegendStyle.Table;
            chtChart.Legends[0].TableStyle = LegendTableStyle.Auto;
            chtChart.Legends[0].Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);


        }

        private void btnAcquire_Click(object sender, EventArgs e)
        {
            try
            {
                btnAcquire.Enabled = false;
                switch (cboVoltageRange.SelectedIndex)
                {
                    case 0:
                        rangeMinimum = -0.2;
                        rangeMaximum = 0.2;
                        break;

                    case 1:
                        rangeMinimum = -1;
                        rangeMaximum = 1;
                        break;

                    case 2:
                        rangeMinimum = -5;
                        rangeMaximum = 5;
                        break;

                    case 3:
                        rangeMinimum = -10;
                        rangeMaximum = 10;
                        break;

                    default:
                        rangeMinimum = -10;
                        rangeMaximum = 10;
                        break;
                }

                //strTermConfig

                //switch (cboTermConfig.SelectedIndex)
                //{
                //    case 0:
                //        strTermConfig = AITerminalConfiguration.Differential;
                //        break;
                //    case 1:
                //        termConfigNum = 10078;
                //        break;
                //    case 2:
                //        termConfigNum = 10083;
                //        break;
                //}


                //switch (cboTermConfig.SelectedIndex)
                //{
                //    case 0:
                //        termConfigNum = 10106;
                //        break;
                //    case 1:
                //        termConfigNum = 10078;
                //        break;
                //    case 2:
                //        termConfigNum = 10083;
                //        break;
                //}

                sampleRate = (int)nudSampRate.Value;
                numberOfSamples = (int)nudSampsPerChan.Value;
                dataIn = new double[(int)(nudHighChan.Value - (int)nudLowChan.Value + 1), numberOfSamples];
                readTask = new NationalInstruments.DAQmx.Task();


                //MessageBox.Show(cboDevice.SelectedItem.ToString() + "/ai" + nudLowChan.Value.ToString() + ":" + nudHighChan.Value.ToString());
                readTask.AIChannels.CreateVoltageChannel(cboDevice.SelectedItem.ToString() + "/ai" + nudLowChan.Value.ToString() + ":" + nudHighChan.Value.ToString(), "",
                   AITerminalConfiguration.Differential, rangeMinimum, rangeMaximum, AIVoltageUnits.Volts);


                readTask.Timing.ConfigureSampleClock(
                    "", // external clock source line or use "" for internal clock
                    (double)nudSampRate.Value, // expected rate of external clock or actual rate of internal clock
                    SampleClockActiveEdge.Rising, // acquire on rising or falling edge of ticks
                    SampleQuantityMode.FiniteSamples, // continuous or finite samples
                    (int)nudSampsPerChan.Value // number of finite samples to acquire or used for buffer size if continuous
                    );
                
                //Create the reader
                reader = new AnalogMultiChannelReader(readTask.Stream);
                if (((nudHighChan.Value - nudLowChan.Value + 1) * sampleRate) > 500000)
                {
                    MessageBox.Show("(Number of Channels x Sample Rate) Must Be Less Than 500,000.");
                    btnAcquire.Enabled = true;
                }
                else {
                    IAsyncResult handle = reader.BeginReadMultiSample((int)nudSampsPerChan.Value, new AsyncCallback(OnDataReady), null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnAcquire.Enabled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nudLowChan_ValueChanged(object sender, EventArgs e)
        {
            if (nudHighChan.Value < nudLowChan.Value)
            {
                MessageBox.Show("High Channel must be greater thatn Low Channel.");
                nudLowChan.Value = nudLowChan.Value - 1;
            }
        }
        void OnDataReady(IAsyncResult i)
        {
            try
            {
                //Retrieve the data that was read.
                //At this point, any exceptions that occurred during the asynchronous read are thrown
                dataIn = reader.EndReadMultiSample(i);
                

                //if (nudHighChan.Value - nudLowChan.Value > 0) DAQmxAsyncRead(readTask);

                double[] time = new double[numberOfSamples];
                chtChart.ChartAreas[0].AxisY.Minimum = rangeMinimum-1;
                chtChart.ChartAreas[0].AxisY.Maximum = rangeMaximum+1;

                while (chtChart.Series.Count > 0) chtChart.Series.RemoveAt(0);
                for (int k = 0; k < numberOfSamples; k++)
                    time[k] = (double)k / (double)sampleRate;
                for (int k = 0; k < (nudHighChan.Value - nudLowChan.Value + 1); k++)
                {
                    chtChart.Series.Add("Channel" + k.ToString());
                    chtChart.Series["Channel" + k.ToString()].ChartType = SeriesChartType.Line;
                }

                // Add data to each series, 
                for (int k = 0; k < (nudHighChan.Value - nudLowChan.Value + 1); k++)
                {
                    for (int j = 0; j < numberOfSamples; j++)
                    {
                        chtChart.Series["Channel" + k.ToString()].Points.AddXY(time[j], dataIn[k, j]);
                    }
                }
                double sampleTime = (double)numberOfSamples/(double)sampleRate;
                lblAqTime.Text = "Acquisition Time (s): "+sampleTime.ToString(); 
                lblADRate.Text = "A/D Rate: "+ ((nudHighChan.Value - nudLowChan.Value + 1)*sampleRate).ToString();

                btnAcquire.Enabled = true;

                if (readTask != null)  // only dispose if task exists
                {
                    readTask.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void nudHighChan_ValueChanged(object sender, EventArgs e)
        {
            if (nudHighChan.Value < nudLowChan.Value)
            {
                MessageBox.Show("High Channel must be greater thatn Low Channel.");
                nudHighChan.Value = nudHighChan.Value + 1;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (readTask != null)  // only dispose if task exists
                {
                    readTask.Dispose();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
