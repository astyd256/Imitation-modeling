using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chance = Convert.ToDouble(textBox2.Text);
            var rand = new Random();
            if (rand.NextDouble() >= chance) 
            {   
                label2.Text = "YES!";
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Green; 
            }
            else
            {
                label2.Text = "NO!";
                label2.ForeColor= Color.White; 
                label2.BackColor = Color.Red;
            }

        }
    }
}
