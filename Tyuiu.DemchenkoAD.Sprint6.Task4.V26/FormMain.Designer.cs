namespace Tyuiu.DemchenkoAD.Sprint6.Task4.V26
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCondition_DAD = new GroupBox();
            labelConditionText_DAD = new Label();
            groupBoxInput_DAD = new GroupBox();
            textBoxInputStart_DAD = new TextBox();
            labelStop_DAD = new Label();
            textBoxInputStop_DAD = new TextBox();
            labelStart_DAD = new Label();
            groupBoxOutput_DAD = new GroupBox();
            textBoxOutput_DAD = new TextBox();
            buttonStart_DAD = new Button();
            buttonHelp_DAD = new Button();
            buttonDADe_DAD = new Button();
            chartDiagram_DAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_DAD.SuspendLayout();
            groupBoxInput_DAD.SuspendLayout();
            groupBoxOutput_DAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_DAD).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DAD
            // 
            groupBoxCondition_DAD.Controls.Add(labelConditionText_DAD);
            groupBoxCondition_DAD.Location = new Point(12, 12);
            groupBoxCondition_DAD.Name = "groupBoxCondition_DAD";
            groupBoxCondition_DAD.Size = new Size(444, 85);
            groupBoxCondition_DAD.TabIndex = 0;
            groupBoxCondition_DAD.TabStop = false;
            groupBoxCondition_DAD.Text = "Условие:";
            // 
            // labelConditionText_DAD
            // 
            labelConditionText_DAD.AutoSize = true;
            labelConditionText_DAD.Location = new Point(6, 19);
            labelConditionText_DAD.Name = "labelConditionText_DAD";
            labelConditionText_DAD.Size = new Size(429, 45);
            labelConditionText_DAD.TabIndex = 3;
            labelConditionText_DAD.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. \r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V26.txt по нажатию кнопки.";
            // 
            // groupBoxInput_DAD
            // 
            groupBoxInput_DAD.Controls.Add(textBoxInputStart_DAD);
            groupBoxInput_DAD.Controls.Add(labelStop_DAD);
            groupBoxInput_DAD.Controls.Add(textBoxInputStop_DAD);
            groupBoxInput_DAD.Controls.Add(labelStart_DAD);
            groupBoxInput_DAD.Location = new Point(462, 12);
            groupBoxInput_DAD.Name = "groupBoxInput_DAD";
            groupBoxInput_DAD.Size = new Size(218, 85);
            groupBoxInput_DAD.TabIndex = 1;
            groupBoxInput_DAD.TabStop = false;
            groupBoxInput_DAD.Text = "Ввод данных:";
            // 
            // textBoxInputStart_DAD
            // 
            textBoxInputStart_DAD.Location = new Point(6, 41);
            textBoxInputStart_DAD.Name = "textBoxInputStart_DAD";
            textBoxInputStart_DAD.Size = new Size(100, 23);
            textBoxInputStart_DAD.TabIndex = 5;
            textBoxInputStart_DAD.Text = "-5";
            // 
            // labelStop_DAD
            // 
            labelStop_DAD.AutoSize = true;
            labelStop_DAD.Location = new Point(112, 23);
            labelStop_DAD.Name = "labelStop_DAD";
            labelStop_DAD.Size = new Size(75, 15);
            labelStop_DAD.TabIndex = 4;
            labelStop_DAD.Text = "Конец шага:";
            // 
            // textBoxInputStop_DAD
            // 
            textBoxInputStop_DAD.Location = new Point(112, 41);
            textBoxInputStop_DAD.Name = "textBoxInputStop_DAD";
            textBoxInputStop_DAD.Size = new Size(100, 23);
            textBoxInputStop_DAD.TabIndex = 6;
            textBoxInputStop_DAD.Text = "5";
            // 
            // labelStart_DAD
            // 
            labelStart_DAD.AutoSize = true;
            labelStart_DAD.Location = new Point(6, 23);
            labelStart_DAD.Name = "labelStart_DAD";
            labelStart_DAD.Size = new Size(72, 15);
            labelStart_DAD.TabIndex = 3;
            labelStart_DAD.Text = "Старт шага:";
            // 
            // groupBoxOutput_DAD
            // 
            groupBoxOutput_DAD.Controls.Add(textBoxOutput_DAD);
            groupBoxOutput_DAD.Location = new Point(12, 103);
            groupBoxOutput_DAD.Name = "groupBoxOutput_DAD";
            groupBoxOutput_DAD.Size = new Size(240, 346);
            groupBoxOutput_DAD.TabIndex = 2;
            groupBoxOutput_DAD.TabStop = false;
            groupBoxOutput_DAD.Text = "Вывод данных:";
            // 
            // textBoxOutput_DAD
            // 
            textBoxOutput_DAD.BackColor = SystemColors.Window;
            textBoxOutput_DAD.Location = new Point(6, 22);
            textBoxOutput_DAD.Multiline = true;
            textBoxOutput_DAD.Name = "textBoxOutput_DAD";
            textBoxOutput_DAD.ReadOnly = true;
            textBoxOutput_DAD.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_DAD.Size = new Size(228, 318);
            textBoxOutput_DAD.TabIndex = 7;
            // 
            // buttonStart_DAD
            // 
            buttonStart_DAD.BackColor = Color.Green;
            buttonStart_DAD.Cursor = Cursors.Hand;
            buttonStart_DAD.Location = new Point(686, 31);
            buttonStart_DAD.Name = "buttonStart_DAD";
            buttonStart_DAD.Size = new Size(77, 57);
            buttonStart_DAD.TabIndex = 3;
            buttonStart_DAD.Text = "Выполнить";
            buttonStart_DAD.UseVisualStyleBackColor = false;
            buttonStart_DAD.Click += buttonStart_DAD_Click;
            // 
            // buttonHelp_DAD
            // 
            buttonHelp_DAD.BackColor = SystemColors.MenuHighlight;
            buttonHelp_DAD.Cursor = Cursors.Hand;
            buttonHelp_DAD.Location = new Point(850, 31);
            buttonHelp_DAD.Name = "buttonHelp_DAD";
            buttonHelp_DAD.Size = new Size(75, 57);
            buttonHelp_DAD.TabIndex = 4;
            buttonHelp_DAD.Text = "Справка";
            buttonHelp_DAD.UseVisualStyleBackColor = false;
            buttonHelp_DAD.Click += buttonHelp_DAD_Click;
            // 
            // buttonDADe_DAD
            // 
            buttonDADe_DAD.BackColor = SystemColors.HotTrack;
            buttonDADe_DAD.Cursor = Cursors.Hand;
            buttonDADe_DAD.Location = new Point(769, 31);
            buttonDADe_DAD.Name = "buttonDADe_DAD";
            buttonDADe_DAD.Size = new Size(75, 57);
            buttonDADe_DAD.TabIndex = 5;
            buttonDADe_DAD.Text = "Сохранить";
            buttonDADe_DAD.UseVisualStyleBackColor = false;
            buttonDADe_DAD.Click += buttonDADe_DAD_Click;
            // 
            // chartDiagram_DAD
            // 
            chartArea1.Name = "ChartArea1";
            chartDiagram_DAD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiagram_DAD.Legends.Add(legend1);
            chartDiagram_DAD.Location = new Point(258, 103);
            chartDiagram_DAD.Name = "chartDiagram_DAD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiagram_DAD.Series.Add(series1);
            chartDiagram_DAD.Size = new Size(664, 346);
            chartDiagram_DAD.TabIndex = 6;
            chartDiagram_DAD.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Blue;
            title1.Name = "График функции";
            title1.Text = "График функции";
            chartDiagram_DAD.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 461);
            Controls.Add(chartDiagram_DAD);
            Controls.Add(buttonDADe_DAD);
            Controls.Add(buttonHelp_DAD);
            Controls.Add(buttonStart_DAD);
            Controls.Add(groupBoxOutput_DAD);
            Controls.Add(groupBoxInput_DAD);
            Controls.Add(groupBoxCondition_DAD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(950, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 26 | Demchenko A. D.";
            groupBoxCondition_DAD.ResumeLayout(false);
            groupBoxCondition_DAD.PerformLayout();
            groupBoxInput_DAD.ResumeLayout(false);
            groupBoxInput_DAD.PerformLayout();
            groupBoxOutput_DAD.ResumeLayout(false);
            groupBoxOutput_DAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiagram_DAD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAD;
        private GroupBox groupBoxInput_DAD;
        private GroupBox groupBoxOutput_DAD;
        private Label labelConditionText_DAD;
        private Label labelStart_DAD;
        private Label labelStop_DAD;
        private TextBox textBoxInputStart_DAD;
        private TextBox textBoxInputStop_DAD;
        private TextBox textBoxOutput_DAD;
        private Button buttonStart_DAD;
        private Button buttonHelp_DAD;
        private Button buttonDADe_DAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_DAD;
    }
}

    

