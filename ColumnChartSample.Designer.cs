namespace WindowsFormsApplication1
{
    partial class ColumnChartSample
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
            this.DemoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DemoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DemoChart
            // 
            this.DemoChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.DemoChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DemoChart.Legends.Add(legend1);
            this.DemoChart.Location = new System.Drawing.Point(36, 85);
            this.DemoChart.Name = "DemoChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DemoChart.Series.Add(series1);
            this.DemoChart.Size = new System.Drawing.Size(654, 300);
            this.DemoChart.TabIndex = 1;
            this.DemoChart.Text = "chart1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(36, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(208, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Data from Azure Table";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ColumnChartSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 418);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.DemoChart);
            this.Name = "ColumnChartSample";
            this.ShowIcon = false;
            this.Text = "Column Chart Sample";
            ((System.ComponentModel.ISupportInitialize)(this.DemoChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DemoChart;
        private System.Windows.Forms.Button btnLoad;
    }
}