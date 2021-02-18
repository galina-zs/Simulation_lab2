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

        const decimal g = 9.81M;
        const decimal dt = 0.1M;
        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisY.Maximum = 20;
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
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            decimal x = x0 + v0 * cosa * t;
            decimal y = y0 + v0 * sina * t - g * t * t / 2;
            if ((x >= (decimal)chart1.ChartAreas[0].AxisX.Maximum - 20) && Math.Ceiling(x) % 5 == 0)
            {
                chart1.ChartAreas[0].AxisX.Maximum = (double)Math.Ceiling(x) + 10;
            }
            if ((y >= (decimal)chart1.ChartAreas[0].AxisY.Maximum - 20) 
                && y > (decimal)chart1.ChartAreas[0].AxisY.Maximum
                && Math.Ceiling(y) % 5 == 0)
            {
                chart1.ChartAreas[0].AxisY.Maximum = (double)Math.Ceiling(y) + 10;
            }
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0) timer1.Stop();
        }
    }
}
