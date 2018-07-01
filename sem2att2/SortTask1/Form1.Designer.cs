namespace SortTask1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRun_Btn = new System.Windows.Forms.Button();
            this.radioButtonChange = new System.Windows.Forms.RadioButton();
            this.radioButtonCompare = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(9, 62);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "NatureMerge Sort";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SimpleMerge Sort";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Shaker Sort";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(614, 479);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // chartRun_Btn
            // 
            this.chartRun_Btn.Location = new System.Drawing.Point(175, 12);
            this.chartRun_Btn.Name = "chartRun_Btn";
            this.chartRun_Btn.Size = new System.Drawing.Size(127, 32);
            this.chartRun_Btn.TabIndex = 1;
            this.chartRun_Btn.Text = "Построить графики";
            this.chartRun_Btn.UseVisualStyleBackColor = true;
            this.chartRun_Btn.Click += new System.EventHandler(this.chartRun_Btn_Click);
            // 
            // radioButtonChange
            // 
            this.radioButtonChange.AutoSize = true;
            this.radioButtonChange.Location = new System.Drawing.Point(13, 12);
            this.radioButtonChange.Name = "radioButtonChange";
            this.radioButtonChange.Size = new System.Drawing.Size(137, 17);
            this.radioButtonChange.TabIndex = 2;
            this.radioButtonChange.Text = "Число переставновок";
            this.radioButtonChange.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompare
            // 
            this.radioButtonCompare.AutoSize = true;
            this.radioButtonCompare.Location = new System.Drawing.Point(13, 36);
            this.radioButtonCompare.Name = "radioButtonCompare";
            this.radioButtonCompare.Size = new System.Drawing.Size(114, 17);
            this.radioButtonCompare.TabIndex = 3;
            this.radioButtonCompare.Text = "Число сравнений";
            this.radioButtonCompare.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Визуализация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonCompare);
            this.Controls.Add(this.radioButtonChange);
            this.Controls.Add(this.chartRun_Btn);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button chartRun_Btn;
        private System.Windows.Forms.RadioButton radioButtonChange;
        private System.Windows.Forms.RadioButton radioButtonCompare;
        private System.Windows.Forms.Button button1;
    }
}

