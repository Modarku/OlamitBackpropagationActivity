namespace OlamitBackpropagationActivity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbOutputRaw = new TextBox();
            btnCreateBpnn = new Button();
            btnTrainBpnn = new Button();
            btnTestBpnn = new Button();
            lblEpoch = new Label();
            tbEpochCount = new TextBox();
            lblEpochCount = new Label();
            lblOutputRaw = new Label();
            lblInput = new Label();
            nudInputA = new NumericUpDown();
            nudInputB = new NumericUpDown();
            nudInputC = new NumericUpDown();
            nudInputD = new NumericUpDown();
            nudSetEpoch = new NumericUpDown();
            nudSetHidden = new NumericUpDown();
            lblHidden = new Label();
            tbOutput = new TextBox();
            lblOutput = new Label();
            nudSetLimit = new NumericUpDown();
            lblSetLimit = new Label();
            ((System.ComponentModel.ISupportInitialize)nudInputA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInputB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInputC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInputD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSetEpoch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSetHidden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSetLimit).BeginInit();
            SuspendLayout();
            // 
            // tbOutputRaw
            // 
            tbOutputRaw.BackColor = SystemColors.Info;
            tbOutputRaw.Font = new Font("Segoe UI", 32F);
            tbOutputRaw.Location = new Point(665, 77);
            tbOutputRaw.Name = "tbOutputRaw";
            tbOutputRaw.ReadOnly = true;
            tbOutputRaw.Size = new Size(413, 78);
            tbOutputRaw.TabIndex = 2;
            // 
            // btnCreateBpnn
            // 
            btnCreateBpnn.Font = new Font("Segoe UI", 20F);
            btnCreateBpnn.Location = new Point(48, 638);
            btnCreateBpnn.Name = "btnCreateBpnn";
            btnCreateBpnn.Size = new Size(232, 80);
            btnCreateBpnn.TabIndex = 3;
            btnCreateBpnn.Text = "Create BPNN";
            btnCreateBpnn.UseVisualStyleBackColor = true;
            btnCreateBpnn.Click += btnCreateBpnn_Click;
            // 
            // btnTrainBpnn
            // 
            btnTrainBpnn.Font = new Font("Segoe UI", 20F);
            btnTrainBpnn.Location = new Point(311, 638);
            btnTrainBpnn.Name = "btnTrainBpnn";
            btnTrainBpnn.Size = new Size(213, 80);
            btnTrainBpnn.TabIndex = 4;
            btnTrainBpnn.Text = "Train BPNN";
            btnTrainBpnn.UseVisualStyleBackColor = true;
            btnTrainBpnn.Click += btnTrainBpnn_Click;
            // 
            // btnTestBpnn
            // 
            btnTestBpnn.BackColor = SystemColors.HighlightText;
            btnTestBpnn.Font = new Font("Segoe UI", 20F);
            btnTestBpnn.Location = new Point(865, 435);
            btnTestBpnn.Name = "btnTestBpnn";
            btnTestBpnn.Size = new Size(212, 80);
            btnTestBpnn.TabIndex = 5;
            btnTestBpnn.Text = "Test BPNN";
            btnTestBpnn.UseVisualStyleBackColor = false;
            btnTestBpnn.Click += btnTestBpnn_Click;
            // 
            // lblEpoch
            // 
            lblEpoch.AutoSize = true;
            lblEpoch.Font = new Font("Segoe UI", 16F);
            lblEpoch.Location = new Point(311, 544);
            lblEpoch.Name = "lblEpoch";
            lblEpoch.Size = new Size(178, 37);
            lblEpoch.TabIndex = 9;
            lblEpoch.Text = "Set Epoch no.";
            // 
            // tbEpochCount
            // 
            tbEpochCount.BackColor = SystemColors.InactiveCaption;
            tbEpochCount.Font = new Font("Segoe UI", 16F);
            tbEpochCount.Location = new Point(865, 626);
            tbEpochCount.Name = "tbEpochCount";
            tbEpochCount.ReadOnly = true;
            tbEpochCount.Size = new Size(175, 43);
            tbEpochCount.TabIndex = 10;
            tbEpochCount.Text = "0";
            // 
            // lblEpochCount
            // 
            lblEpochCount.AutoSize = true;
            lblEpochCount.Font = new Font("Segoe UI", 16F);
            lblEpochCount.Location = new Point(834, 586);
            lblEpochCount.Name = "lblEpochCount";
            lblEpochCount.Size = new Size(232, 37);
            lblEpochCount.TabIndex = 11;
            lblEpochCount.Text = "Epochs Generated";
            // 
            // lblOutputRaw
            // 
            lblOutputRaw.AutoSize = true;
            lblOutputRaw.Font = new Font("Segoe UI", 16F);
            lblOutputRaw.Location = new Point(799, 37);
            lblOutputRaw.Name = "lblOutputRaw";
            lblOutputRaw.Size = new Size(158, 37);
            lblOutputRaw.TabIndex = 12;
            lblOutputRaw.Text = "Raw Output";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 16F);
            lblInput.Location = new Point(76, 37);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(79, 37);
            lblInput.TabIndex = 13;
            lblInput.Text = "Input";
            // 
            // nudInputA
            // 
            nudInputA.Font = new Font("Segoe UI", 32F);
            nudInputA.Location = new Point(46, 77);
            nudInputA.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInputA.Name = "nudInputA";
            nudInputA.Size = new Size(150, 78);
            nudInputA.TabIndex = 17;
            // 
            // nudInputB
            // 
            nudInputB.Font = new Font("Segoe UI", 32F);
            nudInputB.Location = new Point(46, 197);
            nudInputB.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInputB.Name = "nudInputB";
            nudInputB.Size = new Size(150, 78);
            nudInputB.TabIndex = 18;
            // 
            // nudInputC
            // 
            nudInputC.Font = new Font("Segoe UI", 32F);
            nudInputC.Location = new Point(46, 315);
            nudInputC.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInputC.Name = "nudInputC";
            nudInputC.Size = new Size(150, 78);
            nudInputC.TabIndex = 19;
            // 
            // nudInputD
            // 
            nudInputD.Font = new Font("Segoe UI", 32F);
            nudInputD.Location = new Point(46, 437);
            nudInputD.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInputD.Name = "nudInputD";
            nudInputD.Size = new Size(150, 78);
            nudInputD.TabIndex = 20;
            // 
            // nudSetEpoch
            // 
            nudSetEpoch.Font = new Font("Segoe UI", 16F);
            nudSetEpoch.Location = new Point(311, 584);
            nudSetEpoch.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSetEpoch.Name = "nudSetEpoch";
            nudSetEpoch.Size = new Size(150, 43);
            nudSetEpoch.TabIndex = 21;
            // 
            // nudSetHidden
            // 
            nudSetHidden.Font = new Font("Segoe UI", 16F);
            nudSetHidden.Location = new Point(48, 584);
            nudSetHidden.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSetHidden.Name = "nudSetHidden";
            nudSetHidden.Size = new Size(150, 43);
            nudSetHidden.TabIndex = 23;
            nudSetHidden.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblHidden
            // 
            lblHidden.AutoSize = true;
            lblHidden.Font = new Font("Segoe UI", 16F);
            lblHidden.Location = new Point(48, 544);
            lblHidden.Name = "lblHidden";
            lblHidden.Size = new Size(262, 37);
            lblHidden.TabIndex = 22;
            lblHidden.Text = "Set Hidden Layer no.";
            // 
            // tbOutput
            // 
            tbOutput.BackColor = SystemColors.Info;
            tbOutput.Font = new Font("Segoe UI", 32F);
            tbOutput.Location = new Point(865, 351);
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.Size = new Size(212, 78);
            tbOutput.TabIndex = 25;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 16F);
            lblOutput.Location = new Point(915, 311);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(101, 37);
            lblOutput.TabIndex = 26;
            lblOutput.Text = "Output";
            // 
            // nudSetLimit
            // 
            nudSetLimit.DecimalPlaces = 2;
            nudSetLimit.Font = new Font("Segoe UI", 16F);
            nudSetLimit.Location = new Point(886, 266);
            nudSetLimit.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSetLimit.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            nudSetLimit.Name = "nudSetLimit";
            nudSetLimit.Size = new Size(150, 43);
            nudSetLimit.TabIndex = 28;
            nudSetLimit.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // lblSetLimit
            // 
            lblSetLimit.AutoSize = true;
            lblSetLimit.Font = new Font("Segoe UI", 16F);
            lblSetLimit.Location = new Point(901, 226);
            lblSetLimit.Name = "lblSetLimit";
            lblSetLimit.Size = new Size(115, 37);
            lblSetLimit.TabIndex = 27;
            lblSetLimit.Text = "1's Limit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 737);
            Controls.Add(nudSetLimit);
            Controls.Add(lblSetLimit);
            Controls.Add(lblOutput);
            Controls.Add(tbOutput);
            Controls.Add(nudSetHidden);
            Controls.Add(lblHidden);
            Controls.Add(nudSetEpoch);
            Controls.Add(nudInputD);
            Controls.Add(nudInputC);
            Controls.Add(nudInputB);
            Controls.Add(nudInputA);
            Controls.Add(lblInput);
            Controls.Add(lblOutputRaw);
            Controls.Add(lblEpochCount);
            Controls.Add(tbEpochCount);
            Controls.Add(lblEpoch);
            Controls.Add(btnTestBpnn);
            Controls.Add(btnTrainBpnn);
            Controls.Add(btnCreateBpnn);
            Controls.Add(tbOutputRaw);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudInputA).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInputB).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInputC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInputD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSetEpoch).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSetHidden).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSetLimit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbOutputRaw;
        private Button btnCreateBpnn;
        private Button btnTrainBpnn;
        private Button btnTestBpnn;
        private Label lblEpoch;
        private TextBox tbEpochCount;
        private Label lblEpochCount;
        private Label lblOutputRaw;
        private Label lblInput;
        private NumericUpDown nudInputA;
        private NumericUpDown nudInputB;
        private NumericUpDown nudInputC;
        private NumericUpDown nudInputD;
        private NumericUpDown nudSetEpoch;
        private NumericUpDown nudSetHidden;
        private Label lblHidden;
        private TextBox tbOutput;
        private Label lblOutput;
        private NumericUpDown nudSetLimit;
        private Label lblSetLimit;
    }
}
