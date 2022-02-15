namespace Oscilloscope_8chan_finite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAcquire = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.cboTermConfig = new System.Windows.Forms.ComboBox();
            this.cboVoltageRange = new System.Windows.Forms.ComboBox();
            this.nudLowChan = new System.Windows.Forms.NumericUpDown();
            this.nudSampRate = new System.Windows.Forms.NumericUpDown();
            this.nudSampsPerChan = new System.Windows.Forms.NumericUpDown();
            this.nudHighChan = new System.Windows.Forms.NumericUpDown();
            this.chtChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDevices = new System.Windows.Forms.Label();
            this.lblVoltageRange = new System.Windows.Forms.Label();
            this.lblTermConfig = new System.Windows.Forms.Label();
            this.lblSampleRate = new System.Windows.Forms.Label();
            this.lblLowChan = new System.Windows.Forms.Label();
            this.lblSampsPerChan = new System.Windows.Forms.Label();
            this.lblHighChan = new System.Windows.Forms.Label();
            this.lblAqTime = new System.Windows.Forms.Label();
            this.lblADRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampsPerChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighChan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcquire
            // 
            this.btnAcquire.Location = new System.Drawing.Point(78, 302);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(123, 78);
            this.btnAcquire.TabIndex = 0;
            this.btnAcquire.Text = "Acquire";
            this.btnAcquire.UseVisualStyleBackColor = true;
            this.btnAcquire.Click += new System.EventHandler(this.btnAcquire_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(256, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 78);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Chart";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(77, 52);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(145, 21);
            this.cboDevice.TabIndex = 2;
            // 
            // cboTermConfig
            // 
            this.cboTermConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTermConfig.FormattingEnabled = true;
            this.cboTermConfig.Location = new System.Drawing.Point(77, 99);
            this.cboTermConfig.Name = "cboTermConfig";
            this.cboTermConfig.Size = new System.Drawing.Size(145, 21);
            this.cboTermConfig.TabIndex = 3;
            // 
            // cboVoltageRange
            // 
            this.cboVoltageRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoltageRange.FormattingEnabled = true;
            this.cboVoltageRange.Location = new System.Drawing.Point(300, 52);
            this.cboVoltageRange.Name = "cboVoltageRange";
            this.cboVoltageRange.Size = new System.Drawing.Size(154, 21);
            this.cboVoltageRange.TabIndex = 4;
            // 
            // nudLowChan
            // 
            this.nudLowChan.Location = new System.Drawing.Point(76, 150);
            this.nudLowChan.Name = "nudLowChan";
            this.nudLowChan.Size = new System.Drawing.Size(145, 20);
            this.nudLowChan.TabIndex = 5;
            this.nudLowChan.ValueChanged += new System.EventHandler(this.nudLowChan_ValueChanged);
            // 
            // nudSampRate
            // 
            this.nudSampRate.Location = new System.Drawing.Point(300, 100);
            this.nudSampRate.Name = "nudSampRate";
            this.nudSampRate.Size = new System.Drawing.Size(154, 20);
            this.nudSampRate.TabIndex = 6;
            // 
            // nudSampsPerChan
            // 
            this.nudSampsPerChan.Location = new System.Drawing.Point(300, 150);
            this.nudSampsPerChan.Name = "nudSampsPerChan";
            this.nudSampsPerChan.Size = new System.Drawing.Size(154, 20);
            this.nudSampsPerChan.TabIndex = 7;
            // 
            // nudHighChan
            // 
            this.nudHighChan.Location = new System.Drawing.Point(76, 197);
            this.nudHighChan.Name = "nudHighChan";
            this.nudHighChan.Size = new System.Drawing.Size(144, 20);
            this.nudHighChan.TabIndex = 8;
            this.nudHighChan.ValueChanged += new System.EventHandler(this.nudHighChan_ValueChanged);
            // 
            // chtChart
            // 
            chartArea1.Name = "ChartArea1";
            this.chtChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtChart.Legends.Add(legend1);
            this.chtChart.Location = new System.Drawing.Point(484, 64);
            this.chtChart.Name = "chtChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtChart.Series.Add(series1);
            this.chtChart.Size = new System.Drawing.Size(541, 370);
            this.chtChart.TabIndex = 9;
            this.chtChart.Text = "chart1";
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(74, 37);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(49, 13);
            this.lblDevices.TabIndex = 10;
            this.lblDevices.Text = "Devices:";
            // 
            // lblVoltageRange
            // 
            this.lblVoltageRange.AutoSize = true;
            this.lblVoltageRange.Location = new System.Drawing.Point(298, 37);
            this.lblVoltageRange.Name = "lblVoltageRange";
            this.lblVoltageRange.Size = new System.Drawing.Size(81, 13);
            this.lblVoltageRange.TabIndex = 11;
            this.lblVoltageRange.Text = "Voltage Range:";
            // 
            // lblTermConfig
            // 
            this.lblTermConfig.AutoSize = true;
            this.lblTermConfig.Location = new System.Drawing.Point(75, 84);
            this.lblTermConfig.Name = "lblTermConfig";
            this.lblTermConfig.Size = new System.Drawing.Size(115, 13);
            this.lblTermConfig.TabIndex = 12;
            this.lblTermConfig.Text = "Terminal Configuration:";
            // 
            // lblSampleRate
            // 
            this.lblSampleRate.AutoSize = true;
            this.lblSampleRate.Location = new System.Drawing.Point(298, 85);
            this.lblSampleRate.Name = "lblSampleRate";
            this.lblSampleRate.Size = new System.Drawing.Size(113, 13);
            this.lblSampleRate.TabIndex = 13;
            this.lblSampleRate.Text = "Channel Sample Rate:";
            // 
            // lblLowChan
            // 
            this.lblLowChan.AutoSize = true;
            this.lblLowChan.Location = new System.Drawing.Point(75, 135);
            this.lblLowChan.Name = "lblLowChan";
            this.lblLowChan.Size = new System.Drawing.Size(72, 13);
            this.lblLowChan.TabIndex = 14;
            this.lblLowChan.Text = "Low Channel:";
            // 
            // lblSampsPerChan
            // 
            this.lblSampsPerChan.AutoSize = true;
            this.lblSampsPerChan.Location = new System.Drawing.Point(298, 135);
            this.lblSampsPerChan.Name = "lblSampsPerChan";
            this.lblSampsPerChan.Size = new System.Drawing.Size(140, 13);
            this.lblSampsPerChan.TabIndex = 15;
            this.lblSampsPerChan.Text = "Number Samples / Channel:";
            // 
            // lblHighChan
            // 
            this.lblHighChan.AutoSize = true;
            this.lblHighChan.Location = new System.Drawing.Point(75, 182);
            this.lblHighChan.Name = "lblHighChan";
            this.lblHighChan.Size = new System.Drawing.Size(74, 13);
            this.lblHighChan.TabIndex = 16;
            this.lblHighChan.Text = "High Channel:";
            this.lblHighChan.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblAqTime
            // 
            this.lblAqTime.AutoSize = true;
            this.lblAqTime.Location = new System.Drawing.Point(283, 193);
            this.lblAqTime.Name = "lblAqTime";
            this.lblAqTime.Size = new System.Drawing.Size(101, 13);
            this.lblAqTime.TabIndex = 17;
            this.lblAqTime.Text = "Acquisition Time (s):";
            // 
            // lblADRate
            // 
            this.lblADRate.AutoSize = true;
            this.lblADRate.Location = new System.Drawing.Point(283, 233);
            this.lblADRate.Name = "lblADRate";
            this.lblADRate.Size = new System.Drawing.Size(56, 13);
            this.lblADRate.TabIndex = 18;
            this.lblADRate.Text = "A/D Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 527);
            this.Controls.Add(this.lblADRate);
            this.Controls.Add(this.lblAqTime);
            this.Controls.Add(this.lblHighChan);
            this.Controls.Add(this.lblSampsPerChan);
            this.Controls.Add(this.lblLowChan);
            this.Controls.Add(this.lblSampleRate);
            this.Controls.Add(this.lblTermConfig);
            this.Controls.Add(this.lblVoltageRange);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.chtChart);
            this.Controls.Add(this.nudHighChan);
            this.Controls.Add(this.nudSampsPerChan);
            this.Controls.Add(this.nudSampRate);
            this.Controls.Add(this.nudLowChan);
            this.Controls.Add(this.cboVoltageRange);
            this.Controls.Add(this.cboTermConfig);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAcquire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLowChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampsPerChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHighChan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcquire;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.ComboBox cboTermConfig;
        private System.Windows.Forms.ComboBox cboVoltageRange;
        private System.Windows.Forms.NumericUpDown nudLowChan;
        private System.Windows.Forms.NumericUpDown nudSampRate;
        private System.Windows.Forms.NumericUpDown nudSampsPerChan;
        private System.Windows.Forms.NumericUpDown nudHighChan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtChart;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.Label lblVoltageRange;
        private System.Windows.Forms.Label lblTermConfig;
        private System.Windows.Forms.Label lblSampleRate;
        private System.Windows.Forms.Label lblLowChan;
        private System.Windows.Forms.Label lblSampsPerChan;
        private System.Windows.Forms.Label lblHighChan;
        private System.Windows.Forms.Label lblAqTime;
        private System.Windows.Forms.Label lblADRate;
    }
}

