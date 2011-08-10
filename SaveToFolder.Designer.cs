namespace GDX
{
    partial class SaveToFolder
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
            this.gbxDestination = new System.Windows.Forms.GroupBox();
            this.btnSaveBrowse = new System.Windows.Forms.Button();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.lblSaveTo = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDestination
            // 
            this.gbxDestination.Controls.Add(this.btnSaveBrowse);
            this.gbxDestination.Controls.Add(this.txtSaveTo);
            this.gbxDestination.Controls.Add(this.lblSaveTo);
            this.gbxDestination.Location = new System.Drawing.Point(32, 25);
            this.gbxDestination.Name = "gbxDestination";
            this.gbxDestination.Size = new System.Drawing.Size(416, 101);
            this.gbxDestination.TabIndex = 9;
            this.gbxDestination.TabStop = false;
            this.gbxDestination.Text = "Save Compressed Folder";
            // 
            // btnSaveBrowse
            // 
            this.btnSaveBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveBrowse.Location = new System.Drawing.Point(320, 28);
            this.btnSaveBrowse.Name = "btnSaveBrowse";
            this.btnSaveBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBrowse.TabIndex = 5;
            this.btnSaveBrowse.Text = "Browse...";
            this.btnSaveBrowse.UseVisualStyleBackColor = true;
            this.btnSaveBrowse.Click += new System.EventHandler(this.btnSaveBrowse_Click);
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSaveTo.Location = new System.Drawing.Point(60, 30);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.Size = new System.Drawing.Size(254, 20);
            this.txtSaveTo.TabIndex = 4;
            // 
            // lblSaveTo
            // 
            this.lblSaveTo.AutoSize = true;
            this.lblSaveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSaveTo.Location = new System.Drawing.Point(6, 35);
            this.lblSaveTo.Name = "lblSaveTo";
            this.lblSaveTo.Size = new System.Drawing.Size(51, 13);
            this.lblSaveTo.TabIndex = 3;
            this.lblSaveTo.Text = "Save To:";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(352, 141);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 10;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(92, 141);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SaveToFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 190);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.gbxDestination);
            this.Name = "SaveToFolder";
            this.Text = "SaveToFolder";
            this.gbxDestination.ResumeLayout(false);
            this.gbxDestination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDestination;
        private System.Windows.Forms.Button btnSaveBrowse;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.Label lblSaveTo;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}