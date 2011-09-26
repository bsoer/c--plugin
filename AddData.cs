using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
using System.IO;

namespace GDX
{
    public partial class AddData : Form
    {
        public TextBox saveFolder = new TextBox();
        string PMPath = "";
        string filePath = "";
        string workingDir = "";
        string fpath = "";
        String sZipFileName;
        Form1 frm1 = new Form1();

        public string workingDirPUB
        {
            get { return workingDir; }
            set { workingDir = value; }
        }

        public string PMPathPUB
        {
            get { return PMPath; }
            set { PMPath = value; if(PMPath != string.Empty) lstFilePaths.Items.Add(PMPath); }
        }

        public string PUBfilePath
        {
            get { return filePath; }
            set { filePath = value;}
        }
       
        public string PUBfpath
        {
            get { return fpath; }
            set { fpath = value; }
        }
        

        public AddData()
        {
            InitializeComponent();
            
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // configure the open file dialog
            openFileDialog1.Title = "Add File";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            // return if the user cancels the operation
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            // set a local variable to contain the file name
            // captured from the open file dialog
            string sFilePath;
            sFilePath = openFileDialog1.FileName;
            if (sFilePath == "")
            {
                MessageBox.Show("Path is empty", "Error");
                return;
            }

            // make sure the file exists before adding 
            // its path to the list of files to be
            // compressed
            if (System.IO.File.Exists(sFilePath) == false)
            {
                MessageBox.Show("System.IO.File.Exists(sFilePath) == false", "Fehler");
                return;
            }
            else
            {
                txtAddFile.Text = sFilePath;
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            
            // Check for content in the text box
            if (txtAddFile.Text == string.Empty)
            {
                MessageBox.Show("Use the browse button to search for " +
                "the file to be added.", "Missing File Name");
                return;
            }

            // Only allow the file to be added if the file is not a duplicate
            for (int i = 0; i < lstFilePaths.Items.Count; i++)
            {
                if (lstFilePaths.Items[i].ToString() == txtAddFile.Text.ToString())
                {
                    MessageBox.Show("That file has already been added to the list.",
                        "Duplicate");
                    return;
                }
            }

            // Add the file to the listbox list
            if (txtAddFile.Text != string.Empty)
                lstFilePaths.Items.Add(txtAddFile.Text.ToString());

            // clear the textbox and move the focus back to the textbox
            txtAddFile.Text = string.Empty;
            txtAddFile.Focus();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            try
            {
                lstFilePaths.Items.Remove(lstFilePaths.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            // make sure there are files to zip
            if (lstFilePaths.Items.Count < 1)
            {
                MessageBox.Show("There are no files queued for the zip operation", "Empty File Set");
                return;
            }

            // make sure there is a destination defined
            if (workingDir == string.Empty)
            {
                saveFolder.Text = frm1.createGDXTempFolder();
            }
            else // change temp zip path
            {
                saveFolder.Text = workingDir;
            }

            saveFolder.Refresh();
            // name the zip file whatever the folder is named
            // by splitting the file path to get the folder name
            string[] sTemp = saveFolder.Text.Split('\\');
            sZipFileName = sTemp[sTemp.Length - 1].ToString();

            // check to see if zipped file already exists
            // user may rename it in the text box if it does.
            FileInfo fi = new FileInfo(saveFolder.Text + "\\" + sZipFileName + ".zip");
            
            if (fi.Exists)
            {
                // move it to the folder
                MessageBox.Show("The file " + sZipFileName + ".zip already exists in " + saveFolder.Text + "\\. \n" +
                                    "The File will be overwritten.");
            }

            // Check for the existence of the target folder and
            // create it if it does not exist
            if (!System.IO.Directory.Exists(saveFolder.Text + "\\TempZipFile\\"))
            {
                System.IO.Directory.CreateDirectory(saveFolder.Text + "\\TempZipFile\\");
            }

            // Set up a string to hold the path to the temp folder
            string sTargetFolderPath = (saveFolder.Text + "\\TempZipFile\\");

            // Process the files and move each into the target folder
            for (int i = 0; i < lstFilePaths.Items.Count; i++)
            {
                string filePath = lstFilePaths.Items[i].ToString();
                FileInfo fi2 = new FileInfo(filePath);
                if (fi2.Exists)
                {
                    // move it to the folder
                    try
                    {
                        fi2.CopyTo(sTargetFolderPath + fi2.Name, true);
                    }
                    catch
                    {
                        // clean up if the operation failed
                        System.IO.Directory.Delete(sTargetFolderPath);
                        MessageBox.Show("Could not copy files to temp folder.", "File Error");
                        return;
                    }
                }
            }

            // zip up the files
            try
            {
                //TODO graphical bug in uw while zipping
                UploadWait uw = new UploadWait();
                uw.Show();
                uw.lblUploadWait.Text = "Zipping files...";

                string[] filenames = Directory.GetFiles(sTargetFolderPath);

                // Zip up the files - From SharpZipLib Demo Code
                using (ZipOutputStream s = new ZipOutputStream(File.Create(saveFolder.Text + "\\" + sZipFileName + ".zip")))
                {
                    s.SetLevel(9); // 0-9, 9 being the highest level of compression
                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {
                        //frm1.sbProgressBar.PerformStep();
                        //machen
                        ICSharpCode.SharpZipLib.Zip.ZipEntry entry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(Path.GetFileName(file));
                        entry.DateTime = DateTime.Now;
                        s.PutNextEntry(entry);

                        using (System.IO.FileStream fs = File.OpenRead(file))
                        {
                            int sourceBytes;
                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                s.Write(buffer, 0, sourceBytes);

                            } while (sourceBytes > 0);
                        }
                    }
                    s.Finish();
                    s.Close();
                }

                uw.lblUploadWait.Visible = false;
                uw.lblUploadRes.Text = "Files have been zipped.";
                uw.lblUploadRes.Visible = true;
                uw.prbUpload.Style = ProgressBarStyle.Continuous;
                uw.prbUpload.Value = 100;
                uw.btnCancel.Visible = false;
                uw.btnOk.Visible = true;

                // clean up files by deleting the temp folder and its content
                System.IO.Directory.Delete(saveFolder.Text + "\\TempZipFile\\", true);

                fpath = saveFolder.Text + "\\" + sZipFileName + ".zip";
                filePath = sZipFileName + ".zip";

                // empty everything
                lstFilePaths.Items.Clear();
                txtAddFile.Text = string.Empty;
                saveFolder.Text = string.Empty;
                workingDir = string.Empty;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Zip Operation Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
