﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double EuroRate, DollarRate;
        const double k = 0.05;
        int day;
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) timer1.Enabled = false;
            else 
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                day = 0;
                chart1.Series[0].Points.AddXY(day, EuroField.Value);
                chart1.Series[1].Points.AddXY(day, DollarField.Value);
                EuroRate = (double)EuroField.Value;
                DollarRate = (double)DollarField.Value;
                timer1.Enabled = true;
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            day++;
            EuroRate *= (1 + k * (random.NextDouble() - 0.5));
            DollarRate *= (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(day, EuroRate);
            chart1.Series[1].Points.AddXY(day, DollarRate);
        }
    }
}
