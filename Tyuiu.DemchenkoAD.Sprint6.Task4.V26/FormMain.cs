
using Tyuiu.DemchenkoAD.Sprint6.Task4.V26.Lib;
namespace Tyuiu.DemchenkoAD.Sprint6.Task4.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonStart_DAD_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_DAD.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_DAD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartDiagram_DAD.ChartAreas[0].AxisX.Title = "Îñü X";
                this.chartDiagram_DAD.ChartAreas[0].AxisY.Title = "Îñü Y";

                textBoxOutput_DAD.Text = "";

                chartDiagram_DAD.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartDiagram_DAD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutput_DAD.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демченко Александра Дмитриевна ИСПб-24-2 Øìåëåâ Àëåêñåé Âèòàëüåâè÷", "Ñîîáùåíèå");
        }

        private void buttonDADe_DAD_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V26.txt");
                File.WriteAllText(path, textBoxOutput_DAD.Text);

                DialogResult dialogResult = MessageBox.Show("Ôàéë " + path + " ñîõðàíåí óñïåøíî!\n Îòêðûòü åãî â áëîêíîòå?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}