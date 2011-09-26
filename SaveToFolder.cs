using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDX
{
    public partial class SaveToFolder : Form
    {
        public SaveToFolder()
        {
            InitializeComponent();
        }

        public string TextImTextBoxAufForm2
        {
            get { return this.txtSaveTo.Text; }
            set { this.txtSaveTo.Text = value; }
        }

        private void btnSaveBrowse_Click(object sender, EventArgs e)
        {
            // clear the folder path
            txtSaveTo.Text = string.Empty;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSaveTo.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (txtSaveTo.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid path.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnWinTempPath_Click(object sender, EventArgs e)
        {
            string pathWithSlash = System.IO.Path.GetTempPath();
            txtSaveTo.Text = pathWithSlash.TrimEnd('\\');
        }





    }
}
