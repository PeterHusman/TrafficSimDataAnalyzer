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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openXmlB = new System.Windows.Forms.Button();
            this.featureName = new System.Windows.Forms.TextBox();
            this.RatioBox = new System.Windows.Forms.ListBox();
            this.trialSelect = new System.Windows.Forms.Button();
            this.trialNumBox = new System.Windows.Forms.MaskedTextBox();
            this.tNumLabel = new System.Windows.Forms.Label();
            this.trialXML = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(32, 49);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(816, 636);
            this.chart.TabIndex = 0;
            this.chart.Text = "Throughput/Crashes Over Time";
            this.chart.Click += new System.EventHandler(this.chart_Click);
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
            // RatioBox
            // 
            this.RatioBox.FormattingEnabled = true;
            this.RatioBox.Items.AddRange(new object[] {
            "Throughput:Crashes",
            "Crashes:Throughput",
            "Crashes:(Throughput+Crashes)",
            "Throughput:(Throughput+Crashes)"});
            this.RatioBox.Location = new System.Drawing.Point(939, 219);
            this.RatioBox.Name = "RatioBox";
            this.RatioBox.Size = new System.Drawing.Size(228, 69);
            this.RatioBox.TabIndex = 3;
            // 
            // trialSelect
            // 
            this.trialSelect.Location = new System.Drawing.Point(939, 372);
            this.trialSelect.Name = "trialSelect";
            this.trialSelect.Size = new System.Drawing.Size(116, 23);
            this.trialSelect.TabIndex = 4;
            this.trialSelect.Text = "View Trial XML";
            this.trialSelect.UseVisualStyleBackColor = true;
            this.trialSelect.Click += new System.EventHandler(this.trialSelect_Click);
            // 
            // trialNumBox
            // 
            this.trialNumBox.Location = new System.Drawing.Point(939, 346);
            this.trialNumBox.Mask = "99999";
            this.trialNumBox.Name = "trialNumBox";
            this.trialNumBox.Size = new System.Drawing.Size(100, 20);
            this.trialNumBox.TabIndex = 5;
            // 
            // tNumLabel
            // 
            this.tNumLabel.AutoSize = true;
            this.tNumLabel.Location = new System.Drawing.Point(939, 327);
            this.tNumLabel.Name = "tNumLabel";
            this.tNumLabel.Size = new System.Drawing.Size(70, 13);
            this.tNumLabel.TabIndex = 6;
            this.tNumLabel.Text = "Trial Number:";
            // 
            // trialXML
            // 
            this.trialXML.Location = new System.Drawing.Point(888, 422);
            this.trialXML.Multiline = true;
            this.trialXML.Name = "trialXML";
            this.trialXML.ReadOnly = true;
            this.trialXML.Size = new System.Drawing.Size(278, 303);
            this.trialXML.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 784);
            this.Controls.Add(this.trialXML);
            this.Controls.Add(this.tNumLabel);
            this.Controls.Add(this.trialNumBox);
            this.Controls.Add(this.trialSelect);
            this.Controls.Add(this.RatioBox);
            this.Controls.Add(this.featureName);
            this.Controls.Add(this.openXmlB);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button openXmlB;
        private System.Windows.Forms.TextBox featureName;
        private System.Windows.Forms.ListBox RatioBox;
        private System.Windows.Forms.Button trialSelect;
        private System.Windows.Forms.MaskedTextBox trialNumBox;
        private System.Windows.Forms.Label tNumLabel;
        private System.Windows.Forms.TextBox trialXML;
    }
}

