using Flickrdownloader.Properties;
using Flickrdownloader.userControl;
using RestSharp;
using RestSharp.Contrib;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlickrREST.Model;
using FlickrREST;
using FlickrREST.Exceptions;
using System.Xml;

namespace Flickrdownloader
{
    public partial class frmMain : Form
    {
        private int page = 1;
        private string keyword;
        private enum ACTION { SEARCHIMAGE, DOWNLOADSET };
        private ACTION curAction;
        private FlickrApi client = new FlickrApi("63072d29b6e277ca23a72d77a78278ce");
        private int curDownload = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (bwSearch.IsBusy)
            {
                bwSearch.CancelAsync();
            }
            else
            {
                if (tbxKeyword.Text != keyword)
                {
                    page = 1;
                    keyword = tbxKeyword.Text;
                    SaveSetting();
                    btnClean.PerformClick();
                }
                bwSearch.RunWorkerAsync();
            }
        }
        public void SaveSetting()
        {
            switch (curAction)
            {
                case ACTION.SEARCHIMAGE:
                    Settings.Default.keyword = keyword;
                    break;

                case ACTION.DOWNLOADSET:
                    Settings.Default.setID = keyword;
                    break;
            }
            Settings.Default.perpage = mbxPerpage.Value.ToString();
            Settings.Default.Save();
        }
        public DoWorkRresponse GetImageSet(string id,int page)
        {
            try
            {
                Photoset photoset = client.Photosets_getPhotos(id, page.ToString(), mbxPerpage.Value.ToString());
                string photosetinfo = "Owner Name : {0}\r\nImage count : {1}/{2}\r\nCurrent page : {3}/{4}";
                foreach (Photo p in photoset.photos)
                {
                    if (p.url_q != null)
                    {
                        flowLayoutPanel.Invoke((Action)(() => flowLayoutPanel.Controls.Add( new Item(p.url_q, p.GetLagestSizeURL()) ) ));
                    }
                    else
                    {
                        flowLayoutPanel.Invoke((Action)(() => flowLayoutPanel.Controls.Add(new Item(p.url_t, p.GetLagestSizeURL()))));
                    }
                }
                return new DoWorkRresponse(DoWorkRresponse.CODE.SUCCESS, String.Format(photosetinfo, photoset.ownername, photoset.photos.Count, photoset.total, page, photoset.pages));
            }
            catch (FlickrAPIException fae)
            {
                if(fae.Code =="1")
                {
                    return new DoWorkRresponse(DoWorkRresponse.CODE.PHOTOSERNOTFOUND, fae.Msg);
                }
                if (fae.Code == "105")
                {
                    return new DoWorkRresponse(DoWorkRresponse.CODE.SERVICEUNAVAILABLE, fae.Msg);
                }
                    return new DoWorkRresponse(DoWorkRresponse.CODE.UNKNOWERROR, fae.Msg);
            }
            catch (ApplicationException ae)
            {
                return new DoWorkRresponse(DoWorkRresponse.CODE.UNKNOWERROR, "Got error, try again late.");
            }
        }

        public DoWorkRresponse SeachImage(string keyword, int page, int perpage)
        {
            try
            {
                List<QuickSearchResultItem> response = client.QuickSearch(keyword, page, perpage);
                if (response == null)
                {
                    return new DoWorkRresponse(DoWorkRresponse.CODE.SERVICEUNAVAILABLE, "Service current unavailable");
                }
                if (response.Count == 0)
                {
                    return new DoWorkRresponse(DoWorkRresponse.CODE.NOIMAGEFOUND, "No image found");
                }
                foreach (QuickSearchResultItem ri in response)
                {
                    if (ri.sizes.q != null)
                    {
                        flowLayoutPanel.Invoke((Action)(() => flowLayoutPanel.Controls.Add(new Item(ri.sizes.q.url,ri.sizes.GetLagestSize().url))));
                    }
                }
                return new DoWorkRresponse(DoWorkRresponse.CODE.SUCCESS, "Success");
            }
            catch (ApplicationException ae)
            {
                return new DoWorkRresponse(DoWorkRresponse.CODE.UNKNOWERROR, "Unknow error, send this code to author \n:" + ae.InnerException);
            }
            catch (XmlException xe)
            {
                return new DoWorkRresponse(DoWorkRresponse.CODE.NOIMAGEFOUND, "No result found for this keyword, please try again with diffirent keyword");
            }
            catch (Exception ex)
            {
                return new DoWorkRresponse(DoWorkRresponse.CODE.UNKNOWERROR, "Unknow error, send this code to author \n:" + ex.ToString());
            }
        }

        public DoWorkRresponse AdvanceImageSearch(string tags, int page, int perpage)
        {
            try
            {
                SearchParameter parameters = new SearchParameter();
                parameters.AddParameter("text", tags);
                Photoset photoset = client.Photos_search(parameters, page.ToString(), mbxPerpage.Value.ToString());
                string photosetinfo = "Tags : {0}\r\nImage count : {1}/{2}\r\nCurrent page : {3}/{4}";
                foreach (Photo p in photoset.photos)
                {
                    if (p.url_q != null)
                    {
                        flowLayoutPanel.Invoke((Action)(() => flowLayoutPanel.Controls.Add(new Item(p.url_q, p.GetLagestSizeURL()))));
                    }
                    else
                    {
                        flowLayoutPanel.Invoke((Action)(() => flowLayoutPanel.Controls.Add(new Item(p.url_t, p.GetLagestSizeURL()))));
                    }
                }
                return new DoWorkRresponse(DoWorkRresponse.CODE.SUCCESS, String.Format(photosetinfo, tags, photoset.photos.Count, photoset.total, page, photoset.pages));
            }
            catch (FlickrAPIException fae)
            {
                if (fae.Code == "105")
                {
                    return new DoWorkRresponse(DoWorkRresponse.CODE.SERVICEUNAVAILABLE, fae.Msg);
                }
                if (fae.Code == "-1")
                {
                    return new DoWorkRresponse(DoWorkRresponse.CODE.NOINTERNETCONNECTION, fae.Msg);
                }
                return new DoWorkRresponse(DoWorkRresponse.CODE.UNKNOWERROR, "Got error, try again late.");
            }
            catch (ApplicationException ae)
            {
                return new DoWorkRresponse(DoWorkRresponse.CODE.UNKNOWERROR, "Got error, try again late.");
            }
        }

        private void bwSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            btnSearch.Invoke((Action)(() => btnSearch.Text = "Stop"));
            psbSearch.Invoke((Action)(() => psbSearch.Enabled = true));
            psbSearch.Invoke((Action)(() => psbSearch.Style = ProgressBarStyle.Marquee));
            DoWorkRresponse response;

            switch (curAction)
            {
                case ACTION.SEARCHIMAGE:
                    //response = AdvanceImageSearch(keyword, page, Convert.ToInt32(mbxPerpage.Value));
                    response = SeachImage(keyword, page, Convert.ToInt32(mbxPerpage.Value));
                    if (response.Code == DoWorkRresponse.CODE.SUCCESS)
                    {
                        btnSearch.Invoke((Action)(() => btnSearch.Text = "Next (" + (page + 1).ToString() + ")"));
                        page++;
                    }
                    else if (response.Code == DoWorkRresponse.CODE.NOIMAGEFOUND || response.Code == DoWorkRresponse.CODE.SERVICEUNAVAILABLE || response.Code == DoWorkRresponse.CODE.UNKNOWERROR)
                    {
                        btnSearch.Invoke((Action)(() => btnSearch.Text = "Try again"));
                    }

                    tbxInfo.Invoke((Action)(() => tbxInfo.Text = response.Msg));
                    break;
                case ACTION.DOWNLOADSET:
                    response = GetImageSet(keyword, page);
                    if (response.Code == DoWorkRresponse.CODE.SUCCESS)
                    {
                        btnSearch.Invoke((Action)(() => btnSearch.Text = "Next"));
                        page++;
                    }
                    else if (response.Code == DoWorkRresponse.CODE.PHOTOSERNOTFOUND || response.Code == DoWorkRresponse.CODE.SERVICEUNAVAILABLE || response.Code == DoWorkRresponse.CODE.UNKNOWERROR || response.Code == DoWorkRresponse.CODE.NOINTERNETCONNECTION)
                    {
                        btnSearch.Invoke((Action)(() => btnSearch.Text = "Try again"));
                    }
                    tbxInfo.Invoke((Action)(() => tbxInfo.Text = response.Msg));
                    break;
            }
        }

        private void bwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            psbSearch.Invoke((Action)(() => psbSearch.Enabled = false));
            psbSearch.Invoke((Action)(() => psbSearch.Style = ProgressBarStyle.Blocks));
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
            {
                if (!((Item)flowLayoutPanel.Controls[i]).IsDownloading)
                {
                    flowLayoutPanel.Controls.RemoveAt(i);
                }
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog d = new FolderBrowserDialog())
            {
                d.Description = "Select folder to save file:";
                d.ShowNewFolderButton = true;
                if (Directory.Exists(tbxSaveFolder.Text))
                    d.SelectedPath = tbxSaveFolder.Text;
                if (d.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    tbxSaveFolder.Text = d.SelectedPath;
                    Settings.Default.downloadPath = d.SelectedPath;
                    Settings.Default.Save();
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.downloadPath);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pbxLogo.ImageLocation = "http://muatocroi.com/addition/adsservice/FlickrDownloader_295x86.png";
            tbxSaveFolder.Text = Settings.Default.downloadPath;
            tbxKeyword.Text = Settings.Default.keyword;

            cbbxAction.Items.Add("Search image");
            cbbxAction.Items.Add("Download photoset");
            cbbxAction.SelectedIndex = 0;
            mbxPerpage.Value = int.Parse(Settings.Default.perpage);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void tbxSaveFolder_Leave(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxSaveFolder.Text))
            {
                try
                {
                    Directory.CreateDirectory(tbxSaveFolder.Text);
                }
                catch
                {
                    MessageBox.Show("Không thể tạo thư mục");
                    tbxSaveFolder.Focus();
                }
            }
            Settings.Default.downloadPath = tbxSaveFolder.Text;
            Settings.Default.Save();
        }

        private void cbbxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            curAction = (ACTION)cbbxAction.SelectedIndex;
            switch (curAction)
            { 
                case ACTION.SEARCHIMAGE:
                    tbxKeyword.Text = Settings.Default.keyword;
                    mbxPerpage.Enabled = false;
                    break;
                case ACTION.DOWNLOADSET:
                    tbxKeyword.Text = Settings.Default.setID;
                    mbxPerpage.Enabled = true;
                    break;
            }
        }

        private void bwDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            ((Item)flowLayoutPanel.Controls[curDownload]).download();
        }

        private void bwDownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(curDownload<flowLayoutPanel.Controls.Count)
            {
                curDownload++;
                bwDownload.RunWorkerAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bwDownload.RunWorkerAsync();
        }
    }
}
