using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace AppLauncher
{
    public partial class frmAddApp : Form
    {
        RegistryKey mainKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SWAppLauncher");

        void AddApplication(string path, string cmdline, string waittime, bool startmin)
        {
            RegistryKey subKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SWAppLauncher\\" + mainKey.SubKeyCount.ToString());
            subKey.SetValue("AppPath", path);
            subKey.SetValue("CmdLine", cmdline);
            subKey.SetValue("WaitTime", waittime);
            subKey.SetValue("StartMinimized", startmin.ToString());
        }

        public frmAddApp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbAppPath.Text == "")
            {
                MessageBox.Show("Please fill in a path for the application you wish to launch.");
            }
            else
            {
                AddApplication(tbAppPath.Text, tbCmdLine.Text, tbWaitTime.Text, cbStartMin.Checked);
                this.Close();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ofdFile.ShowDialog();
            tbAppPath.Text = ofdFile.FileName;
        }
    }
}
