using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_11
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
            double math_expectation = Convert.ToDouble(textBox1.Text);
            double math_variance = Convert.ToDouble(textBox2.Text);

            int sample_size = Convert.ToInt32(textBox6.Text);
            var random = new Random();
            
            double[] Stndrt_distr = new double[sample_size];
            double[] Gauss_distr = new double[sample_size];

            Stndrt_distr[0] = Math.Sqrt(-2 * Math.Log(random.NextDouble())) * Math.Sin(2 * Math.PI * random.NextDouble());
            Gauss_distr[0] = Math.Sqrt(math_variance) * Stndrt_distr[0] + math_expectation;

            double min = Gauss_distr[0];
            double max = Gauss_distr[0];
            for (int i = 1; i < sample_size; i++)
            {
                Stndrt_distr[i] = Math.Sqrt(-2 * Math.Log(random.NextDouble())) * Math.Sin(2 * Math.PI * random.NextDouble());
                Gauss_distr[i] = Math.Sqrt(math_variance) * Stndrt_distr[i] + math_expectation;
                if (Gauss_distr[i] > max) max = Gauss_distr[i];
                if (Gauss_distr[i] < min) min = Gauss_distr[i];
            }

            int k = (int)Math.Floor(Math.Log(sample_size, 2)); //number of intervals

            int[] statistics = new int[k];
            double intervals = Math.Abs(max - min) / k;

            for (int i = 0; i < sample_size; i++) //counting results
            {
                for (int j = 1; j < k; j++) // deciding in which interval to add
                    if (Gauss_distr[i] < min + intervals * (j + 1)) { statistics[j]++; break; }
            }

            double emperic_expectation = 0;
            double emperic_variance = 0;

            /*getting emperic values*/
            for (int i = 0; i < sample_size; i++) emperic_expectation += Gauss_distr[i];
            emperic_expectation /= sample_size;
            for (int i = 0; i < sample_size; i++) emperic_variance += Gauss_distr[i] * Gauss_distr[i];
            emperic_variance = emperic_variance / sample_size - emperic_expectation * emperic_expectation;

            ///*counting errors*/
            double expectation_error = Math.Abs(emperic_expectation - math_expectation) / Math.Abs(math_expectation);
            double variance_error = Math.Abs(emperic_variance - math_variance) / Math.Abs(math_variance);

            /*outputing result*/
            for (int i = 0; i < k; i++) chart1.Series[0].Points.AddXY($"({Math.Round(min + intervals * (i), 1)}; " +
                $"{Math.Round(min + intervals * (i + 1), 1)}] ", (double)statistics[i] / sample_size);
            expectation_label.Text = $"Average: {Math.Round(emperic_expectation, 2)} (error = {Math.Round(expectation_error * 100)}%)";
            variance_label.Text = $"Variance: {Math.Round(emperic_variance, 2)} (error = {Math.Round(variance_error * 100)}%)";

            double cur_chi = 0;
            double pi = 0;
            double x = 0;
            for (int i = 0; i < k; i++)
            {

                //x = min + intervals * (i + 1) + min + intervals * i / 2;
                //pi = (min + intervals * (i + 1) - (min + intervals * i))
                //    * 1 / Math.Sqrt(2 * math_variance * Math.PI)
                //    * Math.Exp(Math.Pow(x - math_expectation, 2) / (2 * math_variance));

                pi = (min + intervals * (i + 1) - (min + intervals * i))
                    * (double)statistics[i] / sample_size
                    * (min + intervals * (i + 1) + min + intervals * i) / 2;

                if (pi != 0) cur_chi += Math.Pow(statistics[i], 2) / (sample_size * pi);
            } 
            cur_chi -= sample_size;
            chi_label.Text = $"Chi-squared: {Math.Round(cur_chi, 2)} > {CHI_VALUE} is {(cur_chi > CHI_VALUE ? "TRUE" : "FALSE")}";
        }
    }
}
