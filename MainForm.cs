using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Startup_manager
{
    public partial class MainForm : Form
    {
        private Mode Mode;

        public MainForm(Mode mode)
        {
            InitializeComponent();
            this.Mode = mode;
            cboxTimeType.SelectedIndex = 0;
        }

        #region ..//Helper
        void CreateNewListItem()
        {
            int delay = int.Parse(txtDelay.Text);
            delay = cboxTimeType.SelectedIndex == 0 ? delay : delay * 60;
            var app = new App
            {
                Delay = delay,
                Path = txtapp.Text,
                Name = Path.GetFileName(txtapp.Text)
            };
            if (Apps.Instance.AppsList.Contains(app))
            {
                MessageBox.Show("Already Exist!"); return;
            }
            Apps.Instance.Add(app);

            CreateNewListItem(txtapp.Text, Path.GetFileName(txtapp.Text), delay.ToString());
        }

        void CreateNewListItem(string path, string name, string delay)
        {
            var item = new ListViewItem
            {
                Text = lvApps.Items.Count.ToString()
            };
            item.SubItems.Add(name);
            item.SubItems.Add(path);
            item.SubItems.Add(delay);
            lvApps.Items.Add(item);
        }

        void LoadFile(string filePath)
        {
            txtapp.Text = filePath;
        }

        private void amT_Button1_Click(object sender, EventArgs e)
        {
            CreateNewListItem();
        }

        void StartApplications()
        {
            if (Apps.Instance.Count > 0)
            {
                foreach (var app in Apps.Instance.AppsList)
                {
                    int delay = app.Delay * 1000;
                    nIcon.BalloonTipText = $"{app.Name} will start in  {delay} second(s)..";
                    nIcon.ShowBalloonTip(2000);
                    Thread.Sleep(delay);
                    if (File.Exists(app.Path))
                        Process.Start(app.Path);
                }
                this.Close();
            }
        }

        void GenertateListApps()
        {
            foreach (var app in Apps.Instance.AppsList)
            {
                CreateNewListItem(app.Path, app.Name, app.Delay.ToString());
            }
        }
        #endregion

        #region ..//Private Methods
        private void Form1_Load(object sender, EventArgs e)
        {
            //load applications info
            Apps.Load();

            //add to startup if not exist
            if (Apps.Instance.StartWithWindows)
                Utils.AddToStartUp();

            chkStart.Checked = Apps.Instance.StartWithWindows;

            //check running mode
            switch (this.Mode)
            {
                case Mode.Manager:
                    GenertateListApps();
                    break;
                case Mode.AppStart:
                    this.Hide();
                    this.ShowInTaskbar = false;
                    StartApplications();
                    break;
                default:
                    break;
            }
        }

        private void SplitContainer1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files[0].ToLower().EndsWith("exe")) { LoadFile(files[0]); }
        }
        private void SplitContainer1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Apps.Instance.Save();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvApps.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are You Sure ?!", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Apps.Instance.AppsList.RemoveAt(lvApps.SelectedItems[0].Index);
                    lvApps.SelectedItems[0].Remove();
                }
            }
        }

        private void chkStart_Click(object sender, EventArgs e)
        {
            if (chkStart.Checked)
            {
                Utils.AddToStartUp(); Apps.Instance.StartWithWindows = true;
            }
            else
            {
                Utils.RemoveFromStartUp(); Apps.Instance.StartWithWindows = false;
            }
        }

        private void BtnOpenDirectory_Click(object sender, EventArgs e)
        {
            if (lvApps.SelectedItems.Count > 0)
                Utils.OpenFileLocation(lvApps.SelectedItems[0].SubItems[2].Text);
        }
        #endregion
    }


    public static class Utils
    {
        public static void AddToStartUp()
        {
            string key = Application.StartupPath + "\\" + Application.ProductName + ".exe -startup";
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            regKey.SetValue(Application.ProductName, key);

        }

        public static void RemoveFromStartUp()
        {
            string key = Application.StartupPath + "\\" + Application.ProductName + ".exe";
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            regKey.DeleteValue(Application.ProductName, false);
        }

        public static void OpenFileLocation(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }
            // combine the arguments together
            // it doesn't matter if there is a space after ','
            string argument = "/select, \"" + filePath + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }
    }

    public enum Mode
    {
        Manager = 0,
        AppStart = 1
    }

}
