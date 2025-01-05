﻿using Tyuiu.DemchenkoAD.Sprint6.Task1.V8.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonINF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демченко Александра Дмитриевна, ИСПб-24-1");
        }

        private void buttonResult_Click(object sender, EventArgs e)


        {
            DataService ds = new DataService();
            try
            {
                int start = Convert.ToInt32(TextBoxStart.Text);
                int stop = Convert.ToInt32(TextBoxStop.Text);
                string str;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("+    X      +    F(x)  +" + Environment.NewLine);
                textBoxResult.AppendText("+-----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {

                    str = String.Format("|{0,7:d}   ||{1, 7:f2}   |", start, value[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBoxResult.AppendText("+-----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxStop_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

