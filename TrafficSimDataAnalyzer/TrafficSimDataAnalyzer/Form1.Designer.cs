namespace TrafficSimDataAnalyzer
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openXmlB = new System.Windows.Forms.Button();
            this.featureName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(32, 49);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(816, 636);
            this.chart.TabIndex = 0;
            this.chart.Text = "Throughput/Crashes Over Time";
            // 
            // openXmlB
            // 
            this.openXmlB.Location = new System.Drawing.Point(939, 154);
            this.openXmlB.Name = "openXmlB";
            this.openXmlB.Size = new System.Drawing.Size(93, 23);
            this.openXmlB.TabIndex = 1;
            this.openXmlB.Text = "Read XML";
            this.openXmlB.UseVisualStyleBackColor = true;
            this.openXmlB.Click += new System.EventHandler(this.selectXmlB_Click);
            // 
            // featureName
            // 
            this.featureName.Location = new System.Drawing.Point(939, 128);
            this.featureName.Name = "featureName";
            this.featureName.Size = new System.Drawing.Size(116, 20);
            this.featureName.TabIndex = 2;
            this.featureName.Text = "Enter Variable Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 784);
            this.Controls.Add(this.featureName);
            this.Controls.Add(this.openXmlB);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button openXmlB;
        private System.Windows.Forms.TextBox featureName;
    }
}

