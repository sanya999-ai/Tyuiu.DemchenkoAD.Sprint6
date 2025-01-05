using Tyuiu.DemchenkoAD.Sprint6.Task2.V5.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_DAD_Click(object sender, EventArgs e)
        {
            int startStep = Convert.ToInt32(textBoxStartStep_DAD.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_DAD.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            valueArray = ds.GetMassFunction(startStep, stopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewFunction_DAD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                startStep++;
            }
        }

        private void dataGridViewFunction_DAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
        
    

