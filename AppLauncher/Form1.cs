using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AppLauncher
{
    public partial class frmMain : Form
    {
        RegistryKey mainKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SWAppLauncher");
        int count = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (mainKey == null)
            {
                mainKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SWAppLauncher");
            }

            if (mainKey.SubKeyCount <= 0)
            {
                btnStartStop.Enabled = false;
            }

            pbProgress.Maximum = mainKey.SubKeyCount;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form frmNewOptions = new frmOptions();
            frmNewOptions.ShowDialog(this);

            if (mainKey.SubKeyCount > 0)
            {
                btnStartStop.Enabled = true;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "&Start")
            {
                pbProgress.Value = 0;
                tmrLaunch.Enabled = true;
                btnStartStop.Text = "&Stop";
            }
            else
            {
                tmrLaunch.Enabled = false;
                btnStartStop.Text = "&Start";
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainKey.Close();
        }

        private void tmrLaunch_Tick(object sender, EventArgs e)
        {
            ProcessStartInfo psiApp = null;
            Process psApp = null;
            string path = string.Empty;
            string cmdline = string.Empty;
            string waittime = string.Empty;
            string startmin = string.Empty;
            RegistryKey tempKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SWAppLauncher\\" + count.ToString());
            foreach (string valueName in tempKey.GetValueNames())
            {
                switch (valueName)
                {
                    case "AppPath":
                        {
                            path = tempKey.GetValue(valueName).ToString();
                        }
                        break;
                    case "CmdLine":
                        {
                            cmdline = tempKey.GetValue(valueName).ToString();
                        }
                        break;
                    case "WaitTime":
                        {
                            waittime = tempKey.GetValue(valueName).ToString();
                        }
                        break;
                    case "StartMinimized":
                        {
                            startmin = tempKey.GetValue(valueName).ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            psiApp = new ProcessStartInfo(path, cmdline);
            if (startmin == "True")
            {
                psiApp.WindowStyle = ProcessWindowStyle.Minimized;
            }
            psApp = Process.Start(psiApp);
            psApp.WaitForExit(0);
            tmrLaunch.Interval = Convert.ToInt32(waittime) * 1000;
            count++;
            pbProgress.PerformStep();
            if (count >= mainKey.SubKeyCount)
            {
                tmrLaunch.Enabled = false;
                btnStartStop.Text = "&Start";
            }
        }
    }
}
