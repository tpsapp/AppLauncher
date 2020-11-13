namespace AppLauncher
{
    partial class frmAddApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddApp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAppPath = new System.Windows.Forms.TextBox();
            this.tbCmdLine = new System.Windows.Forms.TextBox();
            this.cbStartMin = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWaitTime = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Command Line Arguments:";
            // 
            // tbAppPath
            // 
            this.tbAppPath.Location = new System.Drawing.Point(12, 25);
            this.tbAppPath.Name = "tbAppPath";
            this.tbAppPath.Size = new System.Drawing.Size(263, 20);
            this.tbAppPath.TabIndex = 2;
            // 
            // tbCmdLine
            // 
            this.tbCmdLine.Location = new System.Drawing.Point(12, 64);
            this.tbCmdLine.Name = "tbCmdLine";
            this.tbCmdLine.Size = new System.Drawing.Size(319, 20);
            this.tbCmdLine.TabIndex = 3;
            // 
            // cbStartMin
            // 
            this.cbStartMin.AutoSize = true;
            this.cbStartMin.Checked = true;
            this.cbStartMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStartMin.Location = new System.Drawing.Point(72, 105);
            this.cbStartMin.Name = "cbStartMin";
            this.cbStartMin.Size = new System.Drawing.Size(97, 17);
            this.cbStartMin.TabIndex = 4;
            this.cbStartMin.Text = "Start Minimized";
            this.cbStartMin.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(175, 99);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(256, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wait time:";
            // 
            // tbWaitTime
            // 
            this.tbWaitTime.Location = new System.Drawing.Point(12, 103);
            this.tbWaitTime.Name = "tbWaitTime";
            this.tbWaitTime.Size = new System.Drawing.Size(54, 20);
            this.tbWaitTime.TabIndex = 8;
            this.tbWaitTime.Text = "10";
            // 
            // ofdFile
            // 
            this.ofdFile.DefaultExt = "*.exe";
            this.ofdFile.Filter = "Executable Files|*.exe|Batch Files|*.bat|Com Files|*.com";
            this.ofdFile.InitialDirectory = "c:\\";
            this.ofdFile.Title = "Choose the application you would like to launch:";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(281, 22);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(52, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "C&hoose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // frmAddApp
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(345, 133);
            this.ControlBox = false;
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.tbWaitTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbStartMin);
            this.Controls.Add(this.tbCmdLine);
            this.Controls.Add(this.tbAppPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new Application...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAppPath;
        private System.Windows.Forms.TextBox tbCmdLine;
        private System.Windows.Forms.CheckBox cbStartMin;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWaitTime;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnChoose;
    }
}