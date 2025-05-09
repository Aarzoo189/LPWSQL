namespace LPWSQL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.TabPage tabSMS;
        private System.Windows.Forms.TabPage tabCallLogs;
        private System.Windows.Forms.TabPage tabDeviceInfo;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridView dgvSMS;
        private System.Windows.Forms.DataGridView dgvCallLogs;
        private System.Windows.Forms.DataGridView dgvDeviceInfo;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnViewReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.tabSMS = new System.Windows.Forms.TabPage();
            this.dgvSMS = new System.Windows.Forms.DataGridView();
            this.tabCallLogs = new System.Windows.Forms.TabPage();
            this.dgvCallLogs = new System.Windows.Forms.DataGridView();
            this.tabDeviceInfo = new System.Windows.Forms.TabPage();
            this.dgvDeviceInfo = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabContacts);
            this.tabControl.Controls.Add(this.tabSMS);
            this.tabControl.Controls.Add(this.tabCallLogs);
            this.tabControl.Controls.Add(this.tabDeviceInfo);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 400);

            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.dgvContacts);
            this.tabContacts.Location = new System.Drawing.Point(4, 24);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(752, 372);
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;

            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.Name = "dgvContacts";

            // 
            // tabSMS
            // 
            this.tabSMS.Controls.Add(this.dgvSMS);
            this.tabSMS.Location = new System.Drawing.Point(4, 24);
            this.tabSMS.Name = "tabSMS";
            this.tabSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMS.Size = new System.Drawing.Size(752, 372);
            this.tabSMS.Text = "SMS Messages";
            this.tabSMS.UseVisualStyleBackColor = true;

            // 
            // dgvSMS
            // 
            this.dgvSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSMS.Name = "dgvSMS";

            // 
            // tabCallLogs
            // 
            this.tabCallLogs.Controls.Add(this.dgvCallLogs);
            this.tabCallLogs.Location = new System.Drawing.Point(4, 24);
            this.tabCallLogs.Name = "tabCallLogs";
            this.tabCallLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabCallLogs.Size = new System.Drawing.Size(752, 372);
            this.tabCallLogs.Text = "Call Logs";
            this.tabCallLogs.UseVisualStyleBackColor = true;

            // 
            // dgvCallLogs
            // 
            this.dgvCallLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCallLogs.Name = "dgvCallLogs";

            // 
            // tabDeviceInfo
            // 
            this.tabDeviceInfo.Controls.Add(this.dgvDeviceInfo);
            this.tabDeviceInfo.Location = new System.Drawing.Point(4, 24);
            this.tabDeviceInfo.Name = "tabDeviceInfo";
            this.tabDeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceInfo.Size = new System.Drawing.Size(752, 372);
            this.tabDeviceInfo.Text = "Device Info";
            this.tabDeviceInfo.UseVisualStyleBackColor = true;

            // 
            // dgvDeviceInfo
            // 
            this.dgvDeviceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceInfo.Name = "dgvDeviceInfo";

            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 420);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 30);
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);

            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(150, 420);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(150, 30);
            this.btnSaveToDB.Text = "Save to Database";
            this.btnSaveToDB.Click += new System.EventHandler(this.BtnSaveToDB_Click);

            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(320, 420);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(150, 30);
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.Click += new System.EventHandler(this.BtnViewReport_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.btnViewReport);
            this.Name = "Form1";
            this.Text = "Android Data Extractor";
            this.ResumeLayout(false);
        }
    }
}
