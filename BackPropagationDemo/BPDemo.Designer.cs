namespace BackPropagationDemo
{
    partial class BPDemo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BPDemo));
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bOpen = new System.Windows.Forms.ToolStripButton();
            this.bSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bBuild = new System.Windows.Forms.ToolStripButton();
            this.bTrain = new System.Windows.Forms.ToolStripButton();
            this.bStopTraining = new System.Windows.Forms.ToolStripButton();
            this.bCompute = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tcData = new System.Windows.Forms.TabControl();
            this.tpNetwork = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlpha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHidden = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpTrain = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbError = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMomentum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpTrainMonitor = new System.Windows.Forms.TabPage();
            this.pbErrors = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lIterations = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.pbSet = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lDecil = new System.Windows.Forms.Label();
            this.sfDlg = new System.Windows.Forms.SaveFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tbND = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcData.SuspendLayout();
            this.tpNetwork.SuspendLayout();
            this.tpTrain.SuspendLayout();
            this.tpTrainMonitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrors)).BeginInit();
            this.panel3.SuspendLayout();
            this.tpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofDlg
            // 
            this.ofDlg.Filter = "CSV Files (*.csv)|*.csv|NEU Files (*.neu)|*.neu|All Files (*.*)|*.*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 25);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOpen,
            this.bSave,
            this.toolStripSeparator1,
            this.bBuild,
            this.bTrain,
            this.bStopTraining,
            this.bCompute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bOpen
            // 
            this.bOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOpen.Image = ((System.Drawing.Image)(resources.GetObject("bOpen.Image")));
            this.bOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(23, 22);
            this.bOpen.ToolTipText = "Open File";
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bSave
            // 
            this.bSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(23, 22);
            this.bSave.ToolTipText = "Save Network";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bBuild
            // 
            this.bBuild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bBuild.Image = ((System.Drawing.Image)(resources.GetObject("bBuild.Image")));
            this.bBuild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bBuild.Name = "bBuild";
            this.bBuild.Size = new System.Drawing.Size(23, 22);
            this.bBuild.ToolTipText = "Build Network";
            this.bBuild.Click += new System.EventHandler(this.bBuild_Click);
            // 
            // bTrain
            // 
            this.bTrain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bTrain.Image = ((System.Drawing.Image)(resources.GetObject("bTrain.Image")));
            this.bTrain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bTrain.Name = "bTrain";
            this.bTrain.Size = new System.Drawing.Size(23, 22);
            this.bTrain.ToolTipText = "Train Network";
            this.bTrain.Click += new System.EventHandler(this.bTrain_Click);
            // 
            // bStopTraining
            // 
            this.bStopTraining.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bStopTraining.Enabled = false;
            this.bStopTraining.Image = ((System.Drawing.Image)(resources.GetObject("bStopTraining.Image")));
            this.bStopTraining.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bStopTraining.Name = "bStopTraining";
            this.bStopTraining.Size = new System.Drawing.Size(23, 22);
            this.bStopTraining.ToolTipText = "Stop Training";
            this.bStopTraining.Click += new System.EventHandler(this.bStopTraining_Click);
            // 
            // bCompute
            // 
            this.bCompute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bCompute.Image = ((System.Drawing.Image)(resources.GetObject("bCompute.Image")));
            this.bCompute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCompute.Name = "bCompute";
            this.bCompute.Size = new System.Drawing.Size(23, 22);
            this.bCompute.ToolTipText = "Compute Data";
            this.bCompute.Click += new System.EventHandler(this.bCompute_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tcData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 436);
            this.panel2.TabIndex = 1;
            // 
            // tcData
            // 
            this.tcData.Controls.Add(this.tpNetwork);
            this.tcData.Controls.Add(this.tpTrain);
            this.tcData.Controls.Add(this.tpTrainMonitor);
            this.tcData.Controls.Add(this.tpResults);
            this.tcData.Controls.Add(this.tabPage1);
            this.tcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcData.Location = new System.Drawing.Point(0, 0);
            this.tcData.Name = "tcData";
            this.tcData.SelectedIndex = 0;
            this.tcData.Size = new System.Drawing.Size(684, 436);
            this.tcData.TabIndex = 0;
            // 
            // tpNetwork
            // 
            this.tpNetwork.Controls.Add(this.label1);
            this.tpNetwork.Controls.Add(this.tbInput);
            this.tpNetwork.Controls.Add(this.label2);
            this.tpNetwork.Controls.Add(this.tbAlpha);
            this.tpNetwork.Controls.Add(this.label6);
            this.tpNetwork.Controls.Add(this.tbHidden);
            this.tpNetwork.Controls.Add(this.label5);
            this.tpNetwork.Controls.Add(this.label3);
            this.tpNetwork.Controls.Add(this.tbOutput);
            this.tpNetwork.Controls.Add(this.label4);
            this.tpNetwork.Location = new System.Drawing.Point(4, 22);
            this.tpNetwork.Name = "tpNetwork";
            this.tpNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tpNetwork.Size = new System.Drawing.Size(676, 410);
            this.tpNetwork.TabIndex = 0;
            this.tpNetwork.Text = "Network";
            this.tpNetwork.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Neurons";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(102, 15);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(42, 20);
            this.tbInput.TabIndex = 13;
            this.tbInput.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input Layer";
            // 
            // tbAlpha
            // 
            this.tbAlpha.Location = new System.Drawing.Point(102, 114);
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(95, 20);
            this.tbAlpha.TabIndex = 9;
            this.tbAlpha.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alpha";
            // 
            // tbHidden
            // 
            this.tbHidden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHidden.Location = new System.Drawing.Point(102, 46);
            this.tbHidden.Name = "tbHidden";
            this.tbHidden.Size = new System.Drawing.Size(548, 20);
            this.tbHidden.TabIndex = 7;
            this.tbHidden.Text = "10,5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hidden Layers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Neurons";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(102, 78);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(42, 20);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output Layer";
            // 
            // tpTrain
            // 
            this.tpTrain.Controls.Add(this.label13);
            this.tpTrain.Controls.Add(this.tbND);
            this.tpTrain.Controls.Add(this.label14);
            this.tpTrain.Controls.Add(this.label12);
            this.tpTrain.Controls.Add(this.tbPD);
            this.tpTrain.Controls.Add(this.label11);
            this.tpTrain.Controls.Add(this.tbError);
            this.tpTrain.Controls.Add(this.label10);
            this.tpTrain.Controls.Add(this.tbMomentum);
            this.tpTrain.Controls.Add(this.label9);
            this.tpTrain.Controls.Add(this.tbLR);
            this.tpTrain.Controls.Add(this.label8);
            this.tpTrain.Controls.Add(this.tbIterations);
            this.tpTrain.Controls.Add(this.label7);
            this.tpTrain.Location = new System.Drawing.Point(4, 22);
            this.tpTrain.Name = "tpTrain";
            this.tpTrain.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrain.Size = new System.Drawing.Size(676, 410);
            this.tpTrain.TabIndex = 1;
            this.tpTrain.Text = "Training";
            this.tpTrain.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "percent of data for traininig";
            // 
            // tbPD
            // 
            this.tbPD.Location = new System.Drawing.Point(89, 150);
            this.tbPD.Name = "tbPD";
            this.tbPD.Size = new System.Drawing.Size(32, 20);
            this.tbPD.TabIndex = 15;
            this.tbPD.Text = "60";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Use";
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(89, 116);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(53, 20);
            this.tbError.TabIndex = 13;
            this.tbError.Text = "0.001";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Max. Error";
            // 
            // tbMomentum
            // 
            this.tbMomentum.Location = new System.Drawing.Point(89, 82);
            this.tbMomentum.Name = "tbMomentum";
            this.tbMomentum.Size = new System.Drawing.Size(100, 20);
            this.tbMomentum.TabIndex = 5;
            this.tbMomentum.Text = "0.2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Momentum";
            // 
            // tbLR
            // 
            this.tbLR.Location = new System.Drawing.Point(89, 49);
            this.tbLR.Name = "tbLR";
            this.tbLR.Size = new System.Drawing.Size(100, 20);
            this.tbLR.TabIndex = 3;
            this.tbLR.Text = "0.01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Learing rate";
            // 
            // tbIterations
            // 
            this.tbIterations.Location = new System.Drawing.Point(89, 16);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(100, 20);
            this.tbIterations.TabIndex = 1;
            this.tbIterations.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Iterations";
            // 
            // tpTrainMonitor
            // 
            this.tpTrainMonitor.Controls.Add(this.pbErrors);
            this.tpTrainMonitor.Controls.Add(this.panel3);
            this.tpTrainMonitor.Location = new System.Drawing.Point(4, 22);
            this.tpTrainMonitor.Name = "tpTrainMonitor";
            this.tpTrainMonitor.Size = new System.Drawing.Size(676, 410);
            this.tpTrainMonitor.TabIndex = 2;
            this.tpTrainMonitor.Text = "Training Monitor";
            this.tpTrainMonitor.UseVisualStyleBackColor = true;
            // 
            // pbErrors
            // 
            this.pbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbErrors.Location = new System.Drawing.Point(0, 44);
            this.pbErrors.Name = "pbErrors";
            this.pbErrors.Size = new System.Drawing.Size(676, 366);
            this.pbErrors.TabIndex = 2;
            this.pbErrors.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lIterations);
            this.panel3.Controls.Add(this.pbProgress);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 44);
            this.panel3.TabIndex = 1;
            // 
            // lIterations
            // 
            this.lIterations.AutoSize = true;
            this.lIterations.Location = new System.Drawing.Point(304, 18);
            this.lIterations.Name = "lIterations";
            this.lIterations.Size = new System.Drawing.Size(0, 13);
            this.lIterations.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(19, 9);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(278, 23);
            this.pbProgress.TabIndex = 0;
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.pbSet);
            this.tpResults.Controls.Add(this.panel4);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Size = new System.Drawing.Size(676, 410);
            this.tpResults.TabIndex = 3;
            this.tpResults.Text = "Results";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // pbSet
            // 
            this.pbSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSet.Location = new System.Drawing.Point(0, 52);
            this.pbSet.Name = "pbSet";
            this.pbSet.Size = new System.Drawing.Size(676, 358);
            this.pbSet.TabIndex = 1;
            this.pbSet.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lDecil);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 52);
            this.panel4.TabIndex = 0;
            // 
            // lDecil
            // 
            this.lDecil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDecil.AutoEllipsis = true;
            this.lDecil.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDecil.Location = new System.Drawing.Point(9, 4);
            this.lDecil.Name = "lDecil";
            this.lDecil.Size = new System.Drawing.Size(659, 45);
            this.lDecil.TabIndex = 0;
            // 
            // sfDlg
            // 
            this.sfDlg.Filter = "NEU Files (*.neu)|*.neu";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 410);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Calcular";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "number of data for traininig";
            // 
            // tbND
            // 
            this.tbND.Location = new System.Drawing.Point(89, 181);
            this.tbND.Name = "tbND";
            this.tbND.Size = new System.Drawing.Size(32, 20);
            this.tbND.TabIndex = 18;
            this.tbND.Text = "60";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Use";
            // 
            // BPDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BPDemo";
            this.Text = "Back Propagation Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tcData.ResumeLayout(false);
            this.tpNetwork.ResumeLayout(false);
            this.tpNetwork.PerformLayout();
            this.tpTrain.ResumeLayout(false);
            this.tpTrain.PerformLayout();
            this.tpTrainMonitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbErrors)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofDlg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tcData;
        private System.Windows.Forms.TabPage tpNetwork;
        private System.Windows.Forms.TabPage tpTrain;
        private System.Windows.Forms.ToolStripButton bOpen;
        private System.Windows.Forms.ToolStripButton bSave;
        private System.Windows.Forms.SaveFileDialog sfDlg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bTrain;
        private System.Windows.Forms.ToolStripButton bCompute;
        private System.Windows.Forms.ToolStripButton bBuild;
        private System.Windows.Forms.TextBox tbHidden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAlpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMomentum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpTrainMonitor;
        private System.Windows.Forms.PictureBox pbErrors;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.ToolStripButton bStopTraining;
        private System.Windows.Forms.Label lIterations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tpResults;
        private System.Windows.Forms.TextBox tbPD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbSet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lDecil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbND;
        private System.Windows.Forms.Label label14;
    }
}

