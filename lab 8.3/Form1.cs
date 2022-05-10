using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int[] statistics = new int[]{0, 0, 0, 0, 0};
            double chance1 = Convert.ToDouble(textBox1.Text);
            double chance2 = chance1 + Convert.ToDouble(textBox2.Text);
            double chance3 = chance2 + Convert.ToDouble(textBox3.Text);
            double chance4 = chance3 + Convert.ToDouble(textBox4.Text);
            double chance5 = 1;
            double A;

            int number_of_trials = Convert.ToInt32(textBox6.Text);
            var random = new Random();
            for (int i = 0; i < number_of_trials; i++)
            {
                A = random.NextDouble();
                if (A < chance1) statistics[0]++;
                else if (A < chance2) statistics[1]++;
                else if (A < chance3) statistics[2]++;
                else if (A < chance4) statistics[3]++;
                else if (A < chance5) statistics[4]++;
            }
            chart1.Series[0].Points.AddXY(1, (double)statistics[0] / number_of_trials);
            chart1.Series[0].Points.AddXY(2, (double)statistics[1] / number_of_trials);
            chart1.Series[0].Points.AddXY(3, (double)statistics[2] / number_of_trials);
            chart1.Series[0].Points.AddXY(4, (double)statistics[3] / number_of_trials);
            chart1.Series[0].Points.AddXY(5, (double)statistics[4] / number_of_trials);
        }
    }
}
