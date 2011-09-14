namespace GDX
{
    partial class AddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddData));
            this.gbxAddFiles = new System.Windows.Forms.GroupBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lstFilePaths = new System.Windows.Forms.ListBox();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAddFile = new System.Windows.Forms.TextBox();
            this.lblAddFile = new System.Windows.Forms.Label();
            this.btnZip = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxAddFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddFiles
            // 
            this.gbxAddFiles.Controls.Add(this.lblFiles);
            this.gbxAddFiles.Controls.Add(this.lstFilePaths);
            this.gbxAddFiles.Controls.Add(this.btnRemoveFile);
            this.gbxAddFiles.Controls.Add(this.btnAddFile);
            this.gbxAddFiles.Controls.Add(this.btnBrowse);
            this.gbxAddFiles.Controls.Add(this.txtAddFile);
            this.gbxAddFiles.Controls.Add(this.lblAddFile);
            this.gbxAddFiles.Location = new System.Drawing.Point(12, 12);
            this.gbxAddFiles.Name = "gbxAddFiles";
            this.gbxAddFiles.Size = new System.Drawing.Size(449, 192);
            this.gbxAddFiles.TabIndex = 6;
            this.gbxAddFiles.TabStop = false;
            this.gbxAddFiles.Text = "Select Files for Upload";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(41, 57);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 6;
            this.lblFiles.Text = "Files:";
            // 
            // lstFilePaths
            // 
            this.lstFilePaths.FormattingEnabled = true;
            this.lstFilePaths.HorizontalScrollbar = true;
            this.lstFilePaths.Location = new System.Drawing.Point(81, 56);
            this.lstFilePaths.Name = "lstFilePaths";
            this.lstFilePaths.Size = new System.Drawing.Size(257, 121);
            this.lstFilePaths.TabIndex = 4;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(349, 86);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveFile.TabIndex = 6;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(349, 57);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(87, 23);
            this.btnAddFile.TabIndex = 5;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(349, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAddFile
            // 
            this.txtAddFile.Location = new System.Drawing.Point(80, 30);
            this.txtAddFile.Name = "txtAddFile";
            this.txtAddFile.Size = new System.Drawing.Size(258, 20);
            this.txtAddFile.TabIndex = 2;
            // 
            // lblAddFile
            // 
            this.lblAddFile.AutoSize = true;
            this.lblAddFile.Location = new System.Drawing.Point(24, 30);
            this.lblAddFile.Name = "lblAddFile";
            this.lblAddFile.Size = new System.Drawing.Size(48, 13);
            this.lblAddFile.TabIndex = 0;
            this.lblAddFile.Text = "Add File:";
            // 
            // btnZip
            // 
            this.btnZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnZip.Location = new System.Drawing.Point(361, 210);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(87, 23);
            this.btnZip.TabIndex = 7;
            this.btnZip.Text = "Ok";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 255);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.gbxAddFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddData";
            this.Text = "Add other files";
            this.gbxAddFiles.ResumeLayout(false);
            this.gbxAddFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddFiles;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Label lblFiles;
        public System.Windows.Forms.ListBox lstFilePaths;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAddFile;
        private System.Windows.Forms.Label lblAddFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCancel;
    }
}