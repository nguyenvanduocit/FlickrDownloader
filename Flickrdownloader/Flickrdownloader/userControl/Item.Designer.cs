namespace Flickrdownloader.userControl
{
    partial class Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pnDownloading = new System.Windows.Forms.Panel();
            this.status_Label = new System.Windows.Forms.Label();
            this.stop_Button = new System.Windows.Forms.Button();
            this.psbDownload = new System.Windows.Forms.ProgressBar();
            this.pause_Button = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnDownloading.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(0, 150);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(150, 37);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // pnDownloading
            // 
            this.pnDownloading.BackColor = System.Drawing.Color.Transparent;
            this.pnDownloading.Controls.Add(this.status_Label);
            this.pnDownloading.Controls.Add(this.stop_Button);
            this.pnDownloading.Controls.Add(this.psbDownload);
            this.pnDownloading.Controls.Add(this.pause_Button);
            this.pnDownloading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDownloading.Location = new System.Drawing.Point(0, 0);
            this.pnDownloading.Name = "pnDownloading";
            this.pnDownloading.Size = new System.Drawing.Size(150, 187);
            this.pnDownloading.TabIndex = 3;
            // 
            // status_Label
            // 
            this.status_Label.Location = new System.Drawing.Point(3, 35);
            this.status_Label.Name = "status_Label";
            this.status_Label.Size = new System.Drawing.Size(144, 45);
            this.status_Label.TabIndex = 6;
            this.status_Label.Text = "status";
            // 
            // stop_Button
            // 
            this.stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stop_Button.Location = new System.Drawing.Point(0, 113);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(150, 37);
            this.stop_Button.TabIndex = 2;
            this.stop_Button.Text = "Stop";
            this.stop_Button.UseVisualStyleBackColor = true;
            this.stop_Button.Click += new System.EventHandler(this.stop_Button_Click);
            // 
            // psbDownload
            // 
            this.psbDownload.Location = new System.Drawing.Point(0, 92);
            this.psbDownload.Name = "psbDownload";
            this.psbDownload.Size = new System.Drawing.Size(150, 20);
            this.psbDownload.TabIndex = 5;
            this.psbDownload.Click += new System.EventHandler(this.psbDownload_Click);
            // 
            // pause_Button
            // 
            this.pause_Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pause_Button.Location = new System.Drawing.Point(0, 150);
            this.pause_Button.Name = "pause_Button";
            this.pause_Button.Size = new System.Drawing.Size(150, 37);
            this.pause_Button.TabIndex = 3;
            this.pause_Button.Text = "Pause";
            this.pause_Button.UseVisualStyleBackColor = true;
            this.pause_Button.Click += new System.EventHandler(this.pause_Button_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(0, 150);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(150, 37);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Visible = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pnDownloading);
            this.Controls.Add(this.pictureBox);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(150, 187);
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnDownloading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel pnDownloading;
        private System.Windows.Forms.Button stop_Button;
        private System.Windows.Forms.Button pause_Button;
        private System.Windows.Forms.ProgressBar psbDownload;
        private System.Windows.Forms.Label status_Label;
        private System.Windows.Forms.Button btnOpenFile;
    }
}
