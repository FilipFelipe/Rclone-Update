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
namespace Rclone_Update
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            startInfo.Arguments = "sync \"" + folderupload.Text + "\" " + "onedrive:\"" + folder_nuvem_upload.Text + "\" -P";
           
            Process.Start(startInfo);
        }

        private void sync_download_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("rclone\\rclone.exe");
            startInfo.Arguments = "sync onedrive:\"" + folder_nuvem_download.Text + "\"" + " \"" + folderdownload.Text + "\\" + folder_nuvem_download.Text + "\" -P";
            Process.Start(startInfo);
        }
            
        private void folderupload_TextChanged(object sender, EventArgs e)
        {

        }



        private void config_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("rclone\\rclone.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.Arguments = "config n";
            Process.Start(startInfo);
        }
    }
}
