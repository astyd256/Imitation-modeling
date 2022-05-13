using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, string> names = new Dictionary<int, string>()
        {
            { 1, "Real Madrid"},
            { 2, "Unstoppable"},
            { 3, "Alliance"},
            { 4, "Collective"},
            { 5, "Avengers"},
            { 6, "Phenomenon"},
            { 7, "Rumble"},
            { 8, "Obliterators"},
            { 9, "Lightning"},
            { 10, "Assassins"},
            { 11, "Outlaws"},
            { 12, "End Game"},
            { 13, "Rebels"},
            { 14, "Force"},
            { 15, "All-Stars"},
            { 16, "Hustle"}
        };
        private struct Team
        {
            public string name;
            public int wins;
            public int loses;
            public int draw;
            public int lambda;
        }
        // POINTS SYSTEM: WIN = 3PNT, DRAW = 1PNT, LOSS = 0PNT.
        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int m = Convert.ToInt32(textBox1.Text);
            if (m > 0 && m < 17)
            {
                Team[] team = new Team[m];
                for (int i = 0; i < m; i++)
                {
                    team[i].name = names[i + 1];
                    team[i].lambda = random.Next(5);
                    team[i].wins = 0;
                    team[i].loses = 0;
                    team[i].draw = 0;
                }
                double S;
                int GOAL1;
                int GOAL2;

                for (int j = 0; j < m; j++)
                {
                    for(int i = 0; i < m; i++)
                    {
                        if (i != j)
                        {
                            S = 0;
                            GOAL1 = 0;
                            for (; S >= -team[j].lambda; S += Math.Log(random.NextDouble())) GOAL1++;
                            S = 0;
                            GOAL2 = 0;
                            for (; S >= -team[i].lambda; S += Math.Log(random.NextDouble())) GOAL2++;
                            if (GOAL1 > GOAL2)
                            {
                                team[j].wins++;
                                team[i].loses++;
                            }
                            else if (GOAL1 < GOAL2)
                            {
                                team[j].loses++;
                                team[i].wins++;
                            }
                            else
                            {
                                team[i].draw++;
                                team[j].draw++;
                            }
                        }
                    }
                }
                dataGridView1.Rows.Clear();
                for (int i = 0; i < m; i++)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[0].Value = team[i].name;
                    dataGridView1.Rows[i].Cells[1].Value = team[i].lambda;
                    dataGridView1.Rows[i].Cells[2].Value = team[i].wins;
                    dataGridView1.Rows[i].Cells[3].Value = team[i].loses;
                    dataGridView1.Rows[i].Cells[4].Value = team[i].draw;
                    dataGridView1.Rows[i].Cells[5].Value = team[i].wins * 3 + team[i].draw;
                    dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
                }
            }
        }
    }
}
