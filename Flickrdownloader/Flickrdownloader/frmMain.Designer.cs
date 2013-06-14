namespace Flickrdownloader
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpSearchimage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mbxPerpage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.cbbxAction = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.psbSearch = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxKeyword = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.tbxSaveFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bwSearch = new System.ComponentModel.AbortableBackgroundWorker();
            this.bwDownload = new System.ComponentModel.AbortableBackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpSearchimage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbxPerpage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(978, 68);
            this.pbxLogo.TabIndex = 12;
            this.pbxLogo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(978, 504);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 13;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpSearchimage);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(231, 502);
            this.tabControl2.TabIndex = 13;
            // 
            // tpSearchimage
            // 
            this.tpSearchimage.Controls.Add(this.groupBox2);
            this.tpSearchimage.Controls.Add(this.groupBox1);
            this.tpSearchimage.Location = new System.Drawing.Point(4, 22);
            this.tpSearchimage.Name = "tpSearchimage";
            this.tpSearchimage.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchimage.Size = new System.Drawing.Size(223, 476);
            this.tpSearchimage.TabIndex = 0;
            this.tpSearchimage.Text = "Search image";
            this.tpSearchimage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mbxPerpage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxInfo);
            this.groupBox2.Controls.Add(this.cbbxAction);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.psbSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxKeyword);
            this.groupBox2.Controls.Add(this.btnClean);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 321);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // mbxPerpage
            // 
            this.mbxPerpage.Location = new System.Drawing.Point(151, 42);
            this.mbxPerpage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.mbxPerpage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mbxPerpage.Name = "mbxPerpage";
            this.mbxPerpage.Size = new System.Drawing.Size(60, 20);
            this.mbxPerpage.TabIndex = 17;
            this.mbxPerpage.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Img/page";
            // 
            // tbxInfo
            // 
            this.tbxInfo.HideSelection = false;
            this.tbxInfo.Location = new System.Drawing.Point(5, 175);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.ReadOnly = true;
            this.tbxInfo.Size = new System.Drawing.Size(208, 139);
            this.tbxInfo.TabIndex = 15;
            // 
            // cbbxAction
            // 
            this.cbbxAction.FormattingEnabled = true;
            this.cbbxAction.Location = new System.Drawing.Point(4, 41);
            this.cbbxAction.Name = "cbbxAction";
            this.cbbxAction.Size = new System.Drawing.Size(141, 21);
            this.cbbxAction.TabIndex = 14;
            this.cbbxAction.SelectedIndexChanged += new System.EventHandler(this.cbbxAction_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Action";
            // 
            // psbSearch
            // 
            this.psbSearch.BackColor = System.Drawing.Color.Red;
            this.psbSearch.Enabled = false;
            this.psbSearch.Location = new System.Drawing.Point(1, 161);
            this.psbSearch.MarqueeAnimationSpeed = 50;
            this.psbSearch.Name = "psbSearch";
            this.psbSearch.Size = new System.Drawing.Size(216, 10);
            this.psbSearch.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Keyword";
            // 
            // tbxKeyword
            // 
            this.tbxKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKeyword.Location = new System.Drawing.Point(3, 89);
            this.tbxKeyword.Name = "tbxKeyword";
            this.tbxKeyword.Size = new System.Drawing.Size(211, 29);
            this.tbxKeyword.TabIndex = 0;
            this.tbxKeyword.Text = "love";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(70, 124);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(69, 29);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(145, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Get it";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.tbxSaveFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChooseFolder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOpenFolder.Location = new System.Drawing.Point(168, 18);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(46, 23);
            this.btnOpenFolder.TabIndex = 9;
            this.btnOpenFolder.Text = "Open";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // tbxSaveFolder
            // 
            this.tbxSaveFolder.Location = new System.Drawing.Point(3, 42);
            this.tbxSaveFolder.Name = "tbxSaveFolder";
            this.tbxSaveFolder.Size = new System.Drawing.Size(211, 20);
            this.tbxSaveFolder.TabIndex = 6;
            this.tbxSaveFolder.Leave += new System.EventHandler(this.tbxSaveFolder_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Storage folder :";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnChooseFolder.Location = new System.Drawing.Point(141, 18);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnChooseFolder.TabIndex = 8;
            this.btnChooseFolder.Text = "...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(223, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(733, 502);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // bwSearch
            // 
            this.bwSearch.Tag = null;
            this.bwSearch.WorkerReportsProgress = true;
            this.bwSearch.WorkerSupportsCancellation = true;
            this.bwSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSearch_DoWork);
            this.bwSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSearch_RunWorkerCompleted);
            // 
            // bwDownload
            // 
            this.bwDownload.Tag = null;
            this.bwDownload.WorkerReportsProgress = true;
            this.bwDownload.WorkerSupportsCancellation = true;
            this.bwDownload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDownload_DoWork);
            this.bwDownload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDownload_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 572);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pbxLogo);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flickr download";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpSearchimage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mbxPerpage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.AbortableBackgroundWorker bwSearch;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox tbxSaveFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpSearchimage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKeyword;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar psbSearch;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbxAction;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown mbxPerpage;
        private System.ComponentModel.AbortableBackgroundWorker bwDownload;
    }
}

