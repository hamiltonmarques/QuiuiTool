namespace QuiuiApp
{
    partial class FormChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmnChart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnCopy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.cmnChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.cmnChart;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(382, 403);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // cmnChart
            // 
            this.cmnChart.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnChart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnCopy});
            this.cmnChart.Name = "cmnChart";
            this.cmnChart.Size = new System.Drawing.Size(189, 30);
            // 
            // cmnCopy
            // 
            this.cmnCopy.Image = ((System.Drawing.Image)(resources.GetObject("cmnCopy.Image")));
            this.cmnCopy.Name = "cmnCopy";
            this.cmnCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cmnCopy.Size = new System.Drawing.Size(188, 26);
            this.cmnCopy.Text = "Copy all";
            this.cmnCopy.Click += new System.EventHandler(this.CmnCopy_Click);
            // 
            // FrmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.chart);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "FrmChart";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChart";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.cmnChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ContextMenuStrip cmnChart;
        private System.Windows.Forms.ToolStripMenuItem cmnCopy;
    }
}