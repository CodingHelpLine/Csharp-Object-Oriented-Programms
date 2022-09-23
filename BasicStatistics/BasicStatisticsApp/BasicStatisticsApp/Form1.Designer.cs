namespace BasicStatisticsApp
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRaw = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Elements: ";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(228, 21);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 26);
            this.txtSize.TabIndex = 1;
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(228, 53);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(100, 26);
            this.txtLower.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lower Limit: ";
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(228, 85);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(100, 26);
            this.txtUpper.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upper Limit: ";
            // 
            // lstRaw
            // 
            this.lstRaw.FormattingEnabled = true;
            this.lstRaw.ItemHeight = 20;
            this.lstRaw.Location = new System.Drawing.Point(31, 228);
            this.lstRaw.Name = "lstRaw";
            this.lstRaw.Size = new System.Drawing.Size(120, 224);
            this.lstRaw.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raw Dataset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sorted Dataset";
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.ItemHeight = 20;
            this.lstSorted.Location = new System.Drawing.Point(210, 228);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(120, 224);
            this.lstSorted.TabIndex = 8;
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(230, 471);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(100, 26);
            this.txtMean.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mean: ";
            // 
            // txtMedian
            // 
            this.txtMedian.Location = new System.Drawing.Point(230, 506);
            this.txtMedian.Name = "txtMedian";
            this.txtMedian.Size = new System.Drawing.Size(100, 26);
            this.txtMedian.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Median: ";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(230, 538);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(100, 26);
            this.txtMode.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mode: ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(29, 128);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(122, 39);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(206, 128);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 39);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // histogramChart
            // 
            chartArea2.AxisX.Title = "Numbers";
            chartArea2.AxisY.Title = "Frequency";
            chartArea2.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.histogramChart.Legends.Add(legend2);
            this.histogramChart.Location = new System.Drawing.Point(345, 21);
            this.histogramChart.Name = "histogramChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Label = "Random Variable";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.histogramChart.Series.Add(series2);
            this.histogramChart.Size = new System.Drawing.Size(829, 543);
            this.histogramChart.TabIndex = 18;
            this.histogramChart.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Histogram of Random Variable";
            this.histogramChart.Titles.Add(title2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 583);
            this.Controls.Add(this.histogramChart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMedian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstSorted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstRaw);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Basic Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRaw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
    }
}

