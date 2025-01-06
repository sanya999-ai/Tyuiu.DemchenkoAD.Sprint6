namespace Tyuiu.DemchenkoAD.Sprint6.Task5.V4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_DAD = new Panel();
            buttonReference_DAD = new Button();
            buttonFile_DAD = new Button();
            buttonDone_DAD = new Button();
            groupBoxTask_DAD = new GroupBox();
            textBox1 = new TextBox();
            panelLeft_DAD = new Panel();
            groupBoxResult_DAD = new GroupBox();
            dataGridViewNums_DAD = new DataGridView();
            panelFill_DAD = new Panel();
            splitterLeft_DAD = new Splitter();
            chartResult_DAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_DAD.SuspendLayout();
            groupBoxTask_DAD.SuspendLayout();
            panelLeft_DAD.SuspendLayout();
            groupBoxResult_DAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_DAD).BeginInit();
            panelFill_DAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAD).BeginInit();
            SuspendLayout();
            // 
            // panelTop_DAD
            // 
            panelTop_DAD.Controls.Add(buttonReference_DAD);
            panelTop_DAD.Controls.Add(buttonFile_DAD);
            panelTop_DAD.Controls.Add(buttonDone_DAD);
            panelTop_DAD.Controls.Add(groupBoxTask_DAD);
            panelTop_DAD.Dock = DockStyle.Top;
            panelTop_DAD.Location = new Point(0, 0);
            panelTop_DAD.Name = "panelTop_DAD";
            panelTop_DAD.Size = new Size(879, 125);
            panelTop_DAD.TabIndex = 0;
            // 
            // buttonReference_DAD
            // 
            buttonReference_DAD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReference_DAD.BackColor = Color.DeepSkyBlue;
            buttonReference_DAD.Location = new Point(773, 26);
            buttonReference_DAD.Name = "buttonReference_DAD";
            buttonReference_DAD.Size = new Size(94, 76);
            buttonReference_DAD.TabIndex = 3;
            buttonReference_DAD.Text = "Справка";
            buttonReference_DAD.UseVisualStyleBackColor = false;
            buttonReference_DAD.Click += buttonReference_DAD_Click;
            // 
            // buttonFile_DAD
            // 
            buttonFile_DAD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFile_DAD.BackColor = Color.BlueViolet;
            buttonFile_DAD.Location = new Point(673, 26);
            buttonFile_DAD.Name = "buttonFile_DAD";
            buttonFile_DAD.Size = new Size(94, 76);
            buttonFile_DAD.TabIndex = 2;
            buttonFile_DAD.Text = "Открыть файл";
            buttonFile_DAD.UseVisualStyleBackColor = false;
            buttonFile_DAD.Click += buttonFile_DAD_Click;
            // 
            // buttonDone_DAD
            // 
            buttonDone_DAD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_DAD.BackColor = Color.Green;
            buttonDone_DAD.Location = new Point(542, 26);
            buttonDone_DAD.Name = "buttonDone_DAD";
            buttonDone_DAD.Size = new Size(125, 76);
            buttonDone_DAD.TabIndex = 1;
            buttonDone_DAD.Text = "Выполнить";
            buttonDone_DAD.UseVisualStyleBackColor = false;
            buttonDone_DAD.Click += buttonDone_DAD_Click;
            // 
            // groupBoxTask_DAD
            // 
            groupBoxTask_DAD.Controls.Add(textBox1);
            groupBoxTask_DAD.Dock = DockStyle.Fill;
            groupBoxTask_DAD.Location = new Point(0, 0);
            groupBoxTask_DAD.Name = "groupBoxTask_DAD";
            groupBoxTask_DAD.Size = new Size(879, 125);
            groupBoxTask_DAD.TabIndex = 0;
            groupBoxTask_DAD.TabStop = false;
            groupBoxTask_DAD.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(495, 93);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutDataFileTask5V4.txt. Вывести в dataGridView целые значения и построить диаграмму по этим значениям.";
            // 
            // panelLeft_DAD
            // 
            panelLeft_DAD.BackColor = SystemColors.Control;
            panelLeft_DAD.Controls.Add(groupBoxResult_DAD);
            panelLeft_DAD.Dock = DockStyle.Left;
            panelLeft_DAD.Location = new Point(0, 125);
            panelLeft_DAD.Name = "panelLeft_DAD";
            panelLeft_DAD.Size = new Size(250, 435);
            panelLeft_DAD.TabIndex = 1;
            // 
            // groupBoxResult_DAD
            // 
            groupBoxResult_DAD.Controls.Add(dataGridViewNums_DAD);
            groupBoxResult_DAD.Dock = DockStyle.Fill;
            groupBoxResult_DAD.Location = new Point(0, 0);
            groupBoxResult_DAD.Name = "groupBoxResult_DAD";
            groupBoxResult_DAD.Size = new Size(250, 435);
            groupBoxResult_DAD.TabIndex = 0;
            groupBoxResult_DAD.TabStop = false;
            groupBoxResult_DAD.Text = "Вывод:";
            // 
            // dataGridViewNums_DAD
            // 
            dataGridViewNums_DAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_DAD.Dock = DockStyle.Fill;
            dataGridViewNums_DAD.Location = new Point(3, 23);
            dataGridViewNums_DAD.Name = "dataGridViewNums_DAD";
            dataGridViewNums_DAD.RowHeadersVisible = false;
            dataGridViewNums_DAD.RowHeadersWidth = 51;
            dataGridViewNums_DAD.Size = new Size(244, 409);
            dataGridViewNums_DAD.TabIndex = 0;
            // 
            // panelFill_DAD
            // 
            panelFill_DAD.BackColor = Color.White;
            panelFill_DAD.Controls.Add(splitterLeft_DAD);
            panelFill_DAD.Controls.Add(chartResult_DAD);
            panelFill_DAD.Dock = DockStyle.Fill;
            panelFill_DAD.Location = new Point(250, 125);
            panelFill_DAD.Name = "panelFill_DAD";
            panelFill_DAD.Size = new Size(629, 435);
            panelFill_DAD.TabIndex = 2;
            // 
            // splitterLeft_DAD
            // 
            splitterLeft_DAD.Location = new Point(0, 0);
            splitterLeft_DAD.Name = "splitterLeft_DAD";
            splitterLeft_DAD.Size = new Size(4, 435);
            splitterLeft_DAD.TabIndex = 2;
            splitterLeft_DAD.TabStop = false;
            // 
            // chartResult_DAD
            // 
            chartResult_DAD.BackColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartResult_DAD.ChartAreas.Add(chartArea1);
            chartResult_DAD.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartResult_DAD.Legends.Add(legend1);
            chartResult_DAD.Location = new Point(0, 0);
            chartResult_DAD.Name = "chartResult_DAD";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_DAD.Series.Add(series1);
            chartResult_DAD.Size = new Size(629, 435);
            chartResult_DAD.TabIndex = 1;
            chartResult_DAD.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 560);
            Controls.Add(panelFill_DAD);
            Controls.Add(panelLeft_DAD);
            Controls.Add(panelTop_DAD);
            MinimumSize = new Size(897, 607);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 4 | Демченко А. Д.";
            panelTop_DAD.ResumeLayout(false);
            groupBoxTask_DAD.ResumeLayout(false);
            groupBoxTask_DAD.PerformLayout();
            panelLeft_DAD.ResumeLayout(false);
            groupBoxResult_DAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_DAD).EndInit();
            panelFill_DAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_DAD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_DAD;
        private Panel panelLeft_DAD;
        private Panel panelFill_DAD;
        private Button buttonDone_DAD;
        private GroupBox groupBoxTask_DAD;
        private TextBox textBox1;
        private Button buttonReference_DAD;
        private Button buttonFile_DAD;
        private GroupBox groupBoxResult_DAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DAD;
        private DataGridView dataGridViewNums_DAD;
        private Splitter splitterLeft_DAD;
    }
}

    

