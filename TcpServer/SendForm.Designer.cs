namespace TcpServer
{
    partial class SendForm
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
            this.labMessage = new System.Windows.Forms.Label();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.labError = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtContent = new TcpServer.TextBoxEx();
            this.pnlWorkingSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkingSpace
            // 
            this.pnlWorkingSpace.Controls.Add(this.txtContent);
            this.pnlWorkingSpace.Controls.Add(this.cbbMode);
            this.pnlWorkingSpace.Controls.Add(this.labError);
            this.pnlWorkingSpace.Controls.Add(this.labMessage);
            this.pnlWorkingSpace.Size = new System.Drawing.Size(443, 166);
            // 
            // pnlControlSpace
            // 
            this.pnlControlSpace.Location = new System.Drawing.Point(0, 166);
            this.pnlControlSpace.Size = new System.Drawing.Size(443, 42);
            // 
            // labMessage
            // 
            this.labMessage.AutoSize = true;
            this.labMessage.Location = new System.Drawing.Point(9, 20);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(106, 17);
            this.labMessage.TabIndex = 0;
            this.labMessage.Text = "Send to 0 client";
            // 
            // cbbMode
            // 
            this.cbbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Items.AddRange(new object[] {
            "Once",
            "Every 1 sec",
            "Every 2 secs",
            "Every 3 secs",
            "Every 4 secs",
            "Every 5 secs",
            "Every 10 secs"});
            this.cbbMode.Location = new System.Drawing.Point(12, 56);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(132, 24);
            this.cbbMode.TabIndex = 2;
            // 
            // labError
            // 
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(9, 94);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(425, 70);
            this.labError.TabIndex = 0;
            this.labError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.HexOnly = false;
            this.txtContent.Location = new System.Drawing.Point(150, 58);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(281, 22);
            this.txtContent.TabIndex = 3;
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 208);
            this.Name = "SendForm";
            this.Text = "Send";
            this.pnlWorkingSpace.ResumeLayout(false);
            this.pnlWorkingSpace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labMessage;
        private System.Windows.Forms.ComboBox cbbMode;
        private TextBoxEx txtContent;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.Timer timer1;
    }
}