using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        decimal t = 0, x0, y0, v0, cosa, sina;
        double maxX, maxY;
        int time_after_start = 0;

        const decimal g = 9.81M;
        const decimal dt = 0.1M;
        public Form1()
        {
            InitializeComponent();
            pauseButton.Enabled = false;
            continueButton.Enabled = false;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                t = 0;
                x0 = 0;
                y0 = heightNumericUpDown1.Value;
                v0 = speedNumericUpDown2.Value;
                double a = (double)angleNumericUpDown1.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                chart1.Series[0].Points.AddXY(x0, y0);
                timer1.Start();
                pauseButton.Enabled = true;
                continueButton.Enabled = false;
                FindMaximum();
                chart1.ChartAreas[0].AxisX.Maximum = maxX;
                chart1.ChartAreas[0].AxisY.Maximum = maxY;
                time_after_start = 0;
            }
        }

        private void FindMaximum()
        {
            double time = ((double)(v0 * sina) + Math.Sqrt((double)(v0 * v0 * sina * sina) + (double)(2 * g * heightNumericUpDown1.Value))) / (double)g;
            maxX = (double)(v0 * cosa) * time;
            maxX = Math.Ceiling(maxX) + 2;
            maxY = (double)heightNumericUpDown1.Value + (double)(v0 * v0 * sina * sina) / (double)(2 * g);
            maxY = Math.Ceiling(maxY) + 2;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pauseButton.Enabled = false;
            continueButton.Enabled = true;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pauseButton.Enabled = true;
            continueButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            time_after_start += timer1.Interval;
            if (time_after_start % 1000 == 0)
            {
                var timespan = TimeSpan.FromSeconds(time_after_start / 1000);
                timerLabel.Text = timespan.ToString(@"mm\:ss");
            }
            decimal x = x0 + v0 * cosa * t;
            decimal y = y0 + v0 * sina * t - g * t * t / 2;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                pauseButton.Enabled = false;
                continueButton.Enabled = false;
            }
        }
    }
}
