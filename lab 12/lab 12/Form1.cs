using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        double dayCounter = 0;
        int curWeather = 0;
        decimal[,] matrix = new decimal[3, 3];

        private void Matrix01_ValueChanged(object sender, EventArgs e)
        {
            decimal a = 0;
            a += (decimal)Matrix01.Value;
            a += (decimal)Matrix02.Value;
            Matrix00.Value = a;
        }

        private void Matrix02_ValueChanged(object sender, EventArgs e)
        {
            decimal a = 0;
            a += (decimal)Matrix01.Value;
            a += (decimal)Matrix02.Value;
            Matrix00.Value = a;
        }

        private void Matrix10_ValueChanged(object sender, EventArgs e)
        {
            decimal a = 0;
            a += (decimal)Matrix10.Value;
            a += (decimal)Matrix12.Value;
            Matrix11.Value = a;
        }

        private void Matrix12_ValueChanged(object sender, EventArgs e)
        {
            decimal a = 0;
            a += (decimal)Matrix10.Value;
            a += (decimal)Matrix12.Value;
            Matrix11.Value = a;
        }

        private void Matrix20_ValueChanged(object sender, EventArgs e)
        {
            decimal a = 0;
            a += (decimal)Matrix20.Value;
            a += (decimal)Matrix21.Value;
            Matrix22.Value = a;
        }

        private void Matrix21_ValueChanged(object sender, EventArgs e)
        {
            decimal a = 0;
            a += (decimal)Matrix20.Value;
            a += (decimal)Matrix21.Value;
            Matrix22.Value = a;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double a = random.NextDouble();
            dayCounter += Math.Log(a) / (float)matrix[curWeather, curWeather];
            day.Text = "Day " + Math.Round(dayCounter, 2);

            for (int i = 0; i < 3; i++)
            {
                if (i != curWeather)
                {
                    a += (float)(matrix[curWeather, i]/matrix[curWeather, curWeather]);
                    if (a <= 0)
                    {
                        weather.Text = "Weather " + i;
                        curWeather = i;
                        switch (i)
                        {
                            case 0:
                                weatherColor.BackColor = Color.Orange;
                                break;
                            case 1:
                                weatherColor.BackColor = Color.Cyan;
                                break;
                            case 2:
                                weatherColor.BackColor = Color.Gray;
                                break;
                        }
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                button1.Text = "Stop Simulation";
                curWeather = 0;
                Matrix01.Enabled = false;
                Matrix02.Enabled = false;
                Matrix10.Enabled = false;
                Matrix12.Enabled = false;
                Matrix20.Enabled = false;
                Matrix21.Enabled = false;
                matrix[0, 0] = Matrix00.Value;
                matrix[0, 1] = Matrix01.Value;
                matrix[0, 2] = Matrix02.Value;
                matrix[1, 0] = Matrix10.Value;
                matrix[1, 1] = Matrix11.Value;
                matrix[1, 2] = Matrix12.Value;
                matrix[2, 0] = Matrix20.Value;
                matrix[2, 1] = Matrix21.Value;
                matrix[2, 2] = Matrix22.Value;
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Start Simulation";
                timer1.Enabled= false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: Reset button

            Matrix01.Enabled = false;
            Matrix02.Enabled = false;
            Matrix10.Enabled = false;
            Matrix12.Enabled = false;
            Matrix20.Enabled = false;
            Matrix21.Enabled = false;
            dayCounter = 0;
            day.Text = "Day 0";
            weather.Text = "Weather 0";
            weatherColor.BackColor = Color.Orange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] Freq = { 0, 0, 0 };
            matrix[0, 0] = Matrix00.Value;
            matrix[0, 1] = Matrix01.Value;
            matrix[0, 2] = Matrix02.Value;
            matrix[1, 0] = Matrix10.Value;
            matrix[1, 1] = Matrix11.Value;
            matrix[1, 2] = Matrix12.Value;
            matrix[2, 0] = Matrix20.Value;
            matrix[2, 1] = Matrix21.Value;
            matrix[2, 2] = Matrix22.Value;
            float N = (float)InputExperiments.Value;
            decimal T = inputDays.Value;
            // TODO: Add experiment
            for (int j = 0; j < N; j++)
            {
                curWeather = 0;
                for (double i = 0, tau = 0, a; i < (float)T; i += tau)
                {
                    a = random.NextDouble();
                    tau += Math.Log(a) / (float)matrix[curWeather, curWeather];
                    for (int k = 0; k < 3; k++)
                    {
                        if (k != curWeather)
                        {
                            a += (float)(matrix[curWeather, k] / matrix[curWeather, curWeather]);
                            if (a <= 0)
                            {
                                curWeather = k;
                                break;
                            }
                        }
                    }
                }
                Freq[curWeather]++;

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows[0].Cells[0].Value = Freq[0] / N;
            dataGridView1.Rows[0].Cells[1].Value = Freq[1] / N;
            dataGridView1.Rows[0].Cells[2].Value = Freq[2] / N;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(0, Freq[0] / N);
            chart1.Series[0].Points.AddXY(1, Freq[1] / N);
            chart1.Series[0].Points.AddXY(2, Freq[2] / N);
        }
    }
}
