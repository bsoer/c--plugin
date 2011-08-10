namespace GDX
{
    partial class Form1
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passwort = new System.Windows.Forms.Label();
            this.benutzer = new System.Windows.Forms.Label();
            this.gbxAddFiles = new System.Windows.Forms.GroupBox();
            this.btnZip = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lstFilePaths = new System.Windows.Forms.ListBox();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAddFile = new System.Windows.Forms.TextBox();
            this.lblAddFile = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeZipFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFTags = new System.Windows.Forms.TextBox();
            this.txtFDescription = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.chbFRaster = new System.Windows.Forms.CheckBox();
            this.chbFShape = new System.Windows.Forms.CheckBox();
            this.lblFTags = new System.Windows.Forms.Label();
            this.lblFDescription = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.sbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbxLogin.SuspendLayout();
            this.gbxAddFiles.SuspendLayout();
            this.msOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnCancel);
            this.gbxLogin.Controls.Add(this.btnUpload);
            this.gbxLogin.Controls.Add(this.password);
            this.gbxLogin.Controls.Add(this.username);
            this.gbxLogin.Controls.Add(this.passwort);
            this.gbxLogin.Controls.Add(this.benutzer);
            this.gbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogin.Location = new System.Drawing.Point(65, 454);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(416, 128);
            this.gbxLogin.TabIndex = 4;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "GDX-Login";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(320, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(320, 32);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(61, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(253, 26);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(61, 34);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(253, 26);
            this.username.TabIndex = 3;
            // 
            // passwort
            // 
            this.passwort.AutoSize = true;
            this.passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwort.Location = new System.Drawing.Point(7, 86);
            this.passwort.Name = "passwort";
            this.passwort.Size = new System.Drawing.Size(56, 13);
            this.passwort.TabIndex = 1;
            this.passwort.Text = "Password:";
            // 
            // benutzer
            // 
            this.benutzer.AutoSize = true;
            this.benutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzer.Location = new System.Drawing.Point(31, 42);
            this.benutzer.Name = "benutzer";
            this.benutzer.Size = new System.Drawing.Size(32, 13);
            this.benutzer.TabIndex = 0;
            this.benutzer.Text = "User:";
            // 
            // gbxAddFiles
            // 
            this.gbxAddFiles.Controls.Add(this.btnZip);
            this.gbxAddFiles.Controls.Add(this.lblFiles);
            this.gbxAddFiles.Controls.Add(this.lstFilePaths);
            this.gbxAddFiles.Controls.Add(this.btnRemoveFile);
            this.gbxAddFiles.Controls.Add(this.btnAddFile);
            this.gbxAddFiles.Controls.Add(this.btnBrowse);
            this.gbxAddFiles.Controls.Add(this.txtAddFile);
            this.gbxAddFiles.Controls.Add(this.lblAddFile);
            this.gbxAddFiles.Location = new System.Drawing.Point(65, 35);
            this.gbxAddFiles.Name = "gbxAddFiles";
            this.gbxAddFiles.Size = new System.Drawing.Size(416, 234);
            this.gbxAddFiles.TabIndex = 5;
            this.gbxAddFiles.TabStop = false;
            this.gbxAddFiles.Text = "Select Files for Upload";
            // 
            // btnZip
            // 
            this.btnZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnZip.Location = new System.Drawing.Point(320, 193);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 9;
            this.btnZip.Text = "Zip Now";
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(27, 60);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 6;
            this.lblFiles.Text = "Files:";
            // 
            // lstFilePaths
            // 
            this.lstFilePaths.FormattingEnabled = true;
            this.lstFilePaths.Location = new System.Drawing.Point(60, 56);
            this.lstFilePaths.Name = "lstFilePaths";
            this.lstFilePaths.Size = new System.Drawing.Size(254, 160);
            this.lstFilePaths.TabIndex = 5;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(320, 87);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFile.TabIndex = 4;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(320, 58);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 3;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(320, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAddFile
            // 
            this.txtAddFile.Location = new System.Drawing.Point(60, 30);
            this.txtAddFile.Name = "txtAddFile";
            this.txtAddFile.Size = new System.Drawing.Size(254, 20);
            this.txtAddFile.TabIndex = 1;
            // 
            // lblAddFile
            // 
            this.lblAddFile.AutoSize = true;
            this.lblAddFile.Location = new System.Drawing.Point(10, 33);
            this.lblAddFile.Name = "lblAddFile";
            this.lblAddFile.Size = new System.Drawing.Size(48, 13);
            this.lblAddFile.TabIndex = 0;
            this.lblAddFile.Text = "Add File:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // msOptions
            // 
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem});
            this.msOptions.Location = new System.Drawing.Point(0, 0);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(547, 24);
            this.msOptions.TabIndex = 6;
            this.msOptions.Text = "menuStrip1";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeZipFolderToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // changeZipFolderToolStripMenuItem
            // 
            this.changeZipFolderToolStripMenuItem.Name = "changeZipFolderToolStripMenuItem";
            this.changeZipFolderToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changeZipFolderToolStripMenuItem.Text = "Change Zip Folder";
            this.changeZipFolderToolStripMenuItem.Click += new System.EventHandler(this.changeZipFolderToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFTags);
            this.groupBox1.Controls.Add(this.txtFDescription);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.chbFRaster);
            this.groupBox1.Controls.Add(this.chbFShape);
            this.groupBox1.Controls.Add(this.lblFTags);
            this.groupBox1.Controls.Add(this.lblFDescription);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Location = new System.Drawing.Point(65, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Description";
            // 
            // txtFTags
            // 
            this.txtFTags.Location = new System.Drawing.Point(60, 87);
            this.txtFTags.Name = "txtFTags";
            this.txtFTags.Size = new System.Drawing.Size(254, 20);
            this.txtFTags.TabIndex = 7;
            // 
            // txtFDescription
            // 
            this.txtFDescription.Location = new System.Drawing.Point(61, 57);
            this.txtFDescription.Name = "txtFDescription";
            this.txtFDescription.Size = new System.Drawing.Size(253, 20);
            this.txtFDescription.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(61, 26);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(253, 20);
            this.txtFName.TabIndex = 5;
            // 
            // chbFRaster
            // 
            this.chbFRaster.AutoSize = true;
            this.chbFRaster.Location = new System.Drawing.Point(338, 90);
            this.chbFRaster.Name = "chbFRaster";
            this.chbFRaster.Size = new System.Drawing.Size(57, 17);
            this.chbFRaster.TabIndex = 4;
            this.chbFRaster.Text = "Raster";
            this.chbFRaster.UseVisualStyleBackColor = true;
            // 
            // chbFShape
            // 
            this.chbFShape.AutoSize = true;
            this.chbFShape.Location = new System.Drawing.Point(338, 66);
            this.chbFShape.Name = "chbFShape";
            this.chbFShape.Size = new System.Drawing.Size(57, 17);
            this.chbFShape.TabIndex = 3;
            this.chbFShape.Text = "Shape";
            this.chbFShape.UseVisualStyleBackColor = true;
            // 
            // lblFTags
            // 
            this.lblFTags.AutoSize = true;
            this.lblFTags.Location = new System.Drawing.Point(29, 87);
            this.lblFTags.Name = "lblFTags";
            this.lblFTags.Size = new System.Drawing.Size(34, 13);
            this.lblFTags.TabIndex = 2;
            this.lblFTags.Text = "Tags:";
            // 
            // lblFDescription
            // 
            this.lblFDescription.AutoSize = true;
            this.lblFDescription.Location = new System.Drawing.Point(0, 57);
            this.lblFDescription.Name = "lblFDescription";
            this.lblFDescription.Size = new System.Drawing.Size(63, 13);
            this.lblFDescription.TabIndex = 1;
            this.lblFDescription.Text = "Description:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(25, 26);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(38, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "Name:";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbProgressBar,
            this.sbLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 589);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(547, 22);
            this.statusBar.TabIndex = 8;
            this.statusBar.Text = "statusStrip1";
            // 
            // sbProgressBar
            // 
            this.sbProgressBar.Name = "sbProgressBar";
            this.sbProgressBar.Size = new System.Drawing.Size(100, 16);
            this.sbProgressBar.Visible = false;
            // 
            // sbLabel
            // 
            this.sbLabel.Name = "sbLabel";
            this.sbLabel.Size = new System.Drawing.Size(118, 17);
            this.sbLabel.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 611);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAddFiles);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.msOptions);
            this.MainMenuStrip = this.msOptions;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxAddFiles.ResumeLayout(false);
            this.gbxAddFiles.PerformLayout();
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label passwort;
        private System.Windows.Forms.Label benutzer;
        private System.Windows.Forms.GroupBox gbxAddFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ListBox lstFilePaths;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAddFile;
        private System.Windows.Forms.Label lblAddFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeZipFolderToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFTags;
        private System.Windows.Forms.TextBox txtFDescription;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.CheckBox chbFRaster;
        private System.Windows.Forms.CheckBox chbFShape;
        private System.Windows.Forms.Label lblFTags;
        private System.Windows.Forms.Label lblFDescription;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripProgressBar sbProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel;
    }
}