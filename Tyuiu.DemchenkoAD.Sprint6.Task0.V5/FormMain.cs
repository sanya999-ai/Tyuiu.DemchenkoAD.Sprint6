using Tyuiu.DemchenkoAD.Sprint6.Task0.V5.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_DAD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputEnd_DAD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputEnd_DAD.Text)));
            }
            catch
            {
                MessageBox.Show("-", "-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInputEnd_DAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) e.Handled = true;
        }
        private void buttonHelp_DAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-", "-");
        }

    }

}

