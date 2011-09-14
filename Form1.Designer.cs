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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passwort = new System.Windows.Forms.Label();
            this.benutzer = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.msOptions = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gDXHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeZipFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageMapCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anleitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddOtherFiles = new System.Windows.Forms.Button();
            this.txbFilename = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.txtFTags = new System.Windows.Forms.TextBox();
            this.txtFDescription = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.chbFRaster = new System.Windows.Forms.CheckBox();
            this.chbFVector = new System.Windows.Forms.CheckBox();
            this.lblFTags = new System.Windows.Forms.Label();
            this.lblFDescription = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.sbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreate_auto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxLogin.SuspendLayout();
            this.msOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gbxLogin.Location = new System.Drawing.Point(12, 291);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(449, 128);
            this.gbxLogin.TabIndex = 4;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "GDX-Login";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(349, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(349, 31);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(87, 23);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(81, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(257, 20);
            this.password.TabIndex = 15;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(81, 34);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(257, 20);
            this.username.TabIndex = 13;
            // 
            // passwort
            // 
            this.passwort.AutoSize = true;
            this.passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwort.Location = new System.Drawing.Point(16, 80);
            this.passwort.Name = "passwort";
            this.passwort.Size = new System.Drawing.Size(56, 13);
            this.passwort.TabIndex = 1;
            this.passwort.Text = "Password:";
            // 
            // benutzer
            // 
            this.benutzer.AutoSize = true;
            this.benutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benutzer.Location = new System.Drawing.Point(40, 36);
            this.benutzer.Name = "benutzer";
            this.benutzer.Size = new System.Drawing.Size(32, 13);
            this.benutzer.TabIndex = 0;
            this.benutzer.Text = "User:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // msOptions
            // 
            this.msOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.msOptions.Location = new System.Drawing.Point(0, 0);
            this.msOptions.Name = "msOptions";
            this.msOptions.Size = new System.Drawing.Size(473, 24);
            this.msOptions.TabIndex = 6;
            this.msOptions.Text = "menuStrip1";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gDXHomepageToolStripMenuItem,
            this.changeZipFolderToolStripMenuItem,
            this.packageMapCreatorToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionenToolStripMenuItem.Text = "Options";
            // 
            // gDXHomepageToolStripMenuItem
            // 
            this.gDXHomepageToolStripMenuItem.Name = "gDXHomepageToolStripMenuItem";
            this.gDXHomepageToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gDXHomepageToolStripMenuItem.Text = "GDX Homepage";
            this.gDXHomepageToolStripMenuItem.Click += new System.EventHandler(this.gDXHomepageToolStripMenuItem_Click);
            // 
            // changeZipFolderToolStripMenuItem
            // 
            this.changeZipFolderToolStripMenuItem.Name = "changeZipFolderToolStripMenuItem";
            this.changeZipFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.changeZipFolderToolStripMenuItem.Text = "Change Zip Folder";
            this.changeZipFolderToolStripMenuItem.Click += new System.EventHandler(this.changeZipFolderToolStripMenuItem_Click_1);
            // 
            // packageMapCreatorToolStripMenuItem
            // 
            this.packageMapCreatorToolStripMenuItem.Name = "packageMapCreatorToolStripMenuItem";
            this.packageMapCreatorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.packageMapCreatorToolStripMenuItem.Text = "Package Map Creator";
            this.packageMapCreatorToolStripMenuItem.Click += new System.EventHandler(this.packageMapCreatorToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anleitungToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Help";
            // 
            // anleitungToolStripMenuItem
            // 
            this.anleitungToolStripMenuItem.Name = "anleitungToolStripMenuItem";
            this.anleitungToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.anleitungToolStripMenuItem.Text = "manual";
            this.anleitungToolStripMenuItem.Click += new System.EventHandler(this.anleitungToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddOtherFiles);
            this.groupBox1.Controls.Add(this.txbFilename);
            this.groupBox1.Controls.Add(this.lblFile);
            this.groupBox1.Controls.Add(this.lblDataType);
            this.groupBox1.Controls.Add(this.txtFTags);
            this.groupBox1.Controls.Add(this.txtFDescription);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.chbFRaster);
            this.groupBox1.Controls.Add(this.chbFVector);
            this.groupBox1.Controls.Add(this.lblFTags);
            this.groupBox1.Controls.Add(this.lblFDescription);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Description";
            // 
            // btnAddOtherFiles
            // 
            this.btnAddOtherFiles.Location = new System.Drawing.Point(349, 30);
            this.btnAddOtherFiles.Name = "btnAddOtherFiles";
            this.btnAddOtherFiles.Size = new System.Drawing.Size(87, 23);
            this.btnAddOtherFiles.TabIndex = 13;
            this.btnAddOtherFiles.Text = "Add other files";
            this.btnAddOtherFiles.UseVisualStyleBackColor = true;
            this.btnAddOtherFiles.Click += new System.EventHandler(this.btnAddOtherFiles_Click);
            // 
            // txbFilename
            // 
            this.txbFilename.Location = new System.Drawing.Point(81, 30);
            this.txbFilename.Name = "txbFilename";
            this.txbFilename.ReadOnly = true;
            this.txbFilename.Size = new System.Drawing.Size(257, 20);
            this.txbFilename.TabIndex = 8;
            this.txbFilename.TabStop = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(37, 30);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(26, 13);
            this.lblFile.TabIndex = 9;
            this.lblFile.Text = "File:";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(13, 158);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(60, 13);
            this.lblDataType.TabIndex = 8;
            this.lblDataType.Text = "Data Type:";
            // 
            // txtFTags
            // 
            this.txtFTags.Location = new System.Drawing.Point(80, 127);
            this.txtFTags.Name = "txtFTags";
            this.txtFTags.Size = new System.Drawing.Size(258, 20);
            this.txtFTags.TabIndex = 10;
            // 
            // txtFDescription
            // 
            this.txtFDescription.Location = new System.Drawing.Point(81, 97);
            this.txtFDescription.Name = "txtFDescription";
            this.txtFDescription.Size = new System.Drawing.Size(257, 20);
            this.txtFDescription.TabIndex = 9;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(81, 66);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(257, 20);
            this.txtFName.TabIndex = 8;
            // 
            // chbFRaster
            // 
            this.chbFRaster.AutoSize = true;
            this.chbFRaster.Location = new System.Drawing.Point(143, 158);
            this.chbFRaster.Name = "chbFRaster";
            this.chbFRaster.Size = new System.Drawing.Size(57, 17);
            this.chbFRaster.TabIndex = 12;
            this.chbFRaster.Text = "Raster";
            this.chbFRaster.UseVisualStyleBackColor = true;
            // 
            // chbFVector
            // 
            this.chbFVector.AutoSize = true;
            this.chbFVector.Location = new System.Drawing.Point(80, 157);
            this.chbFVector.Name = "chbFVector";
            this.chbFVector.Size = new System.Drawing.Size(57, 17);
            this.chbFVector.TabIndex = 11;
            this.chbFVector.Text = "Vector";
            this.chbFVector.UseVisualStyleBackColor = true;
            // 
            // lblFTags
            // 
            this.lblFTags.AutoSize = true;
            this.lblFTags.Location = new System.Drawing.Point(39, 127);
            this.lblFTags.Name = "lblFTags";
            this.lblFTags.Size = new System.Drawing.Size(34, 13);
            this.lblFTags.TabIndex = 2;
            this.lblFTags.Text = "Tags:";
            // 
            // lblFDescription
            // 
            this.lblFDescription.AutoSize = true;
            this.lblFDescription.Location = new System.Drawing.Point(10, 97);
            this.lblFDescription.Name = "lblFDescription";
            this.lblFDescription.Size = new System.Drawing.Size(63, 13);
            this.lblFDescription.TabIndex = 1;
            this.lblFDescription.Text = "Description:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(35, 69);
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
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(473, 22);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreate_auto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map Package";
            // 
            // btnCreate_auto
            // 
            this.btnCreate_auto.Location = new System.Drawing.Point(349, 14);
            this.btnCreate_auto.Name = "btnCreate_auto";
            this.btnCreate_auto.Size = new System.Drawing.Size(87, 23);
            this.btnCreate_auto.TabIndex = 13;
            this.btnCreate_auto.Text = "Create";
            this.btnCreate_auto.UseVisualStyleBackColor = true;
            this.btnCreate_auto.Click += new System.EventHandler(this.btnCreate_auto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Create Map Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Create Map Package";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.msOptions);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msOptions;
            this.Name = "Form1";
            this.Text = "GDX";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.msOptions.ResumeLayout(false);
            this.msOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label passwort;
        private System.Windows.Forms.Label benutzer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.MenuStrip msOptions;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeZipFolderToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFTags;
        private System.Windows.Forms.TextBox txtFDescription;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.CheckBox chbFRaster;
        private System.Windows.Forms.CheckBox chbFVector;
        private System.Windows.Forms.Label lblFTags;
        private System.Windows.Forms.Label lblFDescription;
        private System.Windows.Forms.Label lblFName;
        public System.Windows.Forms.StatusStrip statusBar;
        public System.Windows.Forms.ToolStripProgressBar sbProgressBar;
        public System.Windows.Forms.ToolStripStatusLabel sbLabel;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem gDXHomepageToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFile;
        public System.Windows.Forms.TextBox txbFilename;
        private System.Windows.Forms.Button btnCreate_auto;
        private System.Windows.Forms.ToolStripMenuItem packageMapCreatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anleitungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnAddOtherFiles;
    }
}