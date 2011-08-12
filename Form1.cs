﻿using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ArcMapUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Management;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
using System.Net;
using System.Collections.Specialized;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using System.Collections;

//using IronPython.Hosting;
//using Microsoft.Scripting.Hosting;

namespace GDX
{
    public partial class Form1 : Form
    {
        String fpath_file;
        String sZipFileName;
        public static TextBox saveFolder = new TextBox();


        public Form1()
        {
            InitializeComponent();
            sbLabel.Text = "Select Files for Upload.";
        }

        private void ok_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Zip file " + sZipFileName + ".zip" + " was sent.");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // configure the open file dialog
            openFileDialog1.Title = "Add File";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FileName = "";

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
                MessageBox.Show("sFilePath == leer", "Fehler");
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
            if (saveFolder.Text == string.Empty)
            {
                // Windows Default Temp Dir Path
                string tempPath = System.IO.Path.GetTempPath();
                //MessageBox.Show("Windows Temp Path = " + tempPath);

                // current time (used for new Temp folder name)
                String workingDir = tempPath + "GDX" + string.Format("-{0:yyyy-MM-dd_hh-mm-ss-ffff}", DateTime.Now);
                //MessageBox.Show("WorkingDir: " + workingDir);

                // Check for the existence of the new working directory
                if (Directory.Exists(workingDir))
                {
                    try
                    {
                        MessageBox.Show("Directory " + workingDir + " already exists. \n" +
                                            "Choose another folder to save the file. (Options Menu)");
                        sbLabel.Text = "Choose another folder to save the file. (Options Menu)";
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Rename the file or select a new location.");
                        return;
                    }
                }
                else
                {
                    System.IO.Directory.CreateDirectory(workingDir);
                    //MessageBox.Show("Sub temp folder " + workingDir + " created");
                }
                saveFolder.Text = workingDir;
                workingDir = string.Empty;
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
                try
                {
                    MessageBox.Show("The file " + sZipFileName + ".zip already exists in " + saveFolder.Text + "\\. \n" +
                                        "Choose another folder to save the file. (Options Menu)");
                    sbLabel.Text = "Choose another Folder to save the file. (Options Menu)";
                    return;
                }
                catch
                {
                    MessageBox.Show("Rename the file or select a new location.");
                    return;
                }
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
                sbProgressBar.Visible = true;
                sbLabel.Text = "Zipping files, please wait ...";
                statusBar.Refresh();

                string[] filenames = Directory.GetFiles(sTargetFolderPath);

                // Zip up the files - From SharpZipLib Demo Code
                using (ZipOutputStream s = new ZipOutputStream(File.Create(saveFolder.Text + "\\" + sZipFileName + ".zip")))
                {
                    s.SetLevel(9); // 0-9, 9 being the highest level of compression
                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {
                        sbProgressBar.PerformStep();
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

                // remove the progress bar + change lable
                sbProgressBar.Visible = false;
                sbLabel.Text = "Files have been zipped. Zip file " + fpath_file + "created.";

                // clean up files by deleting the temp folder and its content
                System.IO.Directory.Delete(saveFolder.Text + "\\TempZipFile\\", true);

                // Notify user
                fpath_file = saveFolder.Text + "\\" + sZipFileName + ".zip";
                //MessageBox.Show("Zip file " + fpath_file + " created.");
                txbFilename.Text = sZipFileName + ".zip";

                // empty everything
                lstFilePaths.Items.Clear();
                txtAddFile.Text = string.Empty;
                saveFolder.Text = string.Empty;
                //MessageBox.Show("Zipfilename: ", sZipFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Zip Operation Error");
                sbLabel.Text = "Zip Operation Error";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            sbProgressBar.Visible = true;
            sbLabel.Text = "Uploading, please wait ... ";

            NameValueCollection fields = new NameValueCollection();
            fields.Add("upload[name]", txtFName.Text);
            fields.Add("upload[description]", txtFDescription.Text);
            fields.Add("upload[tag_list]", txtFTags.Text);
            KeyValuePair<string, string> credentials = new KeyValuePair<string, string>(username.Text, password.Text);

            //start upload
            // TODO add "Data Type" (Shape/Raster)
            String result = UploadClass.upload(fields, fpath_file, credentials);

            //display result
            MessageBox.Show(result);
            sbProgressBar.Visible = false;
            sbLabel.Text = result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeZipFolderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveToFolder frm = new SaveToFolder();
            frm.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // save your current directory  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string envDir = Environment.CurrentDirectory;
            string projDir = System.IO.Directory.GetCurrentDirectory();
            string lastDir = openFileDialog.InitialDirectory;
            openFileDialog.RestoreDirectory = true;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            
            saveFileDialog.InitialDirectory = "C:\\";
            
            //MessageBox.Show("ProjDir: " + projDir);
            //MessageBox.Show("LastDir: " + lastDir);
            //MessageBox.Show("lastDirs: " + lastDirs);
            

            try
            {
                // Warning: Do not change the default export folder for mpk
                //Start MapPackage Export
                UID atOpenID = new UID();
                atOpenID.Value = "{71CB784E-4F2D-4BE5-A20F-8C400F714B8B}";
                ICommandItem atCommand = ArcMap.Application.Document.CommandBars.Find(atOpenID, false, false);
                //atCommand.Reset();
                atCommand.Execute();
            }
            catch
            {
                MessageBox.Show("Error: Python (manually)");
                return;
            }

            //Test
            projDir = System.IO.Directory.GetCurrentDirectory();
            lastDir = openFileDialog.InitialDirectory;
            envDir = Environment.CurrentDirectory;

            //MessageBox.Show("ProjDir2: " + projDir);
            //MessageBox.Show("LastDi2r: " + lastDir);
            //MessageBox.Show("lastDirs: " + lastDirs);
            //string projDir = System.IO.Directory.SetCurrentDirectory(System.IO.Directory.GetCurrentDirectory());
        }

        private void gDXHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://46.252.21.47/");
        }

        private void automaticallyCreateMpkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO all :-)
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                Process py = new Process();
                //MessageBox.Show("EnvVars: " + getEnv());
                py.StartInfo.FileName = "C:\\Python26\\ArcGIS10.0\\pythonw.exe";
                //py.StartInfo.Arguments = "C:\\Users\\bsoer\\Documents\\Visual Studio 2010\\Projects\\GDX\\GDX\\bin\\Debug\\mpc.py";
                py.StartInfo.Arguments = "C:/Users/bsoer/Desktop/mpc.py";
                py.StartInfo.UseShellExecute = false;
                py.StartInfo.CreateNoWindow = true;
                py.StartInfo.RedirectStandardOutput = true;
                // py.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                py.Start();
                py.BeginOutputReadLine();
                py.WaitForExit();
                py.Close();
            }
            catch
            {
                MessageBox.Show("Error: Python (auto)");
                return;
            }
        }

        private string getEnv()
        {
            StringBuilder SB = new StringBuilder();
            IDictionary Dic = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in Dic)
            {
                SB.Append(de.Key);
                SB.Append(": ");
                SB.Append(de.Value);
                SB.Append(Environment.NewLine);
            }
            return SB.ToString();
        }
    }
}
