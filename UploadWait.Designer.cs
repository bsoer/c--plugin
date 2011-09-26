namespace GDX
{
    partial class UploadWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadWait));
            this.lblUploadWait = new System.Windows.Forms.Label();
            this.prbUpload = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblUploadRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUploadWait
            // 
            this.lblUploadWait.AutoSize = true;
            this.lblUploadWait.Location = new System.Drawing.Point(25, 42);
            this.lblUploadWait.Name = "lblUploadWait";
            this.lblUploadWait.Size = new System.Drawing.Size(83, 13);
            this.lblUploadWait.TabIndex = 0;
            this.lblUploadWait.Text = "Uploading file ...";
            this.lblUploadWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prbUpload
            // 
            this.prbUpload.Location = new System.Drawing.Point(26, 79);
            this.prbUpload.Name = "prbUpload";
            this.prbUpload.Size = new System.Drawing.Size(182, 23);
            this.prbUpload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prbUpload.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(75, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.btnOk.Location = new System.Drawing.Point(75, 120);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblUploadRes
            // 
            this.lblUploadRes.AutoSize = true;
            this.lblUploadRes.Location = new System.Drawing.Point(29, 42);
            this.lblUploadRes.Name = "lblUploadRes";
            this.lblUploadRes.Size = new System.Drawing.Size(133, 13);
            this.lblUploadRes.TabIndex = 4;
            this.lblUploadRes.Text = "File successfully uploaded.";
            this.lblUploadRes.Visible = false;
            // 
            // UploadWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 164);
            this.Controls.Add(this.lblUploadWait);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prbUpload);
            this.Controls.Add(this.lblUploadRes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadWait";
            this.Text = "Please wait ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblUploadWait;
        public System.Windows.Forms.ProgressBar prbUpload;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Label lblUploadRes;
    }
}