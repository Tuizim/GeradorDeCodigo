using CodGeneretor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceWebConfig
{
    public partial class Form1 : Form
    {
        public static string[] foundWebConfigs;
        public static string folderSelectedPath;
        public static string[] folderFiles;
        public Form1()
        {
            InitializeComponent();
            strtBTN.Enabled = false;
        }

        private void SelectFileBTN_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    WebConfigFoldsSelect.Items.Clear();
                    WebConfigSelect.Items.Clear();
                    ProjectPath.Text = fbd.SelectedPath;
                    foundWebConfigs = Generator.List_ProjectWebConfig(fbd.SelectedPath);
                    List<string> foldNames = Generator.GetName_Folder(foundWebConfigs);
                    foreach (string name in foldNames)
                    {
                        WebConfigFoldsSelect.Items.Add(name);
                    }
                }
            }

        }

        private void SelectFilePathtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void WebConfigFoldsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebConfigSelect.Items.Clear();
            if (WebConfigFoldsSelect.SelectedIndex >= 0)
            {
                folderSelectedPath = foundWebConfigs[WebConfigFoldsSelect.SelectedIndex];
                folderFiles = Generator.List_FolderWebConfigs(Path.GetDirectoryName(folderSelectedPath));
                List<string> docNamesInPath = Generator.GetName_DocumentsInFolder(folderFiles);
                foreach (var name in docNamesInPath)
                {
                    WebConfigSelect.Items.Add(name);
                }
            }
        }

        private void strtBTN_Click(object sender, EventArgs e)
        {
            if (WebConfigSelect.SelectedIndex >= 0)
            {
                string webConfigNewPath = folderFiles[WebConfigSelect.SelectedIndex];
                if (File.Exists(folderSelectedPath) && File.Exists(webConfigNewPath))
                {
                    Generator.OverrideWebconfigAndSave(pathOriginalWebConfig: folderSelectedPath, pathWebConfigBase: webConfigNewPath);
                    MessageBox.Show("Finalizado");
                }
                else{
                    MessageBox.Show("Houve um problema com o diretorio do seu arquivo, tente novamente.");
                }
            }
        }

        private void WebConfigSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WebConfigSelect.SelectedIndex >= 0)
            {

                strtBTN.Enabled = true;
            }
        }

        private void clnBTN_Click(object sender, EventArgs e)
        {
            ProjectPath.Text = null;
            WebConfigFoldsSelect.Items.Clear();
            WebConfigSelect.Items.Clear();
            strtBTN.Enabled = false;
        }
    }
}
