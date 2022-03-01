namespace lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtField = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.WeightField = new System.Windows.Forms.NumericUpDown();
            this.SizeField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SpeedField = new System.Windows.Forms.NumericUpDown();
            this.AngleField = new System.Windows.Forms.NumericUpDown();
            this.HeightField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DBResults = new System.Windows.Forms.DataGridView();
            this.dt_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dist_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mxht_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spatedpt_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DtField);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.WeightField);
            this.panel1.Controls.Add(this.SizeField);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.SpeedField);
            this.panel1.Controls.Add(this.AngleField);
            this.panel1.Controls.Add(this.HeightField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 199);
            this.panel1.TabIndex = 0;
            // 
            // DtField
            // 
            this.DtField.DecimalPlaces = 2;
            this.DtField.Location = new System.Drawing.Point(415, 135);
            this.DtField.Name = "DtField";
            this.DtField.Size = new System.Drawing.Size(120, 20);
            this.DtField.TabIndex = 12;
            this.DtField.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "dt";
            // 
            // WeightField
            // 
            this.WeightField.DecimalPlaces = 2;
            this.WeightField.Location = new System.Drawing.Point(415, 83);
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(120, 20);
            this.WeightField.TabIndex = 10;
            this.WeightField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeField
            // 
            this.SizeField.DecimalPlaces = 2;
            this.SizeField.Location = new System.Drawing.Point(415, 32);
            this.SizeField.Name = "SizeField";
            this.SizeField.Size = new System.Drawing.Size(120, 20);
            this.SizeField.TabIndex = 9;
            this.SizeField.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(637, 85);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(184, 71);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Launch";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SpeedField
            // 
            this.SpeedField.DecimalPlaces = 2;
            this.SpeedField.Location = new System.Drawing.Point(134, 136);
            this.SpeedField.Name = "SpeedField";
            this.SpeedField.Size = new System.Drawing.Size(120, 20);
            this.SpeedField.TabIndex = 5;
            this.SpeedField.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // AngleField
            // 
            this.AngleField.DecimalPlaces = 2;
            this.AngleField.Location = new System.Drawing.Point(134, 83);
            this.AngleField.Name = "AngleField";
            this.AngleField.Size = new System.Drawing.Size(120, 20);
            this.AngleField.TabIndex = 4;
            this.AngleField.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // HeightField
            // 
            this.HeightField.DecimalPlaces = 2;
            this.HeightField.Location = new System.Drawing.Point(134, 33);
            this.HeightField.Name = "HeightField";
            this.HeightField.Size = new System.Drawing.Size(120, 20);
            this.HeightField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // Graph
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.Maximum = 5D;
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.Location = new System.Drawing.Point(0, 205);
            this.Graph.Name = "Graph";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.MediumAquamarine;
            series1.Name = "Series1";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(885, 592);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DBResults
            // 
            this.DBResults.AllowUserToAddRows = false;
            this.DBResults.AllowUserToDeleteRows = false;
            this.DBResults.AllowUserToResizeColumns = false;
            this.DBResults.AllowUserToResizeRows = false;
            this.DBResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_column,
            this.dist_column,
            this.mxht_column,
            this.spatedpt_column});
            this.DBResults.Location = new System.Drawing.Point(891, 0);
            this.DBResults.Name = "DBResults";
            this.DBResults.ReadOnly = true;
            this.DBResults.Size = new System.Drawing.Size(444, 821);
            this.DBResults.TabIndex = 13;
            // 
            // dt_column
            // 
            this.dt_column.HeaderText = "Time step";
            this.dt_column.Name = "dt_column";
            this.dt_column.ReadOnly = true;
            // 
            // dist_column
            // 
            this.dist_column.HeaderText = "Distance";
            this.dist_column.Name = "dist_column";
            this.dist_column.ReadOnly = true;
            // 
            // mxht_column
            // 
            this.mxht_column.HeaderText = "Max height";
            this.mxht_column.Name = "mxht_column";
            this.mxht_column.ReadOnly = true;
            // 
            // spatedpt_column
            // 
            this.spatedpt_column.HeaderText = "Speed at the end point";
            this.spatedpt_column.Name = "spatedpt_column";
            this.spatedpt_column.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 821);
            this.Controls.Add(this.DBResults);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpeedField;
        private System.Windows.Forms.NumericUpDown AngleField;
        private System.Windows.Forms.NumericUpDown HeightField;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SizeField;
        private System.Windows.Forms.NumericUpDown WeightField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown DtField;
        private System.Windows.Forms.DataGridView DBResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dist_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn mxht_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn spatedpt_column;
    }
}

