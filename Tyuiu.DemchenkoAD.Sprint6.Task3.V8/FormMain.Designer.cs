namespace Tyuiu.DemchenkoAD.Sprint6.Task3.V8
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
            groupBoxCondition_DAD = new GroupBox();
            dataGridViewMatrix_DAD = new DataGridView();
            textBoxData_DAD = new TextBox();
            groupBoxOutput_DAD = new GroupBox();
            textBox3 = new TextBox();
            textBoxResult_DAD = new TextBox();
            buttonHelp_DAD = new Button();
            buttonDone_DAD = new Button();
            groupBoxCondition_DAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_DAD).BeginInit();
            groupBoxOutput_DAD.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DAD
            // 
            groupBoxCondition_DAD.Controls.Add(dataGridViewMatrix_DAD);
            groupBoxCondition_DAD.Controls.Add(textBoxData_DAD);
            groupBoxCondition_DAD.Location = new Point(12, 12);
            groupBoxCondition_DAD.Name = "groupBoxCondition_DAD";
            groupBoxCondition_DAD.Size = new Size(1041, 526);
            groupBoxCondition_DAD.TabIndex = 0;
            groupBoxCondition_DAD.TabStop = false;
            groupBoxCondition_DAD.Text = "Условие";
            // 
            // dataGridViewMatrix_DAD
            // 
            dataGridViewMatrix_DAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_DAD.Location = new Point(359, 14);
            dataGridViewMatrix_DAD.Name = "dataGridViewMatrix_DAD";
            dataGridViewMatrix_DAD.RowHeadersWidth = 82;
            dataGridViewMatrix_DAD.Size = new Size(667, 266);
            dataGridViewMatrix_DAD.TabIndex = 1;
            // 
            // textBoxData_DAD
            // 
            textBoxData_DAD.BorderStyle = BorderStyle.None;
            textBoxData_DAD.Location = new Point(6, 38);
            textBoxData_DAD.Multiline = true;
            textBoxData_DAD.Name = "textBoxData_DAD";
            textBoxData_DAD.ReadOnly = true;
            textBoxData_DAD.Size = new Size(387, 398);
            textBoxData_DAD.TabIndex = 0;
            textBoxData_DAD.Text = "Дана матрица 5 на 5 \r\n-10  10  -7  19   6\r\n  15 -13 -19   9   1\r\n -20 -15  -6   8  -4\r\n  10  18  -5   9  -6\r\n  16 -10   4  15  16\r\nЗаменить четные значения в четвертой строке на 0.";
            // 
            // groupBoxOutput_DAD
            // 
            groupBoxOutput_DAD.Controls.Add(textBox3);
            groupBoxOutput_DAD.Controls.Add(textBoxResult_DAD);
            groupBoxOutput_DAD.Location = new Point(1059, 26);
            groupBoxOutput_DAD.Name = "groupBoxOutput_DAD";
            groupBoxOutput_DAD.Size = new Size(272, 200);
            groupBoxOutput_DAD.TabIndex = 1;
            groupBoxOutput_DAD.TabStop = false;
            groupBoxOutput_DAD.Text = "Вывод данных:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(23, 36);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(200, 32);
            textBox3.TabIndex = 1;
            textBox3.Text = "Результат:";
            // 
            // textBoxResult_DAD
            // 
            textBoxResult_DAD.BorderStyle = BorderStyle.None;
            textBoxResult_DAD.Location = new Point(6, 96);
            textBoxResult_DAD.Name = "textBoxResult_DAD";
            textBoxResult_DAD.Size = new Size(200, 32);
            textBoxResult_DAD.TabIndex = 0;
            // 
            // buttonHelp_DAD
            // 
            buttonHelp_DAD.Location = new Point(1065, 478);
            buttonHelp_DAD.Name = "buttonHelp_DAD";
            buttonHelp_DAD.Size = new Size(67, 60);
            buttonHelp_DAD.TabIndex = 2;
            buttonHelp_DAD.Text = "?";
            buttonHelp_DAD.UseVisualStyleBackColor = true;
            buttonHelp_DAD.Click += buttonHelp_DAD_Click;
            // 
            // buttonDone_DAD
            // 
            buttonDone_DAD.Location = new Point(1181, 478);
            buttonDone_DAD.Name = "buttonDone_DAD";
            buttonDone_DAD.Size = new Size(150, 60);
            buttonDone_DAD.TabIndex = 3;
            buttonDone_DAD.Text = "Выполнить";
            buttonDone_DAD.UseVisualStyleBackColor = true;
            buttonDone_DAD.Click += buttonDone_DAD_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 545);
            Controls.Add(buttonDone_DAD);
            Controls.Add(buttonHelp_DAD);
            Controls.Add(groupBoxOutput_DAD);
            Controls.Add(groupBoxCondition_DAD);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3| Вариант 8| Демченко А. Д.";
            Load += FormMain_Load;
            groupBoxCondition_DAD.ResumeLayout(false);
            groupBoxCondition_DAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_DAD).EndInit();
            groupBoxOutput_DAD.ResumeLayout(false);
            groupBoxOutput_DAD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAD;
        private GroupBox groupBoxOutput_DAD;
        private TextBox textBoxResult_DAD;
        private TextBox textBoxData_DAD;
        private TextBox textBox3;
        private DataGridView dataGridViewMatrix_DAD;
        private Button buttonHelp_DAD;
        private Button buttonDone_DAD;
    }

}

