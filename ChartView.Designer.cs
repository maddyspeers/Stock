namespace Project_3
{
    partial class ChartView
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
            this.viewchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboDoji = new System.Windows.Forms.ComboBox();
            this.dojicombo = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewchart)).BeginInit();
            this.SuspendLayout();
            // 
            // viewchart
            // 
            chartArea1.Name = "OHLC";
            this.viewchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.viewchart.Legends.Add(legend1);
            this.viewchart.Location = new System.Drawing.Point(0, 0);
            this.viewchart.Name = "viewchart";
            series1.ChartArea = "OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "OHLC";
            series1.YValuesPerPoint = 4;
            this.viewchart.Series.Add(series1);
            this.viewchart.Size = new System.Drawing.Size(788, 368);
            this.viewchart.TabIndex = 0;
            this.viewchart.Text = "chartview";
            // 
            // comboDoji
            // 
            this.comboDoji.FormattingEnabled = true;
            this.comboDoji.Location = new System.Drawing.Point(23, 381);
            this.comboDoji.Name = "comboDoji";
            this.comboDoji.Size = new System.Drawing.Size(166, 24);
            this.comboDoji.TabIndex = 1;
            this.comboDoji.SelectedIndexChanged += new System.EventHandler(this.comboDoji_SelectedIndexChanged);
            // 
            // dojicombo
            // 
            this.dojicombo.AutoSize = true;
            this.dojicombo.Location = new System.Drawing.Point(72, 408);
            this.dojicombo.Name = "dojicombo";
            this.dojicombo.Size = new System.Drawing.Size(72, 16);
            this.dojicombo.TabIndex = 2;
            this.dojicombo.Text = "Select Doji";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(211, 381);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(195, 51);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.dojicombo);
            this.Controls.Add(this.comboDoji);
            this.Controls.Add(this.viewchart);
            this.Name = "ChartView";
            this.Text = "ChartView";
            this.Load += new System.EventHandler(this.Chart_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart viewchart;
        private System.Windows.Forms.ComboBox comboDoji;
        private System.Windows.Forms.Label dojicombo;
        private System.Windows.Forms.Button exitbutton;
    }
}