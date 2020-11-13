using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppLauncher
{
    public partial class frmOptions : Form
    {
        RegistryKey mainKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SWAppLauncher");
        string[,] appinfo;

        void ReadAppList()
        {
            int subappcount = 0;
            appinfo = new string[mainKey.SubKeyCount, 4];
            foreach (string subKeyName in mainKey.GetSubKeyNames())
            {
                using (RegistryKey tempKey = mainKey.OpenSubKey(subKeyName))
                {
                    foreach (string valueName in tempKey.GetValueNames())
                    {
                        appinfo[Convert.ToInt32(subKeyName), subappcount] = tempKey.GetValue(valueName).ToString();
                        if (subappcount >= 3)
                        {
                            subappcount = 0;
                        }
                        else
                        {
                            subappcount++;
                        }
                    }
                }
            }
        }

        void CreateAppControls()
        {
            int rowcount = 0;
            int yPos = 8;
            for (int i = 0; i < mainKey.SubKeyCount; i++)
            {
                TextBox tbAppPath = new TextBox();
                tbAppPath.Location = new Point(8, yPos);
                tbAppPath.Name = "tbAppPath" + rowcount.ToString();
                tbAppPath.Size = new Size(150, 22);
                tbAppPath.Text = appinfo[i, 0];
                tbAppPath.Enabled = false;
                tbAppPath.BackColor = Color.White;

                TextBox tbCmdLine = new TextBox();
                tbCmdLine.Location = new Point(166, yPos);
                tbCmdLine.Name = "tbCmdLine" + rowcount.ToString();
                tbCmdLine.Size = new Size(150, 22);
                tbCmdLine.Text = appinfo[i, 1];
                tbCmdLine.Enabled = false;
                tbCmdLine.BackColor = Color.White;

                TextBox tbWaitTime = new TextBox();
                tbWaitTime.Location = new Point(324, yPos);
                tbWaitTime.Name = "tbWaitTime" + rowcount.ToString();
                tbWaitTime.Size = new Size(150, 22);
                tbWaitTime.Text = appinfo[i, 2];
                tbWaitTime.Enabled = false;
                tbWaitTime.BackColor = Color.White;

                TextBox tbStartMin = new TextBox();
                tbStartMin.Location = new Point(482, yPos);
                tbStartMin.Name = "tbStartMin" + rowcount.ToString();
                tbStartMin.Size = new Size(150, 22);
                tbStartMin.Text = appinfo[i, 3];
                tbStartMin.Enabled = false;
                tbStartMin.BackColor = Color.White;

                pAppInfo.Controls.Add(tbAppPath);
                pAppInfo.Controls.Add(tbCmdLine);
                pAppInfo.Controls.Add(tbWaitTime);
                pAppInfo.Controls.Add(tbStartMin);

                rowcount++;
                yPos = (rowcount * 24) + 8;
            }
        }

        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            Form frmNewAddApp = new frmAddApp();
            frmNewAddApp.ShowDialog();
            //this.Close();
            pAppInfo.Controls.Clear();
            ReadAppList();
            CreateAppControls();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            if (mainKey.SubKeyCount > 0)
            {
                ReadAppList();
                CreateAppControls();
            }
            else
            {
                MessageBox.Show("No Applications added.  Please click the Add... button to add an application.");
            }
        }
    }
}
