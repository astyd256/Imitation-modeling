using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double CHI_VALUE = 9.488;
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            int[] statistics = new int[]{0, 0, 0, 0, 0};
            double[] chance = new double[5];
            chance[0] = Convert.ToDouble(textBox1.Text);
            chance[1] = Convert.ToDouble(textBox2.Text);
            chance[2] = Convert.ToDouble(textBox3.Text);
            chance[3] = Convert.ToDouble(textBox4.Text);
            chance[4] = 1 - chance[0] - chance[1] - chance[2] - chance[3];
            double A;

            int number_of_trials = Convert.ToInt32(textBox6.Text);
            var random = new Random();

            double math_expectation = 0;
            double math_variance = 0;
            for (int i = 0; i < 5; i++) math_expectation += chance[i] * (i + 1);
            for (int i = 0; i < 5; i++) math_variance += chance[i] * (i + 1) * (i + 1);
            math_variance -= math_expectation * math_expectation;
            for (int i = 0; i < number_of_trials; i++)
            {
                A = random.NextDouble();
                if (A < chance[0]) statistics[0]++;
                else if (A < chance[0] + chance[1]) statistics[1]++;
                else if (A < chance[0] + chance[1] + chance[2]) statistics[2]++;
                else if (A < chance[0] + chance[1] + chance[2] + chance[3]) statistics[3]++;
                else if (A < 1) statistics[4]++;
            }

            double[] real_chance = new double[5];
            double emperic_expectation = 0;
            double emperic_variance = 0;
            
            /*getting emperic values*/
            for (int i = 0; i < 5; i++) real_chance[i] = (double)statistics[i] / number_of_trials; 
            for (int i = 0; i < 5; i++) emperic_expectation += real_chance[i] * (i + 1);
            for (int i = 0; i < 5; i++) emperic_variance += real_chance[i] * (i + 1) * (i + 1);
            emperic_variance -= emperic_expectation * emperic_expectation;

            /*counting errors*/
            double expectation_error = Math.Abs(emperic_expectation - math_expectation) / Math.Abs(math_expectation);
            double variance_error = Math.Abs(emperic_variance - math_variance) / Math.Abs(math_variance);

            /*outputing result*/
            for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i+1, real_chance[i]);
            expectation_label.Text = $"Average: {emperic_expectation} (error = {Math.Round(expectation_error * 100)}%)";
            variance_label.Text = $"Variance: {emperic_variance} (error = {Math.Round(variance_error * 100)}%)";

            double cur_chi = 0;
            double abs_chi = 0;
            for (int i = 0; i < 5; i++) cur_chi += Math.Pow(statistics[i], 2) / (number_of_trials * chance[i]);
            cur_chi -= number_of_trials;
            chi_label.Text = $"Chi-squared: {Math.Round(cur_chi, 2)} > {CHI_VALUE} is {(cur_chi > CHI_VALUE ? "TRUE" : "FALSE")}";
        }
    }
}
