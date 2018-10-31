using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuiuiApp
{
    /// <summary>
    /// Represents a pie chart used by QuiuiTool application.
    /// </summary>
    /// <remarks>
    /// The MIT License (MIT) Copyright (c) 2018 Hamilton Marques.
    /// Meet Hamilton Marques at http://bit.do/HamiltonLinkedIn
    /// Videos about QuiuiTool at http://bit.do/QuiuiTool
    /// </remarks>
    public partial class FormChart : Form
    {
        /// <summary>
        /// Initializes a new instance of the FormChart class.
        /// </summary>
        public FormChart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Makes a pie chart containing the total of passed, failed and inconclusive results (if greater than zero).
        /// Occurs before the FormChart is displayed for the first time.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void FormChart_Load(object sender, EventArgs e)
        {
            chart.Series.Clear();

            string serie = "Results";

            chart.Series.Add(serie);
            chart.Series[serie].ChartType = SeriesChartType.Pie;
            chart.Series[0]["PieLabelStyle"] = "Disabled";

            Dictionary<string, decimal> stats = new Dictionary<string, decimal>
            {
                { FormQuiui.text[0], FormQuiui.passed },
                { FormQuiui.text[1], FormQuiui.failed },
                { FormQuiui.text[2], FormQuiui.inconclusive }
            };

            var orderBy = stats.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key);

            int i = 0;

            foreach (var item in orderBy)
            {
                if (item.Value > 0)
                {
                    chart.Series[serie].Points.AddXY(item.Key, item.Value);

                    if (item.Key.Equals(FormQuiui.text[0]))
                    {
                        chart.Series[serie].Points[i].Color = Color.FromArgb(0, 175, 95);
                    }
                    else if (item.Key.Equals(FormQuiui.text[1]))
                    {
                        chart.Series[serie].Points[i].Color = Color.FromArgb(255, 60, 60);
                    }
                    else
                    {
                        chart.Series[serie].Points[i].Color = Color.FromArgb(0, 140, 200);
                    }

                    chart.Series[serie].Points[i].LegendText = "#VAL " + item.Key;
                    i++;
                }
            }

            chart.Series[0].ToolTip = "#PERCENT{#.##%}";

            this.Text = FormQuiui.text[26];
            cmnCopy.Text = FormQuiui.text[28];
        }

        /// <summary>
        /// Copies the FormChart as image to the clipboard.
        /// Occurs when the cmnCopy is clicked or selected using a shortcut key or access key defined for it.
        /// </summary>
        /// <param name="sender">Default C# parameter.</param>
        /// <param name="e">Default C# parameter.</param>
        private void CmnCopy_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(PointToScreen(ClientRectangle.Location).X, PointToScreen(ClientRectangle.Location).Y, 0, 0, ClientRectangle.Size);
                }

                Clipboard.SetImage(bmp);
            }
        }
    }
}