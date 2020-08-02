using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Rclone_Update
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            iniciar_variaveis();
        }
        void iniciar_variaveis()
        {
            //nuvem
            string[] text = System.IO.File.ReadAllLines(@"rclone\config\.nuvem.dat");
            foreach (string texto in text)
            {

                Console.WriteLine("\t" + texto);
                boxname.Items.Add(texto);
            }
            
            //nuvem
            string[] upload = System.IO.File.ReadAllLines(@"rclone\config\.upload.dat");
            foreach (string texto in upload)
            {

                Console.WriteLine("\t" + texto);
                folder_nuvem_upload.Items.Add(texto);
            }
           
        }




        // Buttons
        private void uploadbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog upload_folder = new FolderBrowserDialog();
            upload_folder.RootFolder = Environment.SpecialFolder.Desktop;
            upload_folder.Description = "Selecione a pasta para sinconizacao";
            upload_folder.ShowNewFolderButton = false;
            if (upload_folder.ShowDialog() == DialogResult.OK)
            {
                folderupload.Text = upload_folder.SelectedPath;
            }
            else
            {

            }
        }

        private void downalodbutton_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog downalod_folder = new FolderBrowserDialog();
            downalod_folder.RootFolder = Environment.SpecialFolder.Desktop;
            downalod_folder.Description = "Selecione a pasta para sinconizacao";
            downalod_folder.ShowNewFolderButton = false;
            if (downalod_folder.ShowDialog() == DialogResult.OK)
            {
                folderdownload.Text = downalod_folder.SelectedPath;
            }
            else
            {

            }
        }

        private void sync_upload_Click(object sender, EventArgs e)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo("rclone\\rclone.exe");
            startInfo.Arguments = "sync \"" + folderupload.Text + "\" " + boxname.Text + "\"" + folder_nuvem_upload.Text + "\" -P";
            Process.Start(startInfo);
            using (StreamWriter writer = new StreamWriter(@"rclone\config\.upload.dat", true))
            {
                writer.WriteLine(folder_nuvem_upload.Text);
            }
            folder_nuvem_upload.Items.Add(folder_nuvem_upload.Text);
            folder_nuvem_upload.Text = "";
        }

        private void sync_download_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("rclone\\rclone.exe");
            startInfo.Arguments = "sync " + boxname.Text + "\"" + folder_nuvem_download.Text + "\"" + " \"" + folderdownload.Text + "\\" + folder_nuvem_download.Text + "\" -P";
            Process.Start(startInfo);
            using (StreamWriter writer = new StreamWriter(@"rclone\config\.download.dat", true))
            {
                writer.WriteLine(folder_nuvem_download.Text);
            }
            folder_nuvem_download.Items.Add(folder_nuvem_download.Text);
            folder_nuvem_download.Text = "";
        }

        private void folderupload_TextChanged(object sender, EventArgs e)
        {

        }



        private void config_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("rclone\\rclone.exe");
            //startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.Arguments = "config";
            Process.Start(startInfo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxname.Items.Clear();
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "rclone\\rclone.exe";
                process.StartInfo.Arguments = "listremotes";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                process.Start();
                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();
                using (StreamWriter writer = new StreamWriter(@"rclone\config\.nuvem.dat", false))
                {
                    writer.WriteLine(output);
                }
                process.WaitForExit();
            }
            string[] text = System.IO.File.ReadAllLines(@"rclone\config\.nuvem.dat");
            foreach (string texto in text)
            {

                Console.WriteLine("\t" + texto);
                boxname.Items.Add(texto);
            }
            boxname.SelectedIndex = 0;
        }

        private void limparCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"rclone\config\.nuvem.dat", false))
            {
                writer.Close();
            }
            using (StreamWriter writer = new StreamWriter(@"rclone\config\.download.dat", false))
            {
                writer.Close();
            }
            using (StreamWriter writer = new StreamWriter(@"rclone\config\.upload.dat", false))
            {
                writer.Close();
            }
            boxname.Items.Clear();
            folder_nuvem_download.Items.Clear();
            folder_nuvem_upload.Items.Clear();
            boxname.Text = "";
            folder_nuvem_download.Text = "";
            folder_nuvem_upload.Text = "";
        }
    }
}
