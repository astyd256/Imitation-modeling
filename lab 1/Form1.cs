using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double 
            g = 9.81, 
            C = 0.15, 
            rho = 1.29;

        double maxheight, height, angle, speed, cosa, sina, beta, t, x, y, S, m, k, vx, vy , dt;

        private void StartButton_Click(object sender, EventArgs e)
        {
            height = (double)HeightField.Value;
            angle = (double)AngleField.Value;
            speed = (double)SpeedField.Value;
            S = (double)SizeField.Value;
            m = (double)WeightField.Value;
            dt = (double)DtField.Value;

            
            t = 0;
            x = 0;
            y = height;
            maxheight = height;

            cosa = Math.Cos(angle / 180 * Math.PI);
            sina = Math.Sin(angle / 180 * Math.PI);

            beta = 0.5 * C * S * rho;
            k = beta / m;

            vx = speed * cosa;
            vy = speed * sina;

            Graph.Series[0].Points.Clear();
            Graph.Series[0].Points.AddXY(x, y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double vx_old = vx;
            double vy_old = vy;
            double root =  Math.Sqrt(vx * vx + vy * vy);

            t = t + dt;

            vx = vx_old - k * vx_old * root * dt;
            vy = vy_old - (g + k * vy_old * root) * dt;

            x = x + vx * dt;
            y = y + vy * dt;

            Graph.Series[0].Points.AddXY(x, y);

            if (y > maxheight) maxheight = y;

            if (y <= 0) 
            {
                DBResults.Rows.Add(dt, x, maxheight, Math.Sqrt(vx*vx + vy*vy));
                timer1.Stop();

            }

        }
    }
   
}
