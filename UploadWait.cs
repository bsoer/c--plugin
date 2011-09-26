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
    public partial class UploadWait : Form
    {
        public UploadWait()
        {
            InitializeComponent();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            // TODO cancel uploading progress
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
