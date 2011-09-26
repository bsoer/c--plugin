namespace GDX
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPhilipp = new System.Windows.Forms.Label();
            this.lblMagnus = new System.Windows.Forms.Label();
            this.lblMoritz = new System.Windows.Forms.Label();
            this.lblMailPh = new System.Windows.Forms.Label();
            this.lblMailMag = new System.Windows.Forms.Label();
            this.lblMailMor = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(117, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPhilipp
            // 
            this.lblPhilipp.AutoSize = true;
            this.lblPhilipp.Location = new System.Drawing.Point(11, 77);
            this.lblPhilipp.Name = "lblPhilipp";
            this.lblPhilipp.Size = new System.Drawing.Size(67, 13);
            this.lblPhilipp.TabIndex = 1;
            this.lblPhilipp.Text = "Philipp Rhan";
            // 
            // lblMagnus
            // 
            this.lblMagnus.AutoSize = true;
            this.lblMagnus.Location = new System.Drawing.Point(11, 98);
            this.lblMagnus.Name = "lblMagnus";
            this.lblMagnus.Size = new System.Drawing.Size(76, 13);
            this.lblMagnus.TabIndex = 2;
            this.lblMagnus.Text = "Magnus Müller";
            // 
            // lblMoritz
            // 
            this.lblMoritz.AutoSize = true;
            this.lblMoritz.Location = new System.Drawing.Point(11, 119);
            this.lblMoritz.Name = "lblMoritz";
            this.lblMoritz.Size = new System.Drawing.Size(86, 13);
            this.lblMoritz.TabIndex = 3;
            this.lblMoritz.Text = "Moritz Borgmann";
            // 
            // lblMailPh
            // 
            this.lblMailPh.AutoSize = true;
            this.lblMailPh.Location = new System.Drawing.Point(155, 77);
            this.lblMailPh.Name = "lblMailPh";
            this.lblMailPh.Size = new System.Drawing.Size(142, 13);
            this.lblMailPh.TabIndex = 4;
            this.lblMailPh.Text = "rhan@informatik.hu-berlin.de";
            // 
            // lblMailMag
            // 
            this.lblMailMag.AutoSize = true;
            this.lblMailMag.Location = new System.Drawing.Point(130, 98);
            this.lblMailMag.Name = "lblMailMag";
            this.lblMailMag.Size = new System.Drawing.Size(165, 13);
            this.lblMailMag.TabIndex = 5;
            this.lblMailMag.Text = "mamuelle@informatik.hu-berlin.de";
            // 
            // lblMailMor
            // 
            this.lblMailMor.AutoSize = true;
            this.lblMailMor.Location = new System.Drawing.Point(128, 119);
            this.lblMailMor.Name = "lblMailMor";
            this.lblMailMor.Size = new System.Drawing.Size(168, 13);
            this.lblMailMor.TabIndex = 6;
            this.lblMailMor.Text = "borgmann@informatik.hu-berlin.de";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(117, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 188);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMailMor);
            this.Controls.Add(this.lblMailPh);
            this.Controls.Add(this.lblMailMag);
            this.Controls.Add(this.lblMoritz);
            this.Controls.Add(this.lblMagnus);
            this.Controls.Add(this.lblPhilipp);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPhilipp;
        private System.Windows.Forms.Label lblMagnus;
        private System.Windows.Forms.Label lblMoritz;
        private System.Windows.Forms.Label lblMailPh;
        private System.Windows.Forms.Label lblMailMag;
        private System.Windows.Forms.Label lblMailMor;
        private System.Windows.Forms.Button btnOk;
    }
}