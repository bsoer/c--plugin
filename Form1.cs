using ESRI.ArcGIS.Carto;
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
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.CatalogUI;
using ESRI.ArcGIS.Display;

namespace GDX
{
    public partial class Form1 : Form
    {
        public string fpath_file = string.Empty;
        public String PMPath = string.Empty;
        public string workingDir = string.Empty;
                

        public Form1()
        {
            InitializeComponent();
            sbLabel.Text = "Select Files for Upload.";
        }

        public string txbFilenamePUB
        {
            get { return this.txbFilename.Text; }
            set { this.txbFilename.Text = value; }
        }

        private void frm_Closed_SaveToFolder(object sender, EventArgs e)
        {
            SaveToFolder frm = sender as SaveToFolder;
            if (frm != null)
            {
                if (frm.DialogResult == DialogResult.OK)
                {
                    workingDir = frm.TextImTextBoxAufForm2;
                }
                frm.Closed -= new EventHandler(frm_Closed_SaveToFolder);
            }
        }

        private void frm_Closed_AddData(object sender, EventArgs e)
        {
            AddData frm = sender as AddData;
            if (frm != null)
            {
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.txbFilename.Text = frm.PUBfilePath;
                    this.fpath_file = frm.PUBfpath;
                }
                frm.Closed -= new EventHandler(frm_Closed_AddData);
            }
        }

        public string createGDXTempFolder()
        {
            if (workingDir == string.Empty)
            {
                // Windows Default Temp Dir Path
                // current time (used for new Temp folder name)
                workingDir = System.IO.Path.GetTempPath() + "GDX" + string.Format("-{0:yyyy-MM-dd_HH-mm-ss-ffff}", DateTime.Now);
            }

            // Check for the existence of the new working directory
            if (Directory.Exists(workingDir))
            {
                MessageBox.Show("Directory " + workingDir + " already exists. \n" +
                                    "Choose another folder to save the file. (Options Menu)");
                sbLabel.Text = "Choose another folder to save the file. (Options Menu)";
                return "";
            }
            else
            {
                System.IO.Directory.CreateDirectory(workingDir);
                //TODO temp folder deletion necessary?
                //MessageBox.Show("Sub temp folder " + workingDir + " created");
                return workingDir;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (fpath_file == string.Empty)
            {
                MessageBox.Show("Please select a file to upload.");
                return;
            }
            if(txtFName.Text == string.Empty || txtFDescription.Text == string.Empty || txtFTags.Text == string.Empty)
            {
                MessageBox.Show("Please enter filename, description and tags");
                return;
            }
            if(username.Text == string.Empty || password.Text == string.Empty)
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            
            sbProgressBar.Visible = true;
            sbLabel.Text = "Uploading, please wait ... ";

            UploadWait uw = new UploadWait();
            uw.Show();
            //TODO save Username
            NameValueCollection fields = new NameValueCollection();
            fields.Add("upload[name]", txtFName.Text);
            fields.Add("upload[description]", txtFDescription.Text);
            fields.Add("upload[tag_list]", txtFTags.Text);
            fields.Add("upload[contains_vector_data]", chbFRaster.CheckState.GetHashCode().ToString()); //changed with raster_data
            fields.Add("upload[contains_raster_data]", chbFVector.CheckState.GetHashCode().ToString());
            KeyValuePair<string, string> credentials = new KeyValuePair<string, string>(username.Text, password.Text);

            //start upload
            String result = UploadClass.upload(fields, fpath_file, credentials);

            //display results
            uw.Show();
            uw.lblUploadWait.Visible = false;
            uw.lblUploadRes.Text = result;
            uw.lblUploadRes.Visible = true;
            uw.prbUpload.Style = ProgressBarStyle.Continuous;
            uw.prbUpload.Value = 100;
            uw.btnCancel.Visible = false;
            uw.btnOk.Visible = true;
            
            //MessageBox.Show(result);
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
            //frm.TextImTextBoxAufForm2 = this.textBox1.Text;
            frm.Closed += new EventHandler(frm_Closed_SaveToFolder);
            frm.Show();
        }

        private void gDXHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://46.252.21.47/");
        }

        public void btnCreate_auto_Click(object sender, EventArgs e)
        {
            UploadWait uw = new UploadWait();
            try
            {
                // Initialize the geoprocessor. 
                Geoprocessor GP = new Geoprocessor();
                GP.OverwriteOutput = true;
                sbLabel.Text = "Creating Map Package... ";
                uw.lblUploadWait.Text = "Creating Map Package...";
                uw.Show();

                if (workingDir == string.Empty)
                {
                    workingDir = createGDXTempFolder();
                }

                // The active document is always the last template
                ITemplates templates = ArcMap.Application.Templates;
                string mxdPath = templates.get_Item(templates.Count - 1);
                
                ESRI.ArcGIS.DataManagementTools.PackageMap createPM = new ESRI.ArcGIS.DataManagementTools.PackageMap();
                createPM.in_map = mxdPath;
                createPM.output_file = workingDir + "\\" + Path.GetFileNameWithoutExtension(mxdPath) + ".mpk";
                GP.Execute(createPM, null);

                PMPath = workingDir + "\\" + Path.GetFileNameWithoutExtension(mxdPath) + ".mpk";
                txbFilename.Text = Path.GetFileNameWithoutExtension(mxdPath) + ".mpk";
                fpath_file = PMPath;

                uw.lblUploadWait.Visible = false;
                uw.lblUploadRes.Text = "Map Package successfully created.";
                uw.lblUploadRes.Visible = true;
                uw.prbUpload.Style = ProgressBarStyle.Continuous;
                uw.prbUpload.Value = 100;
                uw.btnCancel.Visible = false;
                uw.btnOk.Visible = true;

                sbLabel.Text = "Map Package successfully created. ";

                //Workaround for background problem, but flickering
                //TODO
                this.Activate();
                uw.Activate();

                //this.BringToFront();
                //uw.BringToFront();
            }
            catch
            {
                //MessageBox.Show("Python-Error (" + GP.GetReturnCode(0) + "), try to create the map package manually (option menu)");uw.Close();
                uw.Close();
                MessageBox.Show("Please enter a description for the document. \n (File -> Map Document Properties -> Description)");
                return;
            }
        }

        private void packageMapCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string envDir = Environment.CurrentDirectory;
            //string projDir = System.IO.Directory.GetCurrentDirectory();
            //MessageBox.Show("ProjDir: " + projDir);
            //MessageBox.Show("LastDir: " + lastDir);
            try
            {
                //Start MapPackage Export
                UID atOpenID = new UID();
                atOpenID.Value = "{71CB784E-4F2D-4BE5-A20F-8C400F714B8B}";
                ICommandItem atCommand = ArcMap.Application.Document.CommandBars.Find(atOpenID, false, false);
                atCommand.Execute();
            }
            catch
            {
                MessageBox.Show("Error: Python (manually)");
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void anleitungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hfrm = new HelpForm();
            hfrm.Activate();
            Help.ShowHelp(hfrm, "Addins\\GDX.chm", HelpNavigator.TableOfContents);
            //TODO focus bug (sometimes)
        }

        private void btnAddOtherFiles_Click(object sender, EventArgs e)
        {
            AddData addOtherFiles = new AddData();
            addOtherFiles.PMPathPUB = PMPath;
            addOtherFiles.workingDirPUB = workingDir;
            addOtherFiles.Closed += new EventHandler(frm_Closed_AddData);
            addOtherFiles.Show();

            sbLabel.Text = "Please enter the filename, description, tags and data type.";
       }
    }
}
