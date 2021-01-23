using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    class BackPropagationMLP
    {
        float[][] x;// neuron values 
        float[][][] w;// weights
        float[][] e;// epsilon; partial derivative of error with respect to net value.
        float[][][] deltaW;
        float[][][] prevDeltaW;
        float[][][] soFarTheBestW;
        bool FirstUpdate;
        float soFarTheBestRMSE;
        int successedCount = 0;
        Point[][] pts;
        bool addMinimalValue = false;

        int[] n;// numbers of neuron on layers 
        int inputDimension;// dimension of input vector 

        public int inputNumber;// number of instances on the data set
        public int numberOfTrainningVectors;// number of instances that are serving as training data
        float[,] originalInputs; // original instances of input vectors (without normalization)
        float[,] inputs;// normalized input vectors 
        float[] inputMax;// upper bounds on all components of input vectors
        float[] inputMin;// lower bounds on all components of input vectors 
        int inputWidth;// dimension in width for a two-dimensional input vector

        int targetDimension;// dimension of target vector
        float[,] originalTargets;// original instances of target vectors (without normalization)
        float[,] targets;// normalized target vectors 
        float[] targetMax;// upper bounds on all components of target vectors
        float[] targetMin;// lower bounds on all components of target vectors

        int[] vectorIndices;// array of shuffled indices of data instances; the front portion is training vectors;
        int[] trainingVectorIndices;
        //the rear portion is testing vectors 
        float rootMeanSquareError = 0.0f;// root mean square of error for an epoch of data training
        int layerNumber;// number of neuron layer (including the input layer)

        Random randomizer = new Random();
        int epochLimit = 500;
        int epochCount = 0;
        float learningRateFront = 0.999f;// learning rate, specified by the user
        float learningRateRear = 0.9f;
        float eta;
        float initialEta = 0.699f;
        float momentumFactor = 0.1f;
        bool shuffleInEachEpochTrain = true;
        float trainingRatio = 0.8f;
        bool useMomentum = true;
        public BackPropagationMLP(){}
        [Description("Stopping condition for the upper limit of epoch.")] 
        public int EpochLimit { get => epochLimit; set => epochLimit = value; } 
        [Description("Learning factor reducing rate within 300 epoches.")]/// <summary>  The factor of reducing the eta epoch by epoch. That is /// eta <-- LearningRate  * eta </summary>
        public float LearningRateFront{ get { return learningRateFront; } set { learningRateFront = value; } }
        [Description("Learning factor reducing rate over 300 epoches.")]/// <summary>  The factor of reducing the eta epoch by epoch. That is /// eta <-- LearningRate  * eta </summary>
        public float LearningRateRear { get { return learningRateRear; } set { learningRateRear = value; } }
        [Description("Initial learning factor.")]/// <summary>Initialize  variable of the eta (can be regarded as step size). </summary> 
        public float InitialEta{ set { initialEta = value; } get { return initialEta; }}
        [Description("Factor for momentum value.")]
        public float MomentumFactor { get => momentumFactor; set => momentumFactor = value; }
        [Description("Flag for shuffling the training data in each new epoch.")]
        public bool ShuffleInEachEpochTrain { get => shuffleInEachEpochTrain; set => shuffleInEachEpochTrain = value; }
        [Description("The portion of the data set are used for training. ")]
        public float TrainingRatio { get => trainingRatio; set => trainingRatio = value; }
        [Description("Whether activate momentum terms.")]
        public bool UseMomentum { get => useMomentum; set => useMomentum = value; }
        [Browsable(false)]
        /// <summary> Current root mean square after an epoch training. </summary> 
        public float RootMeanSquareError { get { return rootMeanSquareError; } }
        [Browsable(false)]
        public int EpochCount { get => epochCount; set => epochCount = value; }
        [Browsable(false)] 
        public int TargetDimension { get => targetDimension; set => targetDimension = value; }
        [Browsable(false)]
        public float SoFarTheBestRMSE { get => soFarTheBestRMSE; set => soFarTheBestRMSE = value; }
        [Browsable(false)]
        public int SuccessedCount { get => successedCount; set => successedCount = value; }
        [Description("Add minimal Value for backward computing.")]
        public bool AddMinimalValue { get => addMinimalValue; set => addMinimalValue = value; }

        /// <summary> 
        ///  Read in the data set from the given file stream. Configure the portions of training ///  and testing data subsets. Original data are stored, bounds on each component of  ///  input vector and target vector are founds, and normalized data set is prepared. /// </summary> 
        /// <param name="sr">file stream</param> 
        /// <param name="trainingRatio">portion of trainning data</param> 
        public void ReadInDataSet(StreamReader sr, float trainingRatio)
        {
            char[] separators = new char[] { ',', ' ' };
            string s = sr.ReadLine();
            string[] items = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            inputNumber = Convert.ToInt32(items[0]);// number of instances on the data set
            inputDimension = Convert.ToInt32(items[1]);
            targetDimension = Convert.ToInt32(items[2]);
            inputWidth = Convert.ToInt32(items[3]);
            originalInputs = new float[inputNumber, inputDimension];
            originalTargets = new float[inputNumber, targetDimension];
            inputs = new float[inputNumber, inputDimension];
            targets = new float[inputNumber, targetDimension];
            inputMax = new float[inputDimension];
            inputMin = new float[inputDimension];
            targetMax = new float[targetDimension];
            targetMin = new float[targetDimension];
            this.trainingRatio = trainingRatio;
            numberOfTrainningVectors = (int)Math.Round(trainingRatio * inputNumber);
            for (int j = 0; j < inputDimension; j++)
            {
                inputMax[j] = float.MinValue;
                inputMin[j] = float.MaxValue;
            }
            for (int j = 0; j < targetDimension; j++)
            {
                targetMax[j] = float.MinValue;
                targetMin[j] = float.MaxValue;
            }

            for (int i = 0; i<inputNumber; i++)
            {
                items = sr.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < inputDimension; j++)
                {
                    originalInputs[i, j] = float.Parse(items[j]);
                    if (originalInputs[i, j] > inputMax[j]) inputMax[j] = originalInputs[i, j];
                    if (originalInputs[i, j] < inputMin[j]) inputMin[j] = originalInputs[i, j];
                }
                for (int j = 0; j < targetDimension; j++)
                {
                    originalTargets[i, j] = float.Parse(items[j+ inputDimension]);
                    if (originalTargets[i, j] > targetMax[j]) targetMax[j] = originalTargets[i, j];
                    if (originalTargets[i, j] < targetMin[j]) targetMin[j] = originalTargets[i, j];
                }
            }
            for (int i = 0; i<inputNumber; i++)
            {
                for (int j = 0; j < inputDimension; j++)
                {
                    if ((inputMax[j] - inputMin[j]) > 0)
                        inputs[i, j] = (originalInputs[i, j] - inputMin[j]) / (inputMax[j] - inputMin[j]);
                    else
                        inputs[i, j] = inputMax[j];
                }
                for (int j = 0; j < targetDimension; j++)
                {
                    if (targetMax[j] - targetMin[j] > 0)
                        targets[i, j] = (originalTargets[i, j] - targetMin[j]) / (targetMax[j] - targetMin[j]);
                    else
                        targets[i, j] = targetMax[j];
                }
            }
            x = null;
            w = null;
            e = null;
            n = null;
            deltaW = null;
            prevDeltaW = null;
            soFarTheBestW  = null;
            learningRateFront = 0.999f;// learning rate, specified by the user
            learningRateRear = 0.9f;
            initialEta = 0.699f;
            momentumFactor = 0.1f;
            shuffleInEachEpochTrain = true;
            trainingRatio = 0.8f;
            useMomentum = true;
            epochLimit = 500;
            addMinimalValue = false;

            sr.Close();
        }
        /// <summary> 
        ///  Configure the topology of the NN with the user specified numbers of hidden  
        ///  neuorns and layers. 
        /// </summary> 
        /// <param name="hiddenNeuronNumbers">list of numbers of neurons of hidden layers</param>
        public void ConfigureNeuralNetwork(int[] hiddenNeuronNumbers)
        {
            layerNumber = hiddenNeuronNumbers.Length + 2;
            n = new int[layerNumber]; // numbers of neuron on layers 
            n[0] = inputDimension + 1;
            n[layerNumber - 1] = targetDimension + 1;
            for(int i = 1; i < layerNumber - 1; i++)
            {
                n[i] = hiddenNeuronNumbers[i - 1] + 1;
            }
            n[layerNumber - 1] = targetDimension+1;
            pts = new Point[layerNumber][];
            for(int i = 0; i < pts.Length; i++)
            {
                pts[i] = new Point[n[i]];
            }
            ResetWeightsAndInitialCondition();
        }
        /// <summary> 
        /// Randomly shuffle the orders of the data in the data set. /// </summary> 
        private void RandomizeIndices(int[] vectorInd)
        {

            for (int c = vectorInd.Length - 1; c > 1; c--)//randomize 1~len-1 to indices
            {
                int pos = randomizer.Next(c + 1);
                int temp = vectorIndices[c];
                vectorInd[c] = vectorInd[pos];
                vectorInd[pos] = temp;
            }
        }
        /// <summary> 
        /// Randomly set values of weights between [-1,1] and randomly shuffle the orders of all 
        /// the datum in the data set. Reset value of initial eta and root mean square to 0.0. /// </summary> 
        public void ResetWeightsAndInitialCondition()
        {
            //set values of weights between [-1,1]
            w = new float[layerNumber][][];
            soFarTheBestW = new float[layerNumber][][];
            for (int l = 1; l < layerNumber; l++) // hiddenNeuronNumbers.Length + 2
            {
                w[l] = new float[n[l]][];
                soFarTheBestW[l] = new float[n[l]][];
                for (int k = 1; k < n[l]; k++)
                {
                    w[l][k] = new float[n[l - 1]];
                    soFarTheBestW[l][k] = new float[n[l - 1]];
                    for (int i = 0; i < n[l-1]; i++)
                    {
                        w[l][k][i] = (float)randomizer.NextDouble() * 2 - 1;//layer,to,from
                    }
                }
            }

            //randomly shuffle the orders of all the datum
            vectorIndices = new int[inputNumber];
            for (int i = 0; i < inputNumber; i++) vectorIndices[i] = i;// fill out all indices as 1~len-1
            RandomizeIndices(vectorIndices);
            //Reset value of initial eta and root mean square to 0.0
            eta = initialEta;
            rootMeanSquareError = 0.0f;
            FirstUpdate = true;
            epochCount = 0;
            soFarTheBestRMSE = float.MaxValue;
            trainingVectorIndices = new int[numberOfTrainningVectors];

            for (int i = 0; i < trainingVectorIndices.Length; i++) trainingVectorIndices[i] = vectorIndices[i];

        }
        /// <summary> 
        ///  Sequentially loop through each training datum of the training data whose indices are 
        ///  randomly shuffled in vectorIndices[] array, to perform on-line training of the NN. /// </summary> 
        public void TrainAnEpoch()
        {
            double v;
            float errorSquareSum = 0.0f;
            float sumEW = 0.0f;
            epochCount++;
            //int layerNumberMinusOne = layerNumber - 1;
            // forward computing for all neuro values.
            x = new float[layerNumber][];
            for (int j = 0; j < numberOfTrainningVectors; j++)
            {
                x[0] = new float[inputDimension+1];
                x[0][0] = 1;
                for (int k = 1; k < inputDimension + 1; k++)
                    x[0][k] = inputs[trainingVectorIndices[j], k - 1];
                for (int l = 1; l < layerNumber; l++)// hiddenNeuronNumbers.Length + 2
                {
                    x[l] = new float[n[l]];
                    x[l][0] = 1;
                    for (int k = 1; k < n[l]; k++)
                    {
                        v = 0;                       
                        for (int i = 0; i < n[l - 1]; i++)
                             v += w[l][k][i] * x[l - 1][i];                       
                        x[l][k] = (1f / (1f + (float)Math.Exp(-v)));
                    }  
                }
                for (int k = 1; k < targetDimension; k++)
                {
                    errorSquareSum += (targets[trainingVectorIndices[j],k-1] - x[layerNumber - 1][k])* (targets[trainingVectorIndices[j],k-1] - x[layerNumber - 1][k]);
                }
                /// /// compute the epsilon values for neurons on the output layer
                /// /// backward computing for the epsilon values 
                deltaW = new float[layerNumber][][];
                prevDeltaW = new float[layerNumber][][];
                e = new float[layerNumber][];
                for (int l = layerNumber-1; l > 0; l--)// hiddenNeuronNumbers.Length + 2
                {
                    deltaW[l] = new float[n[l]][];
                    prevDeltaW[l] = new float[n[l]][];
                    e[l] = new float[n[l]];
                    for (int k = 1; k < n[l]; k++)
                    {
                        if (l == layerNumber - 1)
                        {
                            if (addMinimalValue)
                                e[l][k] = (-2) * (targets[trainingVectorIndices[j], k - 1] - x[layerNumber - 1][k]) * (x[layerNumber - 1][k] * (1 - x[layerNumber - 1][k])*0.03f);
                            else
                                e[l][k] = (-2) * (targets[trainingVectorIndices[j], k-1] - x[layerNumber - 1][k]) * x[layerNumber - 1][k] * (1 - x[layerNumber - 1][k]);
                        }
                        else
                        {
                            sumEW = 0.0f;
                            for (int i = 1; i < n[l + 1]; i++)
                                sumEW += e[l + 1][i] * w[l + 1][i][k];
                            if (addMinimalValue)
                                e[l][k] = (x[l][k] * (1 - x[l][k])*0.03f) * sumEW;
                            else
                                e[l][k] = x[l][k] * (1 - x[l][k]) * sumEW;
                        }
                        /// update weights for all weights by using epsilon and neuron values.
                        deltaW[l][k] = new float[n[l - 1]];
                        prevDeltaW[l][k] = new float[n[l - 1]];
                        for (int i = 0; i < n[l-1]; i++)
                        {
                            if (useMomentum & !FirstUpdate)
                            {
                                deltaW[l][k][i] = -eta * e[l][k] * x[l - 1][i] + momentumFactor * prevDeltaW[l][k][i];
                                prevDeltaW[l][k][i] = deltaW[l][k][i];
                            }
                            else
                            {
                                deltaW[l][k][i] = -eta * e[l][k] * x[l - 1][i];
                                if (FirstUpdate)
                                {
                                    FirstUpdate = false;
                                }
                                prevDeltaW[l][k][i] = deltaW[l][k][i];
                            }
                            //if not Batch Update
                            w[l][k][i] += deltaW[l][k][i];
                        }
                    }
                }

            }
            /// … 
            /// update step size of the updating amount … 
            if(EpochCount<300)
                eta = eta * learningRateFront;
            else
                eta = eta * learningRateRear;
            if (shuffleInEachEpochTrain)//shuffle training data
            {
                RandomizeIndices(trainingVectorIndices);
            }
            rootMeanSquareError = (float)Math.Pow(errorSquareSum / (targetDimension*numberOfTrainningVectors), 0.5);
            if (rootMeanSquareError < soFarTheBestRMSE)
            {
                soFarTheBestRMSE = rootMeanSquareError;
                for (int l = 1; l < layerNumber; l++)
                {
                    for (int k = 1; k < n[l]; k++)
                    {
                        for (int i = 0; i < n[l - 1]; i++)
                        {
                            soFarTheBestW[l][k][i] = w[l][k][i];
                        }
                    }
                }
            }
        }
        /// <summary> 
        ///  Compute the output vector for an input vector. Both vectors are in the raw ///  format. The input vector is subject to scaling first before forward computing. ///  Output vector is then scaled back to raw format for recognition.  
        /// </summary> 
        /// <param name="input">input vector in raw format</param> 
        /// <returns>output vector in raw format</returns> 
        public float[] ComputeResults(int index)
        {
            float[] results = null;
            float v;
            results = new float[targetDimension];

            for (int k = 1; k < inputDimension + 1; k++)
                x[0][k] = inputs[vectorIndices[index], k - 1];
            for (int l = 1; l < layerNumber; l++)// hiddenNeuronNumbers.Length + 2
            {
                x[l] = new float[n[l]];
                x[l][0] = 1;
                for (int k = 1; k < n[l]; k++)
                {
                    v = 0;
                    for (int i = 0; i < n[l - 1]; i++)
                        v += w[l][k][i] * x[l - 1][i];
                    x[l][k] = (float)(1 / (1 + Math.Exp(-v)));
                }
            }

            results = x[layerNumber - 1];
            return results;
        }
        /// <summary> 
        /// If the data set is a classification data set, test the data to generate confusing table. 
        /// The index of the largest component of the target vector is the targeted class id. 
        /// The index of the largest component of the computed output vector is the resulting class id. 
        /// If both the targeted class id and the resulting class id are the same, then the test  
        /// data is correctly classified. 
        /// </summary> 
        /// <param name="confusingTable">generated confusing table</param> 
        /// <returns>the ratio between the number of correctly classified testing data and the total number of testing data.</returns> 
        public float TestingClassification(out int[,] confusingTable, bool isBest)
        {
            confusingTable = new int[targetDimension+1, targetDimension+1];
            for(int i = 1; i < targetDimension + 1; i++)
            {
                for (int j = 1; j < targetDimension + 1; j++)
                {
                    confusingTable[i,j] = 0;
                }
            }
            
            if (isBest)
            {
                for (int l = 1; l < layerNumber; l++)
                {
                    for (int k = 1; k < n[l]; k++)
                    {
                        for (int i = 0; i < n[l - 1]; i++)
                        {
                            w[l][k][i] = soFarTheBestW[l][k][i];
                        }
                    }
                }
            }
            successedCount = 0;
            for (int index = numberOfTrainningVectors; index < inputNumber; index++)
            {
                ComputeResults(index);
                double MaxWeight = double.MinValue;
                int idx = -1;
                int targetIdx = -1;
                for (int k = 1; k < targetDimension+1; k++)
                {
                    if (x[layerNumber - 1][k] > MaxWeight)
                    {
                        MaxWeight = x[layerNumber - 1][k];
                        idx = k;
                    };
                    if (targets[vectorIndices[index], k -1] == 1) 
                        targetIdx = k;
                }
                if (targetIdx == idx)
                    successedCount++;
                else
                {
                    float e = targets[vectorIndices[index], 0];
                    float e1 = targets[vectorIndices[index], 1];
                    //float e2 = targets[vectorIndices[index], 2];
                }
                confusingTable[idx,targetIdx]++;
            }
            return (float)successedCount / (float)(inputNumber - numberOfTrainningVectors);
        }
        public void DrawMLP( Graphics g, Rectangle bound)
        {
            if (n == null) return;
            int dw = bound.Width / pts.Length;
            int woff = dw / 2;
            Rectangle rect = Rectangle.Empty;
            int halfUnit = bound.Height / 20;
            Font myFont = new Font("Arial", 8.0f);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            Pen myPen = new Pen(Color.Black, 1);
            Point p1;
            Point p2;
            Point p3;

            for (int l = 0; l < layerNumber; l++)
            {
                int dh = bound.Height / n[l];
                int hoff = dh / 2;
                for (int k = 0; k < n[l]; k++)
                {
                    pts[l][k].X = woff + l * dw;
                    pts[l][k].Y = hoff + k * dh;
                    if (l > 0)
                    {
                        if (l != layerNumber - 1 | k != 0)
                        {
                            p1 = new Point(pts[l][k].X, pts[l][k].Y);
                            for (int i = 0; i < n[l - 1]; i++)
                            {
                                p2 = new Point(pts[l - 1][i].X, pts[l - 1][i].Y);
                                p3 = new Point((3*pts[l - 1][i].X + 7*pts[l][k].X)/10, (3*pts[l - 1][i].Y + 7*pts[l][k].Y)/10);
                                if (l != 0 & k != 0)
                                {
                                    g.DrawLine(myPen, p1, p2);
                                    g.DrawString($"{ w[l][k][i].ToString("f2") }", myFont, Brushes.Black, p3, sf);
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < layerNumber; i++)
            {
                for (int c = 0; c < n[i]; c++)
                {
                    if (c > 0)
                    {
                        rect.Width = rect.Height = halfUnit + halfUnit;
                        rect.X = pts[i][c].X - halfUnit;
                        rect.Y = pts[i][c].Y - halfUnit;

                        g.FillEllipse(Brushes.MistyRose, rect);
                        g.DrawEllipse(Pens.Red, rect);
                        if (x== null)
                            g.DrawString("0.0", myFont, Brushes.Black, rect, sf);
                        else
                            g.DrawString($"{x[i][c].ToString("f2")}", myFont, Brushes.Black, rect, sf);
                    }
                    else
                    {
                        rect.Width = rect.Height = 8;
                        rect.X = pts[i][c].X;
                        rect.Y = pts[i][c].Y;

                        g.FillEllipse(Brushes.Red, rect);
                        g.DrawEllipse(Pens.Red, rect);
                        g.DrawString("X[0][0] = 1", myFont, Brushes.Black, pts[i][c].X, pts[i][c].Y, sf);
                    }
                }
            }


            //g.DrawString("0.00", myFont, Brushes.Black, bound, sf);
        }
    }
}
