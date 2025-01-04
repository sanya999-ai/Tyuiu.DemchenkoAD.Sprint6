namespace Tyuiu.DemchenkoAD.Sprint6.Task0.V5
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
            buttonHelp_DAD = new Button();
            buttonResult_DAD = new Button();
            groupBoxTask_DAD = new GroupBox();
            textBoxTask_DAD = new TextBox();
            pictureBoxFarmula_DAD = new PictureBox();
            groupBoxInput_DAD = new GroupBox();
            textBoxInputEnd_DAD = new TextBox();
            textBoxInputStart_DAD = new TextBox();
            groupBoxOutput_DAD = new GroupBox();
            textBoxOutputEnd_DAD = new TextBox();
            textBoxOutpunStart_DAD = new TextBox();
            groupBoxTask_DAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_DAD).BeginInit();
            groupBoxInput_DAD.SuspendLayout();
            groupBoxOutput_DAD.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_DAD
            // 
            buttonHelp_DAD.FlatStyle = FlatStyle.Flat;
            buttonHelp_DAD.Font = new Font("Segoe UI", 14F);
            buttonHelp_DAD.Location = new Point(820, 650);
            buttonHelp_DAD.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_DAD.Name = "buttonHelp_DAD";
            buttonHelp_DAD.Size = new Size(71, 83);
            buttonHelp_DAD.TabIndex = 0;
            buttonHelp_DAD.Text = "?";
            buttonHelp_DAD.UseVisualStyleBackColor = true;
            buttonHelp_DAD.Click += buttonHelp_DAD_Click;
            // 
            // buttonResult_DAD
            // 
            buttonResult_DAD.BackColor = SystemColors.Control;
            buttonResult_DAD.Location = new Point(900, 650);
            buttonResult_DAD.Margin = new Padding(4, 5, 4, 5);
            buttonResult_DAD.Name = "buttonResult_DAD";
            buttonResult_DAD.Size = new Size(226, 80);
            buttonResult_DAD.TabIndex = 1;
            buttonResult_DAD.Text = "Выполнить";
            buttonResult_DAD.UseVisualStyleBackColor = false;
            buttonResult_DAD.Click += buttonResult_DAD_Click;
            // 
            // groupBoxTask_DAD
            // 
            groupBoxTask_DAD.Controls.Add(textBoxTask_DAD);
            groupBoxTask_DAD.Controls.Add(pictureBoxFarmula_DAD);
            groupBoxTask_DAD.Location = new Point(17, 20);
            groupBoxTask_DAD.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_DAD.Name = "groupBoxTask_DAD";
            groupBoxTask_DAD.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_DAD.Size = new Size(1109, 438);
            groupBoxTask_DAD.TabIndex = 2;
            groupBoxTask_DAD.TabStop = false;
            groupBoxTask_DAD.Text = "Условие";
            // 
            // textBoxTask_DAD
            // 
            textBoxTask_DAD.BackColor = SystemColors.Control;
            textBoxTask_DAD.BorderStyle = BorderStyle.None;
            textBoxTask_DAD.Location = new Point(8, 34);
            textBoxTask_DAD.Margin = new Padding(4, 5, 4, 5);
            textBoxTask_DAD.Multiline = true;
            textBoxTask_DAD.Name = "textBoxTask_DAD";
            textBoxTask_DAD.ReadOnly = true;
            textBoxTask_DAD.Size = new Size(659, 392);
            textBoxTask_DAD.TabIndex = 1;
            textBoxTask_DAD.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFarmula_DAD
            // 
            pictureBoxFarmula_DAD.BackColor = SystemColors.Window;
            pictureBoxFarmula_DAD.Location = new Point(676, 37);
            pictureBoxFarmula_DAD.Margin = new Padding(4, 5, 4, 5);
            pictureBoxFarmula_DAD.Name = "pictureBoxFarmula_DAD";
            pictureBoxFarmula_DAD.Size = new Size(424, 65);
            pictureBoxFarmula_DAD.TabIndex = 0;
            pictureBoxFarmula_DAD.TabStop = false;
            // 
            // groupBoxInput_DAD
            // 
            groupBoxInput_DAD.Controls.Add(textBoxInputEnd_DAD);
            groupBoxInput_DAD.Controls.Add(textBoxInputStart_DAD);
            groupBoxInput_DAD.Location = new Point(17, 468);
            groupBoxInput_DAD.Margin = new Padding(4, 5, 4, 5);
            groupBoxInput_DAD.Name = "groupBoxInput_DAD";
            groupBoxInput_DAD.Padding = new Padding(4, 5, 4, 5);
            groupBoxInput_DAD.Size = new Size(797, 158);
            groupBoxInput_DAD.TabIndex = 3;
            groupBoxInput_DAD.TabStop = false;
            groupBoxInput_DAD.Text = "Ввод данных:";
            // 
            // textBoxInputEnd_DAD
            // 
            textBoxInputEnd_DAD.Font = new Font("Segoe UI", 16F);
            textBoxInputEnd_DAD.Location = new Point(9, 85);
            textBoxInputEnd_DAD.Margin = new Padding(4, 5, 4, 5);
            textBoxInputEnd_DAD.Name = "textBoxInputEnd_DAD";
            textBoxInputEnd_DAD.Size = new Size(778, 50);
            textBoxInputEnd_DAD.TabIndex = 1;
            textBoxInputEnd_DAD.KeyPress += textBoxInputEnd_DAD_KeyPress;
            // 
            // textBoxInputStart_DAD
            // 
            textBoxInputStart_DAD.BackColor = SystemColors.Control;
            textBoxInputStart_DAD.BorderStyle = BorderStyle.None;
            textBoxInputStart_DAD.Location = new Point(9, 48);
            textBoxInputStart_DAD.Margin = new Padding(4, 5, 4, 5);
            textBoxInputStart_DAD.Name = "textBoxInputStart_DAD";
            textBoxInputStart_DAD.ReadOnly = true;
            textBoxInputStart_DAD.Size = new Size(143, 24);
            textBoxInputStart_DAD.TabIndex = 0;
            textBoxInputStart_DAD.Text = "Переменная X:";
            // 
            // groupBoxOutput_DAD
            // 
            groupBoxOutput_DAD.Controls.Add(textBoxOutputEnd_DAD);
            groupBoxOutput_DAD.Controls.Add(textBoxOutpunStart_DAD);
            groupBoxOutput_DAD.Location = new Point(823, 468);
            groupBoxOutput_DAD.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutput_DAD.Name = "groupBoxOutput_DAD";
            groupBoxOutput_DAD.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutput_DAD.Size = new Size(303, 158);
            groupBoxOutput_DAD.TabIndex = 4;
            groupBoxOutput_DAD.TabStop = false;
            groupBoxOutput_DAD.Text = "Вывод данных:";
            // 
            // textBoxOutputEnd_DAD
            // 
            textBoxOutputEnd_DAD.Font = new Font("Segoe UI", 16F);
            textBoxOutputEnd_DAD.Location = new Point(9, 85);
            textBoxOutputEnd_DAD.Margin = new Padding(4, 5, 4, 5);
            textBoxOutputEnd_DAD.Name = "textBoxOutputEnd_DAD";
            textBoxOutputEnd_DAD.ReadOnly = true;
            textBoxOutputEnd_DAD.Size = new Size(258, 50);
            textBoxOutputEnd_DAD.TabIndex = 1;
            // 
            // textBoxOutpunStart_DAD
            // 
            textBoxOutpunStart_DAD.BackColor = SystemColors.Control;
            textBoxOutpunStart_DAD.BorderStyle = BorderStyle.None;
            textBoxOutpunStart_DAD.Location = new Point(9, 48);
            textBoxOutpunStart_DAD.Margin = new Padding(4, 5, 4, 5);
            textBoxOutpunStart_DAD.Multiline = true;
            textBoxOutpunStart_DAD.Name = "textBoxOutpunStart_DAD";
            textBoxOutpunStart_DAD.ReadOnly = true;
            textBoxOutpunStart_DAD.Size = new Size(143, 27);
            textBoxOutpunStart_DAD.TabIndex = 0;
            textBoxOutpunStart_DAD.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(groupBoxOutput_DAD);
            Controls.Add(groupBoxInput_DAD);
            Controls.Add(groupBoxTask_DAD);
            Controls.Add(buttonResult_DAD);
            Controls.Add(buttonHelp_DAD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 5 | Демченко Александра";
            groupBoxTask_DAD.ResumeLayout(false);
            groupBoxTask_DAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_DAD).EndInit();
            groupBoxInput_DAD.ResumeLayout(false);
            groupBoxInput_DAD.PerformLayout();
            groupBoxOutput_DAD.ResumeLayout(false);
            groupBoxOutput_DAD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_DAD;
        private Button buttonResult_DAD;
        private GroupBox groupBoxTask_DAD;
        private TextBox textBoxTask_DAD;
        private PictureBox pictureBoxFarmula_DAD;
        private GroupBox groupBoxInput_DAD;
        private TextBox textBoxInputEnd_DAD;
        private TextBox textBoxInputStart_DAD;
        private GroupBox groupBoxOutput_DAD;
        private TextBox textBoxOutputEnd_DAD;
        private TextBox textBoxOutpunStart_DAD;
    }
}

    

