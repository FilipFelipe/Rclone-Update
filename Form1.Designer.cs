namespace Rclone_Update
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Upload = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folder_nuvem_upload = new System.Windows.Forms.TextBox();
            this.folderupload = new System.Windows.Forms.TextBox();
            this.sync_upload = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderdownload = new System.Windows.Forms.TextBox();
            this.folder_nuvem_download = new System.Windows.Forms.TextBox();
            this.sync_download = new System.Windows.Forms.Button();
            this.downalod_button = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Button();
            this.Upload.SuspendLayout();
            this.Download.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Controls.Add(this.label2);
            this.Upload.Controls.Add(this.label1);
            this.Upload.Controls.Add(this.folder_nuvem_upload);
            this.Upload.Controls.Add(this.folderupload);
            this.Upload.Controls.Add(this.sync_upload);
            this.Upload.Controls.Add(this.upload_button);
            this.Upload.Location = new System.Drawing.Point(12, 16);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(388, 179);
            this.Upload.TabIndex = 0;
            this.Upload.TabStop = false;
            this.Upload.Text = "Upload";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diretório na Nuvem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Diretório de sincronização";
            // 
            // folder_nuvem_upload
            // 
            this.folder_nuvem_upload.Location = new System.Drawing.Point(6, 93);
            this.folder_nuvem_upload.Name = "folder_nuvem_upload";
            this.folder_nuvem_upload.Size = new System.Drawing.Size(241, 20);
            this.folder_nuvem_upload.TabIndex = 3;
            // 
            // folderupload
            // 
            this.folderupload.Location = new System.Drawing.Point(6, 54);
            this.folderupload.Name = "folderupload";
            this.folderupload.Size = new System.Drawing.Size(343, 20);
            this.folderupload.TabIndex = 2;
            this.folderupload.TextChanged += new System.EventHandler(this.folderupload_TextChanged);
            // 
            // sync_upload
            // 
            this.sync_upload.Image = ((System.Drawing.Image)(resources.GetObject("sync_upload.Image")));
            this.sync_upload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sync_upload.Location = new System.Drawing.Point(166, 119);
            this.sync_upload.Name = "sync_upload";
            this.sync_upload.Size = new System.Drawing.Size(66, 52);
            this.sync_upload.TabIndex = 1;
            this.sync_upload.Text = "Sync";
            this.sync_upload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sync_upload.UseVisualStyleBackColor = true;
            this.sync_upload.Click += new System.EventHandler(this.sync_upload_Click);
            // 
            // upload_button
            // 
            this.upload_button.Image = ((System.Drawing.Image)(resources.GetObject("upload_button.Image")));
            this.upload_button.Location = new System.Drawing.Point(355, 47);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(27, 33);
            this.upload_button.TabIndex = 0;
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.uploadbutton_Click);
            // 
            // Download
            // 
            this.Download.Controls.Add(this.label4);
            this.Download.Controls.Add(this.label3);
            this.Download.Controls.Add(this.folderdownload);
            this.Download.Controls.Add(this.folder_nuvem_download);
            this.Download.Controls.Add(this.sync_download);
            this.Download.Controls.Add(this.downalod_button);
            this.Download.Location = new System.Drawing.Point(406, 16);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(388, 179);
            this.Download.TabIndex = 1;
            this.Download.TabStop = false;
            this.Download.Text = "Download";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diretório de sincronização";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diretório de sincronização";
            // 
            // folderdownload
            // 
            this.folderdownload.Location = new System.Drawing.Point(6, 52);
            this.folderdownload.Name = "folderdownload";
            this.folderdownload.Size = new System.Drawing.Size(341, 20);
            this.folderdownload.TabIndex = 3;
            // 
            // folder_nuvem_download
            // 
            this.folder_nuvem_download.Location = new System.Drawing.Point(6, 93);
            this.folder_nuvem_download.Name = "folder_nuvem_download";
            this.folder_nuvem_download.Size = new System.Drawing.Size(241, 20);
            this.folder_nuvem_download.TabIndex = 2;
            // 
            // sync_download
            // 
            this.sync_download.Image = ((System.Drawing.Image)(resources.GetObject("sync_download.Image")));
            this.sync_download.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sync_download.Location = new System.Drawing.Point(170, 119);
            this.sync_download.Name = "sync_download";
            this.sync_download.Size = new System.Drawing.Size(65, 52);
            this.sync_download.TabIndex = 1;
            this.sync_download.Text = "Sync";
            this.sync_download.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sync_download.UseVisualStyleBackColor = true;
            this.sync_download.Click += new System.EventHandler(this.sync_download_Click);
            // 
            // downalod_button
            // 
            this.downalod_button.Image = ((System.Drawing.Image)(resources.GetObject("downalod_button.Image")));
            this.downalod_button.Location = new System.Drawing.Point(353, 45);
            this.downalod_button.Name = "downalod_button";
            this.downalod_button.Size = new System.Drawing.Size(27, 33);
            this.downalod_button.TabIndex = 0;
            this.downalod_button.UseVisualStyleBackColor = true;
            this.downalod_button.Click += new System.EventHandler(this.downalodbutton_Click);
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(12, 208);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(136, 30);
            this.config.TabIndex = 4;
            this.config.Text = "Configuração Rclone";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(805, 241);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.config);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rclone Update Files   V0.1 - Filip Junio Felipe";
            this.Upload.ResumeLayout(false);
            this.Upload.PerformLayout();
            this.Download.ResumeLayout(false);
            this.Download.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Upload;
        private System.Windows.Forms.GroupBox Download;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button downalod_button;
        private System.Windows.Forms.TextBox folder_nuvem_upload;
        private System.Windows.Forms.TextBox folderupload;
        private System.Windows.Forms.Button sync_upload;
        private System.Windows.Forms.TextBox folderdownload;
        private System.Windows.Forms.TextBox folder_nuvem_download;
        private System.Windows.Forms.Button sync_download;
        private System.Windows.Forms.Button config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

