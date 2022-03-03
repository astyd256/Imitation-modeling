using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void onStartBtn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) // stop
            {
                timer1.Enabled = false;
            } 
            else // start
            {

                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // Von Neumann neighborhood
           // Conway's Game of Life rules of surviving.
           int neighbours;
           for (int i = 0; i < widthField.Value; i++)
           {
                for (int j = 0; j < heightField.Value; j++)
                {
                    neighbours = 0;

                    // neighbours counting
                    if (j != 0 && dataGridView1.Rows[j - 1].Cells[i].Style.BackColor == Color.ForestGreen) neighbours++;
                    if (j != heightField.Value - 1 && dataGridView1.Rows[j + 1].Cells[i].Style.BackColor == Color.ForestGreen) neighbours++;
                    if (i != 0 && dataGridView1.Rows[j].Cells[i - 1].Style.BackColor == Color.ForestGreen) neighbours++;
                    if (i != widthField.Value - 1 && dataGridView1.Rows[j].Cells[i + 1].Style.BackColor == Color.ForestGreen) neighbours++;

                    
                    
                    if (dataGridView1.Rows[j].Cells[i].Style.BackColor == Color.ForestGreen && neighbours != 2 && neighbours != 3) // if not enough neighbours cell dies
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Empty;
                    if (dataGridView1.Rows[j].Cells[i].Style.BackColor != Color.ForestGreen && neighbours == 3)   // if enough neighbours cell live again
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.ForestGreen;

                }
           }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.ForestGreen)
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            else dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.ForestGreen;
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.RowTemplate.Height = dataGridView1.Height / Convert.ToInt16(heightField.Value);
            for (int i = 0; i < widthField.Value; i++) dataGridView1.Columns.Add("Column" + Convert.ToString(i), "");
            dataGridView1.Rows.Add(Convert.ToInt16(heightField.Value));
            
        }

        private void genRandBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.RowTemplate.Height = dataGridView1.Height / Convert.ToInt16(heightField.Value);
            for (int i = 0; i < widthField.Value; i++) dataGridView1.Columns.Add("Column" + Convert.ToString(i), "");
            dataGridView1.Rows.Add(Convert.ToInt16(heightField.Value));


            int percent = Convert.ToInt16(numericUpDown2.Value) % 100;
            Random rand = new Random();

            for (int i = 0; i < widthField.Value; i++)
            {
                for (int j = 0; j < heightField.Value; j++)
                {
                    if (rand.Next() % 100 < percent) dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.ForestGreen;
                }
            }
        }
    }
}
