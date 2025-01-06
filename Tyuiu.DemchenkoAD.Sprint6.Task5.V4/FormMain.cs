using Tyuiu.DemchenkoAD.Sprint6.Task5.V4.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\12\source\repos\Tyuiu.DemchenkoAD.Sprint6\Tyuiu.DemchenkoAD.Sprint6.Task5.V4\bin\Debug\InPutDataFileTask5V4.txt";
        private void buttonDone_DAD_Click(object sender, EventArgs e)
        {
            dataGridViewNums_DAD.ColumnCount = 2;
            dataGridViewNums_DAD.Columns[0].Width = 40;
            dataGridViewNums_DAD.Columns[1].Width = 50;

            this.chartResult_DAD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_DAD.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_DAD.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_DAD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_DAD.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonFile_DAD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonReference_DAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демченко А. Д. ИСПб-24-1 ", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
        
    

