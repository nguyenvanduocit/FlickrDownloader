using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using Flickrdownloader.component;
using Flickrdownloader.Properties;
using System.Diagnostics;
using FlickrREST.Model;

namespace Flickrdownloader.userControl
{
    public partial class Item : UserControl
    {
        private FileDownloader downloader;
        private bool processing;
        private string downloadedPath;
        private string thumbURL;
        private string downloadURL;
        public Item(string thumbURL, string downloadURL)
        {
            InitializeComponent();
            this.thumbURL = thumbURL;
            this.downloadURL = downloadURL;
            this.pictureBox.ImageLocation = thumbURL;
        }
        public bool IsDownloading
        {
            get { return downloader.IsBusy; }
        }
        public String ImageLocation
        {
            set { this.pictureBox.ImageLocation = value; }
            get { return this.pictureBox.ImageLocation; }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (downloader.IsBusy)
            {
                downloader.Abort();
            }
            else
            {
                pnDownloading.Visible = true;
                btnDownload.Visible = false;
                downloader.RunWorkerAsync();
            }
        }

        public void download()
        {
            if (downloader.IsBusy)
            {
                downloader.Abort();
            }
            else
            {
                pnDownloading.Visible = true;
                btnDownload.Visible = false;
                downloader.RunWorkerAsync();
            }
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            btnDownload.PerformClick();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            downloadedPath = Path.Combine(Settings.Default.downloadPath, Path.GetFileName(downloadURL));
            downloader = new FileDownloader(downloadURL, Settings.Default.downloadPath, Path.GetFileName(downloadURL));
            downloader.ProgressChanged += downloader_ProgressChanged;
            downloader.RunWorkerCompleted += downloader_RunWorkerCompleted;
            pnDownloading.Visible = false;
        }
        private void downloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pnDownloading.Visible = false;
                btnOpenFile.Visible = true;
            }
        }
        private void downloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (processing) return;
            if (InvokeRequired) Invoke(new ProgressChangedEventHandler(downloader_ProgressChanged), sender, e);
            else
            {
                try
                {
                    processing = true;
                    psbDownload.Value = e.ProgressPercentage > 100 ? 100 : e.ProgressPercentage;
                    string speed = String.Format(new FileSizeFormatProvider(), "{0:fs}", downloader.DownloadSpeed);
                    string ETA = downloader.ETA == 0 ? "" : "  [ " + FormatLeftTime.Format(((long)downloader.ETA) * 1000) + " ]";
                    status_Label.Text = speed + ETA;
                }
                catch { }
                finally { processing = false; }
            }
        }

        private void pause_Button_Click(object sender, EventArgs e)
        {
            if (downloader.DownloadStatus == DownloadStatus.Downloading)
            {
                downloader.Pause();
                pause_Button.Text = "Resume";
            }
            else if (downloader.DownloadStatus == DownloadStatus.Paused)
            {
                downloader.Resume();
                pause_Button.Text = "Pause";
            }
        }

        private void stop_Button_Click(object sender, EventArgs e)
        {
            if (downloader.IsBusy)
            {
                downloader.CancelAsync();
                pnDownloading.Visible = false;
                btnDownload.Visible = true;
                pause_Button.Text = "Pause";
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start(downloadedPath);
        }

        private void psbDownload_Click(object sender, EventArgs e)
        {

        }
    }
}
