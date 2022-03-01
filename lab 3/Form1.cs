using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        private int CurRow;
        private Boolean[] WolframCode = new Boolean[8];
        public Form1()
        {
            InitializeComponent();
            CurRow = 0;
            this.dataGridView1.Rows.Add(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                this.dataGridView1.Rows.Add(1);
                CurRow = 0;
            } 
            else
            {
                string BinaryCode = Convert.ToString(Convert.ToInt16(numericUpDown1.Value), 2);
                BinaryCode = new string('0', 8 - BinaryCode.Length) + BinaryCode;
                for (int i = 0; i < 8; i++)
                {
                    if (BinaryCode[7 - i] != '0') WolframCode[i] = true;
                    else WolframCode[i] = false;
                }
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[CurRow].HeaderCell.Value = String.Format("{0}", CurRow + 1);
            int CurCode;
            for (int CurColumn = 0; CurColumn < 14; CurColumn++)
            {
                CurCode = 0;
                if (CurColumn != 0) if (dataGridView1.Rows[CurRow].Cells[CurColumn - 1].Style.BackColor == Color.ForestGreen) CurCode += 4;
                if (dataGridView1.Rows[CurRow].Cells[CurColumn].Style.BackColor == Color.ForestGreen) CurCode += 2;
                if (CurColumn != 13) if (dataGridView1.Rows[CurRow].Cells[CurColumn + 1].Style.BackColor == Color.ForestGreen) CurCode += 1;


                if (WolframCode[CurCode]) dataGridView1.Rows[CurRow + 1].Cells[CurColumn].Style.BackColor = Color.ForestGreen;
            }
            CurRow++;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.ForestGreen)
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
            else dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.ForestGreen;
        }
    }
}
