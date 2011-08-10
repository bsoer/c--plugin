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
            DialogResult = DialogResult.OK;
            Form1.saveFolder.Text = txtSaveTo.Text;
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
