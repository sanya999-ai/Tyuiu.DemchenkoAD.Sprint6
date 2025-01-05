namespace Tyuiu.DemchenkoAD.Sprint6.Task6.V19
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            groupBox3 = new GroupBox();
            textBoxOutput = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            buttonHelp = new Button();
            buttonExecute = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(20, 158);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(1564, 137);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(5, 30);
            textBox2.Margin = new Padding(5, 6, 5, 6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(1554, 101);
            textBox2.TabIndex = 0;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // groupBoxInput
            // 
            groupBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Location = new Point(20, 306);
            groupBoxInput.Margin = new Padding(5, 6, 5, 6);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(5, 6, 5, 6);
            groupBoxInput.Size = new Size(753, 721);
            groupBoxInput.TabIndex = 23;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.AppWorkspace;
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(5, 30);
            textBoxInput.Margin = new Padding(5, 6, 5, 6);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.Size = new Size(743, 685);
            textBoxInput.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxOutput);
            groupBox3.Location = new Point(795, 306);
            groupBox3.Margin = new Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 6, 5, 6);
            groupBox3.Size = new Size(789, 721);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "ВВыввод:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.BackColor = SystemColors.AppWorkspace;
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(5, 30);
            textBoxOutput.Margin = new Padding(5, 6, 5, 6);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(779, 685);
            textBoxOutput.TabIndex = 2;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(1468, 23);
            buttonHelp.Margin = new Padding(5, 6, 5, 6);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(117, 115);
            buttonHelp.TabIndex = 26;
            buttonHelp.Text = "Инфо";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonExecute
            // 
            buttonExecute.Enabled = false;
            buttonExecute.Location = new Point(147, 23);
            buttonExecute.Margin = new Padding(5, 6, 5, 6);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(154, 115);
            buttonExecute.TabIndex = 25;
            buttonExecute.Text = "Преобразовать";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 23);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(117, 115);
            button1.TabIndex = 24;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 1050);
            Controls.Add(buttonHelp);
            Controls.Add(buttonExecute);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBox1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 19 | Демченко Александра | ИСПб - 24 - 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
    }
}
    

