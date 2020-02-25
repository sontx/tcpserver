namespace TcpServer
{
    partial class IncommingDataForm
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
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.pnlWorkingSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkingSpace
            // 
            this.pnlWorkingSpace.Controls.Add(this.txtLogs);
            this.pnlWorkingSpace.Size = new System.Drawing.Size(661, 293);
            // 
            // pnlControlSpace
            // 
            this.pnlControlSpace.Location = new System.Drawing.Point(0, 293);
            this.pnlControlSpace.Size = new System.Drawing.Size(661, 42);
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(661, 293);
            this.txtLogs.TabIndex = 0;
            this.txtLogs.WordWrap = false;
            // 
            // IncommingDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 335);
            this.Name = "IncommingDataForm";
            this.Text = "Incomming Data";
            this.pnlWorkingSpace.ResumeLayout(false);
            this.pnlWorkingSpace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogs;
    }
}