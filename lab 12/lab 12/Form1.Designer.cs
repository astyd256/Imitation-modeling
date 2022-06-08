namespace lab_12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Matrix22 = new System.Windows.Forms.NumericUpDown();
            this.Matrix21 = new System.Windows.Forms.NumericUpDown();
            this.Matrix20 = new System.Windows.Forms.NumericUpDown();
            this.Matrix12 = new System.Windows.Forms.NumericUpDown();
            this.Matrix11 = new System.Windows.Forms.NumericUpDown();
            this.Matrix10 = new System.Windows.Forms.NumericUpDown();
            this.Matrix02 = new System.Windows.Forms.NumericUpDown();
            this.Matrix01 = new System.Windows.Forms.NumericUpDown();
            this.Matrix00 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.day = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.weather = new System.Windows.Forms.Label();
            this.weatherColor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.InputExperiments = new System.Windows.Forms.NumericUpDown();
            this.inputDays = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputExperiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Matrix22);
            this.panel1.Controls.Add(this.Matrix21);
            this.panel1.Controls.Add(this.Matrix20);
            this.panel1.Controls.Add(this.Matrix12);
            this.panel1.Controls.Add(this.Matrix11);
            this.panel1.Controls.Add(this.Matrix10);
            this.panel1.Controls.Add(this.Matrix02);
            this.panel1.Controls.Add(this.Matrix01);
            this.panel1.Controls.Add(this.Matrix00);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 135);
            this.panel1.TabIndex = 0;
            // 
            // Matrix22
            // 
            this.Matrix22.DecimalPlaces = 1;
            this.Matrix22.Enabled = false;
            this.Matrix22.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix22.Location = new System.Drawing.Point(157, 84);
            this.Matrix22.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Matrix22.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Matrix22.Name = "Matrix22";
            this.Matrix22.Size = new System.Drawing.Size(48, 20);
            this.Matrix22.TabIndex = 9;
            this.Matrix22.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            // 
            // Matrix21
            // 
            this.Matrix21.DecimalPlaces = 1;
            this.Matrix21.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix21.Location = new System.Drawing.Point(103, 84);
            this.Matrix21.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Matrix21.Name = "Matrix21";
            this.Matrix21.Size = new System.Drawing.Size(48, 20);
            this.Matrix21.TabIndex = 8;
            this.Matrix21.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.Matrix21.ValueChanged += new System.EventHandler(this.Matrix21_ValueChanged);
            // 
            // Matrix20
            // 
            this.Matrix20.DecimalPlaces = 1;
            this.Matrix20.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix20.Location = new System.Drawing.Point(49, 84);
            this.Matrix20.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Matrix20.Name = "Matrix20";
            this.Matrix20.Size = new System.Drawing.Size(48, 20);
            this.Matrix20.TabIndex = 7;
            this.Matrix20.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix20.ValueChanged += new System.EventHandler(this.Matrix20_ValueChanged);
            // 
            // Matrix12
            // 
            this.Matrix12.DecimalPlaces = 1;
            this.Matrix12.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix12.Location = new System.Drawing.Point(157, 58);
            this.Matrix12.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Matrix12.Name = "Matrix12";
            this.Matrix12.Size = new System.Drawing.Size(48, 20);
            this.Matrix12.TabIndex = 6;
            this.Matrix12.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.Matrix12.ValueChanged += new System.EventHandler(this.Matrix12_ValueChanged);
            // 
            // Matrix11
            // 
            this.Matrix11.DecimalPlaces = 1;
            this.Matrix11.Enabled = false;
            this.Matrix11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix11.Location = new System.Drawing.Point(103, 58);
            this.Matrix11.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Matrix11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Matrix11.Name = "Matrix11";
            this.Matrix11.Size = new System.Drawing.Size(48, 20);
            this.Matrix11.TabIndex = 5;
            this.Matrix11.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147418112});
            // 
            // Matrix10
            // 
            this.Matrix10.DecimalPlaces = 1;
            this.Matrix10.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix10.Location = new System.Drawing.Point(49, 58);
            this.Matrix10.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Matrix10.Name = "Matrix10";
            this.Matrix10.Size = new System.Drawing.Size(48, 20);
            this.Matrix10.TabIndex = 4;
            this.Matrix10.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.Matrix10.ValueChanged += new System.EventHandler(this.Matrix10_ValueChanged);
            // 
            // Matrix02
            // 
            this.Matrix02.DecimalPlaces = 1;
            this.Matrix02.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix02.Location = new System.Drawing.Point(157, 32);
            this.Matrix02.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Matrix02.Name = "Matrix02";
            this.Matrix02.Size = new System.Drawing.Size(48, 20);
            this.Matrix02.TabIndex = 3;
            this.Matrix02.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix02.ValueChanged += new System.EventHandler(this.Matrix02_ValueChanged);
            // 
            // Matrix01
            // 
            this.Matrix01.DecimalPlaces = 1;
            this.Matrix01.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix01.Location = new System.Drawing.Point(103, 32);
            this.Matrix01.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Matrix01.Name = "Matrix01";
            this.Matrix01.Size = new System.Drawing.Size(48, 20);
            this.Matrix01.TabIndex = 2;
            this.Matrix01.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.Matrix01.ValueChanged += new System.EventHandler(this.Matrix01_ValueChanged);
            // 
            // Matrix00
            // 
            this.Matrix00.DecimalPlaces = 1;
            this.Matrix00.Enabled = false;
            this.Matrix00.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Matrix00.Location = new System.Drawing.Point(49, 32);
            this.Matrix00.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Matrix00.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Matrix00.Name = "Matrix00";
            this.Matrix00.Size = new System.Drawing.Size(48, 20);
            this.Matrix00.TabIndex = 1;
            this.Matrix00.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147418112});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(265, 99);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(523, 339);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.day);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.weather);
            this.panel2.Controls.Add(this.weatherColor);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 145);
            this.panel2.TabIndex = 3;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(136, 62);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(50, 20);
            this.day.TabIndex = 11;
            this.day.Text = "Day 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Simulatuion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // weather
            // 
            this.weather.AutoSize = true;
            this.weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather.Location = new System.Drawing.Point(14, 62);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(83, 20);
            this.weather.TabIndex = 4;
            this.weather.Text = "Weather 0";
            // 
            // weatherColor
            // 
            this.weatherColor.BackColor = System.Drawing.Color.Orange;
            this.weatherColor.Location = new System.Drawing.Point(62, 97);
            this.weatherColor.Name = "weatherColor";
            this.weatherColor.Size = new System.Drawing.Size(119, 32);
            this.weatherColor.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.InputExperiments);
            this.panel3.Controls.Add(this.inputDays);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 134);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Launch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InputExperiments
            // 
            this.InputExperiments.Location = new System.Drawing.Point(17, 91);
            this.InputExperiments.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputExperiments.Name = "InputExperiments";
            this.InputExperiments.Size = new System.Drawing.Size(94, 20);
            this.InputExperiments.TabIndex = 13;
            this.InputExperiments.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // inputDays
            // 
            this.inputDays.Location = new System.Drawing.Point(17, 55);
            this.inputDays.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputDays.Name = "inputDays";
            this.inputDays.Size = new System.Drawing.Size(94, 20);
            this.inputDays.TabIndex = 12;
            this.inputDays.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Experiment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(265, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(523, 80);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Clear";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cloudy";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Overcast";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "T";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputExperiments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Matrix01;
        private System.Windows.Forms.NumericUpDown Matrix00;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown Matrix12;
        private System.Windows.Forms.NumericUpDown Matrix11;
        private System.Windows.Forms.NumericUpDown Matrix10;
        private System.Windows.Forms.NumericUpDown Matrix02;
        private System.Windows.Forms.NumericUpDown Matrix22;
        private System.Windows.Forms.NumericUpDown Matrix21;
        private System.Windows.Forms.NumericUpDown Matrix20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel weatherColor;
        private System.Windows.Forms.Label weather;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown InputExperiments;
        private System.Windows.Forms.NumericUpDown inputDays;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

