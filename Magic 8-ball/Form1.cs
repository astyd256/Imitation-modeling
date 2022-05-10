using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, string> results = new Dictionary<int, string>()
        {
            { 1, "It is certain."},
            { 2, "It is decidedly so."},
            { 3, "Without a doubt."},
            { 4, "Yes definitely."},
            { 5, "You may rely on it."},
            { 6, "As I see it, yes."},
            { 7, "Most likely."},
            { 8, "Outlook good."},
            { 9, "Yes."},
            { 10, "Signs point to yes."},
            { 11, "Reply hazy, try again."},
            { 12, "Ask again later."},
            { 13, "Better not tell you now."},
            { 14, "Cannot predict now."},
            { 15, "Concentrate and ask again."},
            { 16, "Don't count on it."},
            { 17, "My reply is no."},
            { 18, "My sources say no."},
            { 19, "Outlook not so good."},
            { 20, "Very doubtful."}
        };

        private void button1_Click(object sender, EventArgs e)
        {
            // 0,05 each event
            var rand = new Random();
            double A = rand.NextDouble();
            for (int i = 1; i < 20; i++)
                if (A < i * 0.05)
                {
                    label1.Text = results[i];
                    if (i < 11) label1.BackColor = Color.Green;
                    else if (i < 16) label1.BackColor = Color.Yellow;
                    else if (i < 21) label1.BackColor = Color.Red;
                    break;
                }
        }
    }
}
