using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Name_Cleaner
{
    public partial class frmFileNameCleaner : Form
    {
        public frmFileNameCleaner()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            FetchFiles(txtPath.Text);
        }
        public void FetchFiles(string targetDirectory) 
        {
            try
            {
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                string[] subEntries = Directory.GetDirectories(targetDirectory);
                foreach (string fileName in fileEntries)
                {
                    lstFiles.Items.Add(fileName);
                }
                foreach (string subDir in subEntries)
                {
                    FetchFiles(subDir);
                }
            }
            catch
            { }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            int countInst = 0;
            string[] filter = txtFilter.Text.Split(';');
            foreach (string item in lstFiles.Items)
            { 
                string origName = item.Substring(item.LastIndexOf('\\') + 1);
                string newName =null;
                foreach (string filterWord in filter)
                {
                    if (item.Contains(filterWord))
                    {
                        newName = origName.Replace(filterWord, "");
                        countInst++;
                    }
                }
                try { File.Move(item, item.Replace(origName, newName)); }
                catch { }
             
            }
            lstFiles.Items.Clear();
            FetchFiles(txtPath.Text);
            MessageBox.Show("Done.\nReplaced " + countInst + " instances.");
        }


        
    }
}
