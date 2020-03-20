namespace TcpServer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labClients = new System.Windows.Forms.ToolStripStatusLabel();
            this.labError = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnSendText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSendHex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnShowIncommingData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopyAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCopyReceivedData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnStart = new System.Windows.Forms.ToolStripButton();
            this.mnStop = new System.Windows.Forms.ToolStripButton();
            this.mnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSendTextAll = new System.Windows.Forms.ToolStripButton();
            this.mnSendHexAll = new System.Windows.Forms.ToolStripButton();
            this.mnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labStatus,
            this.labClients,
            this.labError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labStatus
            // 
            this.labStatus.Image = ((System.Drawing.Image)(resources.GetObject("labStatus.Image")));
            this.labStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(16, 16);
            // 
            // labClients
            // 
            this.labClients.Image = ((System.Drawing.Image)(resources.GetObject("labClients.Image")));
            this.labClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.labClients.Name = "labClients";
            this.labClients.Size = new System.Drawing.Size(16, 16);
            // 
            // labError
            // 
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Image = ((System.Drawing.Image)(resources.GetObject("labError.Image")));
            this.labError.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(16, 16);
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvClients
            // 
            this.lvClients.CheckBoxes = true;
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5});
            this.lvClients.ContextMenuStrip = this.contextMenuStrip1;
            this.lvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvClients.FullRowSelect = true;
            this.lvClients.GridLines = true;
            this.lvClients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(0, 25);
            this.lvClients.Name = "lvClients";
            this.lvClients.ShowItemToolTips = true;
            this.lvClients.Size = new System.Drawing.Size(854, 428);
            this.lvClients.TabIndex = 4;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            this.lvClients.DoubleClick += new System.EventHandler(this.lvClients_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Port";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Connected Time";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Received Count";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Received Time";
            this.columnHeader7.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Received Data";
            this.columnHeader5.Width = 185;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSendText,
            this.mnSendHex,
            this.toolStripMenuItem1,
            this.mnShowIncommingData,
            this.mnClear,
            this.mnCopy,
            this.toolStripMenuItem2,
            this.mnDisconnect});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 188);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnSendText
            // 
            this.mnSendText.Image = ((System.Drawing.Image)(resources.GetObject("mnSendText.Image")));
            this.mnSendText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSendText.Name = "mnSendText";
            this.mnSendText.Size = new System.Drawing.Size(229, 24);
            this.mnSendText.Text = "Send Text...";
            this.mnSendText.Click += new System.EventHandler(this.mnSendText_Click);
            // 
            // mnSendHex
            // 
            this.mnSendHex.Image = ((System.Drawing.Image)(resources.GetObject("mnSendHex.Image")));
            this.mnSendHex.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSendHex.Name = "mnSendHex";
            this.mnSendHex.Size = new System.Drawing.Size(229, 24);
            this.mnSendHex.Text = "Send Hex...";
            this.mnSendHex.Click += new System.EventHandler(this.mnSendHex_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // mnShowIncommingData
            // 
            this.mnShowIncommingData.Image = ((System.Drawing.Image)(resources.GetObject("mnShowIncommingData.Image")));
            this.mnShowIncommingData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnShowIncommingData.Name = "mnShowIncommingData";
            this.mnShowIncommingData.Size = new System.Drawing.Size(229, 24);
            this.mnShowIncommingData.Text = "Show Incomming Data";
            this.mnShowIncommingData.Click += new System.EventHandler(this.mnShowIncommingData_Click);
            // 
            // mnCopy
            // 
            this.mnCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCopyAddress,
            this.mnCopyReceivedData});
            this.mnCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnCopy.Image")));
            this.mnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnCopy.Name = "mnCopy";
            this.mnCopy.Size = new System.Drawing.Size(229, 24);
            this.mnCopy.Text = "Copy";
            // 
            // mnCopyAddress
            // 
            this.mnCopyAddress.Name = "mnCopyAddress";
            this.mnCopyAddress.Size = new System.Drawing.Size(226, 26);
            this.mnCopyAddress.Text = "Copy Address";
            this.mnCopyAddress.Click += new System.EventHandler(this.mnCopyAddress_Click);
            // 
            // mnCopyReceivedData
            // 
            this.mnCopyReceivedData.Name = "mnCopyReceivedData";
            this.mnCopyReceivedData.Size = new System.Drawing.Size(226, 26);
            this.mnCopyReceivedData.Text = "Copy Received Data";
            this.mnCopyReceivedData.Click += new System.EventHandler(this.mnCopyReceivedData_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // mnDisconnect
            // 
            this.mnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("mnDisconnect.Image")));
            this.mnDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnDisconnect.Name = "mnDisconnect";
            this.mnDisconnect.Size = new System.Drawing.Size(229, 24);
            this.mnDisconnect.Text = "Disconnect";
            this.mnDisconnect.Click += new System.EventHandler(this.mnDisconnect_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnStart,
            this.mnStop,
            this.mnSettings,
            this.toolStripSeparator1,
            this.mnSendTextAll,
            this.mnSendHexAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 5;
            // 
            // mnStart
            // 
            this.mnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnStart.Image = ((System.Drawing.Image)(resources.GetObject("mnStart.Image")));
            this.mnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnStart.Name = "mnStart";
            this.mnStart.Size = new System.Drawing.Size(29, 22);
            this.mnStart.Text = "Start";
            this.mnStart.Click += new System.EventHandler(this.mnStart_Click);
            // 
            // mnStop
            // 
            this.mnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnStop.Enabled = false;
            this.mnStop.Image = ((System.Drawing.Image)(resources.GetObject("mnStop.Image")));
            this.mnStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnStop.Name = "mnStop";
            this.mnStop.Size = new System.Drawing.Size(29, 22);
            this.mnStop.Text = "Stop";
            this.mnStop.Click += new System.EventHandler(this.mnStop_Click);
            // 
            // mnSettings
            // 
            this.mnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSettings.Image = ((System.Drawing.Image)(resources.GetObject("mnSettings.Image")));
            this.mnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSettings.Name = "mnSettings";
            this.mnSettings.Size = new System.Drawing.Size(29, 22);
            this.mnSettings.Text = "Settings";
            this.mnSettings.Click += new System.EventHandler(this.mnSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mnSendTextAll
            // 
            this.mnSendTextAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSendTextAll.Enabled = false;
            this.mnSendTextAll.Image = ((System.Drawing.Image)(resources.GetObject("mnSendTextAll.Image")));
            this.mnSendTextAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSendTextAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSendTextAll.Name = "mnSendTextAll";
            this.mnSendTextAll.Size = new System.Drawing.Size(29, 22);
            this.mnSendTextAll.Text = "Send text to all checked clients";
            this.mnSendTextAll.Click += new System.EventHandler(this.mnSendTextAll_Click);
            // 
            // mnSendHexAll
            // 
            this.mnSendHexAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnSendHexAll.Enabled = false;
            this.mnSendHexAll.Image = ((System.Drawing.Image)(resources.GetObject("mnSendHexAll.Image")));
            this.mnSendHexAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSendHexAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnSendHexAll.Name = "mnSendHexAll";
            this.mnSendHexAll.Size = new System.Drawing.Size(29, 22);
            this.mnSendHexAll.Text = "Send hex to all checked clients";
            this.mnSendHexAll.Click += new System.EventHandler(this.mnSendHexAll_Click);
            // 
            // mnClear
            // 
            this.mnClear.Image = ((System.Drawing.Image)(resources.GetObject("mnClear.Image")));
            this.mnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnClear.Name = "mnClear";
            this.mnClear.Size = new System.Drawing.Size(229, 24);
            this.mnClear.Text = "Clear";
            this.mnClear.Click += new System.EventHandler(this.mnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(854, 475);
            this.Controls.Add(this.lvClients);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TcpServer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnStart;
        private System.Windows.Forms.ToolStripButton mnStop;
        private System.Windows.Forms.ToolStripButton mnSettings;
        private System.Windows.Forms.ToolStripStatusLabel labStatus;
        private System.Windows.Forms.ToolStripStatusLabel labClients;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnSendText;
        private System.Windows.Forms.ToolStripMenuItem mnSendHex;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnDisconnect;
        private System.Windows.Forms.ToolStripStatusLabel labError;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnSendTextAll;
        private System.Windows.Forms.ToolStripButton mnSendHexAll;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem mnCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnCopyAddress;
        private System.Windows.Forms.ToolStripMenuItem mnCopyReceivedData;
        private System.Windows.Forms.ToolStripMenuItem mnShowIncommingData;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem mnClear;
    }
}

