using Backprop;

namespace OlamitBackpropagationActivity
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
            nn = new NeuralNet(4, 100, 1);
        }

        private void btnCreateBpnn_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, Convert.ToInt32(nudSetHidden.Text), 1);
            tbEpochCount.Text = "0";
        }

        private void btnTrainBpnn_Click(object sender, EventArgs e)
        {
            int setEpochs = Convert.ToInt32(nudSetEpoch.Text);
            int epochCtr = Convert.ToInt32(tbEpochCount.Text);

            for (int i = 0; i < setEpochs; i++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }

            epochCtr += setEpochs;
            tbEpochCount.Text = "" + epochCtr;
        }

        private void btnTestBpnn_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(nudInputA.Text));
            nn.setInputs(1, Convert.ToDouble(nudInputB.Text));
            nn.setInputs(2, Convert.ToDouble(nudInputC.Text));
            nn.setInputs(3, Convert.ToDouble(nudInputD.Text));
            nn.run();
            tbOutputRaw.Text = "" + nn.getOuputData(0);
            tbOutput.Text = "" + (nn.getOuputData(0) >= Convert.ToDouble(nudSetLimit.Text) ? 1 : 0); 
        }

        //private void saveWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    saveFileDialog1.ShowDialog(this);
        //}

        //private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    nn.saveWeights(saveFileDialog1.FileName);
        //}

        //private void loadWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.ShowDialog(this);
        //}

        //private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    nn.loadWeights(openFileDialog1.FileName);
        //}
    }
}
