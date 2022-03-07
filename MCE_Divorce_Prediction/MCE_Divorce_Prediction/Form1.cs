using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using CsvHelper;
namespace MCE_Divorce_Prediction
{
    public partial class Form1 : Form
    {

        NeuralNet bp;
        CsvHelper csvHelper;
        public Form1()
        {
            InitializeComponent();
            csvHelper = new CsvHelper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void init_Nn(object sender, EventArgs e)
        {
            bp = new NeuralNet(10, 1, 1);
        }

        private void train_Nn(object sender, EventArgs e)
        {
            List<DivorceQuestionData> data = csvHelper.getRecords();

            int epoch = 1000;

            for(int i = 0; i < epoch; i ++)
            foreach(var d in data)
            {
                bp.setInputs(0, d.Q1);
                bp.setInputs(1, d.Q2);
                bp.setInputs(2, d.Q3);
                bp.setInputs(3, d.Q4);
                bp.setInputs(4, d.Q5);
                bp.setInputs(5, d.Q6);
                bp.setInputs(6, d.Q7);
                bp.setInputs(7, d.Q8);
                bp.setInputs(8, d.Q9);
                bp.setInputs(9, d.Q10);
                bp.setDesiredOutput(0, d.Divorce);
                bp.learn();
            }
       
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int Q1 = Convert.ToInt32(cmbxQ1.Text);
            int Q2 = Convert.ToInt32(cmbxQ2.Text);
            int Q3 = Convert.ToInt32(cmbxQ3.Text);
            int Q4 = Convert.ToInt32(cmbxQ4.Text);
            int Q5 = Convert.ToInt32(cmbxQ5.Text);
            int Q6 = Convert.ToInt32(cmbxQ6.Text);
            int Q7 = Convert.ToInt32(cmbxQ7.Text);
            int Q8 = Convert.ToInt32(cmbxQ8.Text);
            int Q9 = Convert.ToInt32(cmbxQ9.Text);
            int Q10 = Convert.ToInt32(cmbxQ10.Text);
            bp.setInputs(0, Q1);
            bp.setInputs(1, Q2);
            bp.setInputs(2, Q3);
            bp.setInputs(3, Q4);
            bp.setInputs(4, Q5);
            bp.setInputs(5, Q6);
            bp.setInputs(6, Q7);
            bp.setInputs(7, Q8);
            bp.setInputs(8, Q9);
            bp.setInputs(9, Q10);

            bp.run();

            txtbox_Result.Text = "" + bp.getOuputData(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.saveWeights(saveFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bp.loadWeights(openFileDialog1.FileName);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
