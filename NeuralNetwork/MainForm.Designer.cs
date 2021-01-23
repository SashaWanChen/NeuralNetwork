namespace NeuralNetwork
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numTrainingRate = new System.Windows.Forms.NumericUpDown();
            this.txtTrainingRate = new System.Windows.Forms.Label();
            this.numNChange = new System.Windows.Forms.NumericUpDown();
            this.numNeurals = new System.Windows.Forms.ListBox();
            this.numLayers = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtNumNSelect = new System.Windows.Forms.Label();
            this.txtNumLayers = new System.Windows.Forms.Label();
            this.txtNumNs = new System.Windows.Forms.Label();
            this.cbxAnimation = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTrainAnEpoch = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtLast = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txtRMSE = new System.Windows.Forms.Label();
            this.txtCorrect = new System.Windows.Forms.Label();
            this.txtRMSE2 = new System.Windows.Forms.Label();
            this.txtCorrect2 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.Label();
            this.ppg = new System.Windows.Forms.PropertyGrid();
            this.btnClassificationTest = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTrainEnd = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.theChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.docNN = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrainingRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightYellow;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1333, 39);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(96, 36);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitContainer1.Panel1.Controls.Add(this.numTrainingRate);
            this.splitContainer1.Panel1.Controls.Add(this.txtTrainingRate);
            this.splitContainer1.Panel1.Controls.Add(this.numNChange);
            this.splitContainer1.Panel1.Controls.Add(this.numNeurals);
            this.splitContainer1.Panel1.Controls.Add(this.numLayers);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumNSelect);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumLayers);
            this.splitContainer1.Panel1.Controls.Add(this.txtNumNs);
            this.splitContainer1.Panel1.Controls.Add(this.cbxAnimation);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1333, 822);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.TabIndex = 17;
            // 
            // numTrainingRate
            // 
            this.numTrainingRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.numTrainingRate.DecimalPlaces = 2;
            this.numTrainingRate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numTrainingRate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numTrainingRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTrainingRate.Location = new System.Drawing.Point(143, 44);
            this.numTrainingRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrainingRate.Name = "numTrainingRate";
            this.numTrainingRate.Size = new System.Drawing.Size(102, 30);
            this.numTrainingRate.TabIndex = 57;
            this.numTrainingRate.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numTrainingRate.ValueChanged += new System.EventHandler(this.numTrainingRate_ValueChanged);
            // 
            // txtTrainingRate
            // 
            this.txtTrainingRate.AutoSize = true;
            this.txtTrainingRate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTrainingRate.Location = new System.Drawing.Point(12, 46);
            this.txtTrainingRate.Name = "txtTrainingRate";
            this.txtTrainingRate.Size = new System.Drawing.Size(114, 22);
            this.txtTrainingRate.TabIndex = 55;
            this.txtTrainingRate.Text = "Training Rate";
            // 
            // numNChange
            // 
            this.numNChange.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numNChange.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numNChange.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numNChange.Location = new System.Drawing.Point(84, 183);
            this.numNChange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNChange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNChange.MinimumSize = new System.Drawing.Size(1, 0);
            this.numNChange.Name = "numNChange";
            this.numNChange.Size = new System.Drawing.Size(120, 30);
            this.numNChange.TabIndex = 54;
            this.numNChange.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNChange.ValueChanged += new System.EventHandler(this.numNChange_ValueChanged);
            // 
            // numNeurals
            // 
            this.numNeurals.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numNeurals.FormattingEnabled = true;
            this.numNeurals.ItemHeight = 22;
            this.numNeurals.Items.AddRange(new object[] {
            "4"});
            this.numNeurals.Location = new System.Drawing.Point(16, 105);
            this.numNeurals.Name = "numNeurals";
            this.numNeurals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numNeurals.Size = new System.Drawing.Size(47, 136);
            this.numNeurals.TabIndex = 53;
            this.numNeurals.SelectedIndexChanged += new System.EventHandler(this.numNeurals_SelectedIndexChanged);
            // 
            // numLayers
            // 
            this.numLayers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numLayers.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numLayers.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numLayers.Location = new System.Drawing.Point(312, 114);
            this.numLayers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayers.MinimumSize = new System.Drawing.Size(1, 0);
            this.numLayers.Name = "numLayers";
            this.numLayers.Size = new System.Drawing.Size(120, 30);
            this.numLayers.TabIndex = 52;
            this.numLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLayers.ValueChanged += new System.EventHandler(this.numLayers_ValueChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitle.Location = new System.Drawing.Point(12, 11);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(81, 22);
            this.txtTitle.TabIndex = 51;
            this.txtTitle.Text = "Data Set:";
            // 
            // txtNumNSelect
            // 
            this.txtNumNSelect.AutoSize = true;
            this.txtNumNSelect.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNumNSelect.Location = new System.Drawing.Point(80, 147);
            this.txtNumNSelect.Name = "txtNumNSelect";
            this.txtNumNSelect.Size = new System.Drawing.Size(326, 22);
            this.txtNumNSelect.TabIndex = 50;
            this.txtNumNSelect.Text = "Number of Neurals in the Selected layer";
            // 
            // txtNumLayers
            // 
            this.txtNumLayers.AutoSize = true;
            this.txtNumLayers.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNumLayers.Location = new System.Drawing.Point(80, 116);
            this.txtNumLayers.Name = "txtNumLayers";
            this.txtNumLayers.Size = new System.Drawing.Size(216, 22);
            this.txtNumLayers.TabIndex = 49;
            this.txtNumLayers.Text = "Number of Hidden Layers";
            // 
            // txtNumNs
            // 
            this.txtNumNs.AutoSize = true;
            this.txtNumNs.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNumNs.Location = new System.Drawing.Point(12, 80);
            this.txtNumNs.Name = "txtNumNs";
            this.txtNumNs.Size = new System.Drawing.Size(332, 22);
            this.txtNumNs.TabIndex = 48;
            this.txtNumNs.Text = "Number of Neurals In Each Hidden Layer";
            // 
            // cbxAnimation
            // 
            this.cbxAnimation.AutoSize = true;
            this.cbxAnimation.Checked = true;
            this.cbxAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAnimation.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxAnimation.Location = new System.Drawing.Point(84, 215);
            this.cbxAnimation.Name = "cbxAnimation";
            this.cbxAnimation.Size = new System.Drawing.Size(173, 26);
            this.cbxAnimation.TabIndex = 47;
            this.cbxAnimation.Text = "Real-time Update";
            this.cbxAnimation.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 264);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.btnTrainAnEpoch);
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Controls.Add(this.txtMatrix);
            this.tabPage1.Controls.Add(this.ppg);
            this.tabPage1.Controls.Add(this.btnClassificationTest);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnTrainEnd);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generalized Delta";
            // 
            // btnTrainAnEpoch
            // 
            this.btnTrainAnEpoch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainAnEpoch.BackColor = System.Drawing.Color.LightCyan;
            this.btnTrainAnEpoch.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnTrainAnEpoch.FlatAppearance.BorderSize = 2;
            this.btnTrainAnEpoch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainAnEpoch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTrainAnEpoch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainAnEpoch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrainAnEpoch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrainAnEpoch.Location = new System.Drawing.Point(119, 16);
            this.btnTrainAnEpoch.Name = "btnTrainAnEpoch";
            this.btnTrainAnEpoch.Size = new System.Drawing.Size(170, 38);
            this.btnTrainAnEpoch.TabIndex = 54;
            this.btnTrainAnEpoch.Text = "Train An Epoch";
            this.btnTrainAnEpoch.UseVisualStyleBackColor = false;
            this.btnTrainAnEpoch.Click += new System.EventHandler(this.btnTrainAnEpoch_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(0, 122);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtLast);
            this.splitContainer3.Panel1.Controls.Add(this.dgv1);
            this.splitContainer3.Panel1.Controls.Add(this.txtRMSE);
            this.splitContainer3.Panel1.Controls.Add(this.txtCorrect);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtRMSE2);
            this.splitContainer3.Panel2.Controls.Add(this.txtCorrect2);
            this.splitContainer3.Panel2.Controls.Add(this.dgv2);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(460, 194);
            this.splitContainer3.SplitterDistance = 225;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.AutoSize = true;
            this.txtLast.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLast.ForeColor = System.Drawing.Color.Black;
            this.txtLast.Location = new System.Drawing.Point(13, 0);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(83, 19);
            this.txtLast.TabIndex = 55;
            this.txtLast.Text = "Last Epoch";
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(3, 22);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.Size = new System.Drawing.Size(217, 113);
            this.dgv1.TabIndex = 52;
            // 
            // txtRMSE
            // 
            this.txtRMSE.AutoSize = true;
            this.txtRMSE.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRMSE.ForeColor = System.Drawing.Color.Red;
            this.txtRMSE.Location = new System.Drawing.Point(16, 138);
            this.txtRMSE.Name = "txtRMSE";
            this.txtRMSE.Size = new System.Drawing.Size(73, 22);
            this.txtRMSE.TabIndex = 50;
            this.txtRMSE.Text = "RMSE =";
            // 
            // txtCorrect
            // 
            this.txtCorrect.AutoSize = true;
            this.txtCorrect.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCorrect.ForeColor = System.Drawing.Color.Red;
            this.txtCorrect.Location = new System.Drawing.Point(16, 167);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.Size = new System.Drawing.Size(125, 22);
            this.txtCorrect.TabIndex = 51;
            this.txtCorrect.Text = "Correctness = ";
            // 
            // txtRMSE2
            // 
            this.txtRMSE2.AutoSize = true;
            this.txtRMSE2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRMSE2.ForeColor = System.Drawing.Color.Red;
            this.txtRMSE2.Location = new System.Drawing.Point(3, 138);
            this.txtRMSE2.Name = "txtRMSE2";
            this.txtRMSE2.Size = new System.Drawing.Size(73, 22);
            this.txtRMSE2.TabIndex = 56;
            this.txtRMSE2.Text = "RMSE =";
            // 
            // txtCorrect2
            // 
            this.txtCorrect2.AutoSize = true;
            this.txtCorrect2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCorrect2.ForeColor = System.Drawing.Color.Red;
            this.txtCorrect2.Location = new System.Drawing.Point(3, 167);
            this.txtCorrect2.Name = "txtCorrect2";
            this.txtCorrect2.Size = new System.Drawing.Size(125, 22);
            this.txtCorrect2.TabIndex = 57;
            this.txtCorrect2.Text = "Correctness = ";
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(7, 22);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 27;
            this.dgv2.Size = new System.Drawing.Size(214, 113);
            this.dgv2.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Best Epoch";
            // 
            // txtMatrix
            // 
            this.txtMatrix.AutoSize = true;
            this.txtMatrix.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMatrix.ForeColor = System.Drawing.Color.Black;
            this.txtMatrix.Location = new System.Drawing.Point(8, 97);
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.Size = new System.Drawing.Size(154, 22);
            this.txtMatrix.TabIndex = 53;
            this.txtMatrix.Text = "Confusing Matrix";
            // 
            // ppg
            // 
            this.ppg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppg.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ppg.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ppg.Location = new System.Drawing.Point(3, 314);
            this.ppg.Name = "ppg";
            this.ppg.Size = new System.Drawing.Size(457, 204);
            this.ppg.TabIndex = 44;
            // 
            // btnClassificationTest
            // 
            this.btnClassificationTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClassificationTest.BackColor = System.Drawing.Color.LightCyan;
            this.btnClassificationTest.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnClassificationTest.FlatAppearance.BorderSize = 2;
            this.btnClassificationTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClassificationTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClassificationTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassificationTest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClassificationTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClassificationTest.Location = new System.Drawing.Point(104, 60);
            this.btnClassificationTest.Name = "btnClassificationTest";
            this.btnClassificationTest.Size = new System.Drawing.Size(201, 38);
            this.btnClassificationTest.TabIndex = 43;
            this.btnClassificationTest.Text = "Classification Test";
            this.btnClassificationTest.UseVisualStyleBackColor = false;
            this.btnClassificationTest.Click += new System.EventHandler(this.btnClassificationTest_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCyan;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Location = new System.Drawing.Point(12, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 38);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTrainEnd
            // 
            this.btnTrainEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainEnd.BackColor = System.Drawing.Color.LightCyan;
            this.btnTrainEnd.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnTrainEnd.FlatAppearance.BorderSize = 2;
            this.btnTrainEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTrainEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTrainEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrainEnd.Location = new System.Drawing.Point(310, 16);
            this.btnTrainEnd.Name = "btnTrainEnd";
            this.btnTrainEnd.Size = new System.Drawing.Size(150, 38);
            this.btnTrainEnd.TabIndex = 46;
            this.btnTrainEnd.Text = "Train To End";
            this.btnTrainEnd.UseVisualStyleBackColor = false;
            this.btnTrainEnd.Click += new System.EventHandler(this.btnTrainEnd_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.theChart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(862, 822);
            this.splitContainer2.SplitterDistance = 377;
            this.splitContainer2.TabIndex = 0;
            // 
            // theChart
            // 
            chartArea1.AxisX.Title = "Epoch";
            chartArea1.AxisY.Title = "RMSE";
            chartArea1.Name = "ChartArea1";
            this.theChart.ChartAreas.Add(chartArea1);
            this.theChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.theChart.Legends.Add(legend1);
            this.theChart.Location = new System.Drawing.Point(0, 0);
            this.theChart.Name = "theChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Epoch RMS of Errors";
            series1.Name = "Series1";
            this.theChart.Series.Add(series1);
            this.theChart.Size = new System.Drawing.Size(862, 377);
            this.theChart.TabIndex = 0;
            this.theChart.Text = "chart1";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "cal";
            this.dlgOpen.FileName = "*.cal";
            // 
            // docNN
            // 
            this.docNN.DocumentName = "docNN";
            this.docNN.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.docNN_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 861);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Neural Network";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTrainingRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtNumNSelect;
        private System.Windows.Forms.Label txtNumLayers;
        private System.Windows.Forms.Label txtNumNs;
        private System.Windows.Forms.CheckBox cbxAnimation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid ppg;
        private System.Windows.Forms.Button btnClassificationTest;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTrainEnd;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart theChart;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.NumericUpDown numLayers;
        private System.Windows.Forms.ListBox numNeurals;
        private System.Windows.Forms.NumericUpDown numNChange;
        private System.Drawing.Printing.PrintDocument docNN;
        private System.Windows.Forms.Label txtRMSE;
        private System.Windows.Forms.Label txtCorrect;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label txtTrainingRate;
        private System.Windows.Forms.NumericUpDown numTrainingRate;
        private System.Windows.Forms.Label txtMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLast;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label txtCorrect2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label txtRMSE2;
        private System.Windows.Forms.Button btnTrainAnEpoch;
    }
}

