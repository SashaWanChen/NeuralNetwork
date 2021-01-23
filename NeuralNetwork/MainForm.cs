using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork
{
    public partial class MainForm : Form
    {
        BackPropagationMLP MLP;
        string fileName;
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            MLP = new BackPropagationMLP();
            numNChange.Enabled = false;
            btnReset.Enabled = false;
            btnTrainAnEpoch.Enabled = false;
            btnTrainEnd.Enabled = false;
            btnClassificationTest.Enabled = false;
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            object[] pars = { ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true };
            MethodInfo setStyleMethodOfPanel = typeof(Panel).GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);
            setStyleMethodOfPanel.Invoke(splitContainer2.Panel2, pars);
        }
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            fileName = dlgOpen.FileName;
            txtTitle.Text = $"Data Set: {dlgOpen.SafeFileName}";
            StreamReader sr = new StreamReader(fileName);
            MLP.ReadInDataSet(sr, (float)numTrainingRate.Value);
            sr.Close();
            
            btnReset.Enabled = true;
            numLayers.Enabled = true;
            numNeurals.Enabled = true;
            numNChange.Enabled = true;
            if (MLP.inputNumber >=1000) numTrainingRate.Value = 0.95M;
            else numTrainingRate.Value = 0.8M;
            if (dlgOpen.SafeFileName == "ThreeChainedDataSets.cal")
            {
                MLP.InitialEta = 0.3f;
            }
            else if(dlgOpen.SafeFileName == "chinese.cal")
            { 
                //MessageBox.Show("Dataset is to small, is not enougth to classify.");
                numTrainingRate.Value = 1;
            }
            else MLP.InitialEta = 0.699f;
            if (dgv1.Rows.Count > 0)
            {
                dgv1.Rows.Clear();
                dgv2.Rows.Clear();
            }
            ppg.SelectedObject = MLP;
        }
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {
            if(MLP != null)
                MLP.DrawMLP(e.Graphics, e.ClipRectangle);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            theChart.Series[0].Points.Clear();
            int[] hiddenNeurals = new int[(int)numLayers.Value];
            for(int i =0; i < numNeurals.Items.Count; i++)
            {
                hiddenNeurals[i] = Convert.ToInt32( numNeurals.Items[i] );
            }
            MLP.ConfigureNeuralNetwork(hiddenNeurals);
            splitContainer2.Panel2.Refresh();
           
            btnTrainAnEpoch.Enabled = true;
            btnTrainEnd.Enabled = true;
            if (dgv1.Rows.Count > 0)
            {
                dgv1.Rows.Clear();
                dgv2.Rows.Clear();
            }
            numLayers.Enabled = false;
            numNeurals.Enabled = false;
            numNChange.Enabled = false;
        }
        private void btnTrainAnEpoch_Click(object sender, EventArgs e)
        {
            MLP.TrainAnEpoch();
            txtRMSE.Text = $"RMSE = {MLP.RootMeanSquareError}";
            txtRMSE2.Text = $"RMSE = {MLP.SoFarTheBestRMSE}";
            showSeries();
            theChart.Update();
            if(cbxAnimation.Checked)
                splitContainer2.Panel2.Refresh();
            btnClassificationTest.Enabled = true;
        }
        private void showSeries()
        {
            double y = MLP.RootMeanSquareError;
            double x = MLP.EpochCount;
            if (x <= 1)
            {
                theChart.Series[0].Points.AddXY(0, MLP.RootMeanSquareError);
            }
            else
            {
                theChart.Series[0].Points.AddXY(x, y);
            }
        }
        private void docNN_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            MLP.DrawMLP(e.Graphics, e.PageBounds);
        }
        private void numNeurals_SelectedIndexChanged(object sender, EventArgs e)
        {
            numNChange.Enabled = true;
            if(numNeurals.SelectedItem!=null)
                numNChange.Value = Convert.ToInt32(numNeurals.SelectedItem);
        }
        private void numNChange_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numNeurals.SelectedItem) != numNChange.Value)
            {
                numNeurals.Items.Insert(numNeurals.SelectedIndex, numNChange.Value);
                numNeurals.SelectedIndex--;
                numNeurals.Items.RemoveAt(numNeurals.SelectedIndex+1);
            }
        }
        private void numLayers_ValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < numLayers.Value; i++)
            {
                if (numNeurals.Items.Count < numLayers.Value)
                    numNeurals.Items.Add(4);
                if (numNeurals.Items.Count > numLayers.Value)
                    numNeurals.Items.RemoveAt(numNeurals.Items.Count-1);
            }
        }
        private void btnTrainEnd_Click(object sender, EventArgs e)
        {
            cbxAnimation.Checked = false;
            for( int i = 0; i < MLP.EpochLimit; i++)
            {
                btnTrainAnEpoch.PerformClick();
            }
            btnClassificationTest.PerformClick();
            cbxAnimation.Checked = true;
            splitContainer2.Panel2.Refresh();
        }
        private void btnClassificationTest_Click(object sender, EventArgs e)
        {
           int[,] confusingTable;
            if (dlgOpen.SafeFileName == "chinese.cal")
            {
                MLP.numberOfTrainningVectors =  6;
            }
            txtCorrect.Text = $"Correctness = { MLP.TestingClassification(out confusingTable, false).ToString("f4")}({MLP.SuccessedCount}/{MLP.inputNumber - MLP.numberOfTrainningVectors})";
            for (int c = 1; c < MLP.TargetDimension+1; c++)
            {
                string headTxt = $"{c}";
                dgv1.Columns.Add(headTxt, headTxt);
            }
            for (int r = 1; r < MLP.TargetDimension + 1; r++)
            {
                dgv1.Rows.Add();
                for (int c = 1; c < MLP.TargetDimension + 1; c++)
                {
                    dgv1.Rows[r-1].Cells[c-1].Value = confusingTable[r, c];
                }
            }
            txtCorrect2.Text = $"Correctness = { MLP.TestingClassification(out confusingTable, true).ToString("f4")}({MLP.SuccessedCount}/{MLP.inputNumber - MLP.numberOfTrainningVectors})";
            for (int c = 1; c < MLP.TargetDimension + 1; c++)
            {
                string headTxt = $"{c}";
                dgv2.Columns.Add(headTxt, headTxt);
            }
            for (int r = 1; r < MLP.TargetDimension + 1; r++)
            {
                dgv2.Rows.Add();
                for (int c = 1; c < MLP.TargetDimension + 1; c++)
                {
                    dgv2.Rows[r - 1].Cells[c - 1].Value = confusingTable[r, c];
                }

            }
        }
        private void numTrainingRate_ValueChanged(object sender, EventArgs e)
        {
            MLP.TrainingRatio = (float)numTrainingRate.Value;
            MLP.numberOfTrainningVectors = (int)Math.Round(MLP.TrainingRatio * MLP.inputNumber);
            ppg.Refresh();
        }
    }
}
