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
            this.folderupload = new System.Windows.Forms.TextBox();
            this.sync_upload = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderdownload = new System.Windows.Forms.TextBox();
            this.sync_download = new System.Windows.Forms.Button();
            this.downalod_button = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Button();
            this.boxname = new System.Windows.Forms.ComboBox();
            this.carregar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conteúdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folder_nuvem_upload = new System.Windows.Forms.ComboBox();
            this.folder_nuvem_download = new System.Windows.Forms.ComboBox();
            this.limparCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nome = new System.Windows.Forms.Label();
            this.Upload.SuspendLayout();
            this.Download.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Controls.Add(this.folder_nuvem_upload);
            this.Upload.Controls.Add(this.label2);
            this.Upload.Controls.Add(this.label1);
            this.Upload.Controls.Add(this.folderupload);
            this.Upload.Controls.Add(this.sync_upload);
            this.Upload.Controls.Add(this.upload_button);
            this.Upload.Location = new System.Drawing.Point(12, 111);
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
            this.Download.Controls.Add(this.folder_nuvem_download);
            this.Download.Controls.Add(this.label4);
            this.Download.Controls.Add(this.label3);
            this.Download.Controls.Add(this.folderdownload);
            this.Download.Controls.Add(this.sync_download);
            this.Download.Controls.Add(this.downalod_button);
            this.Download.Location = new System.Drawing.Point(406, 111);
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
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diretório na Nuvem";
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
            this.config.Location = new System.Drawing.Point(49, 33);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(117, 21);
            this.config.TabIndex = 4;
            this.config.Text = "Configuração Rclone";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // boxname
            // 
            this.boxname.FormattingEnabled = true;
            this.boxname.Location = new System.Drawing.Point(182, 34);
            this.boxname.Name = "boxname";
            this.boxname.Size = new System.Drawing.Size(99, 21);
            this.boxname.TabIndex = 5;
            this.boxname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // carregar
            // 
            this.carregar.Location = new System.Drawing.Point(287, 33);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(99, 21);
            this.carregar.TabIndex = 6;
            this.carregar.Text = "Atualizar Nuvem";
            this.carregar.UseVisualStyleBackColor = true;
            this.carregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.sairToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem1.Text = "Sai&r";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.limparCacheToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferra&mentas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteúdoToolStripMenuItem,
            this.toolStripSeparator5,
            this.sobreToolStripMenuItem1});
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem1.Text = "Aj&uda";
            // 
            // conteúdoToolStripMenuItem
            // 
            this.conteúdoToolStripMenuItem.Name = "conteúdoToolStripMenuItem";
            this.conteúdoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conteúdoToolStripMenuItem.Text = "&Conteúdo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem1.Text = "&Sobre...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carregar);
            this.groupBox1.Controls.Add(this.boxname);
            this.groupBox1.Controls.Add(this.config);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // folder_nuvem_upload
            // 
            this.folder_nuvem_upload.FormattingEnabled = true;
            this.folder_nuvem_upload.Location = new System.Drawing.Point(6, 92);
            this.folder_nuvem_upload.Name = "folder_nuvem_upload";
            this.folder_nuvem_upload.Size = new System.Drawing.Size(267, 21);
            this.folder_nuvem_upload.TabIndex = 7;
            // 
            // folder_nuvem_download
            // 
            this.folder_nuvem_download.FormattingEnabled = true;
            this.folder_nuvem_download.Location = new System.Drawing.Point(6, 93);
            this.folder_nuvem_download.Name = "folder_nuvem_download";
            this.folder_nuvem_download.Size = new System.Drawing.Size(267, 21);
            this.folder_nuvem_download.TabIndex = 9;
            // 
            // limparCacheToolStripMenuItem
            // 
            this.limparCacheToolStripMenuItem.Name = "limparCacheToolStripMenuItem";
            this.limparCacheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparCacheToolStripMenuItem.Text = "Limpar Cache";
            this.limparCacheToolStripMenuItem.Click += new System.EventHandler(this.limparCacheToolStripMenuItem_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(775, 293);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(19, 13);
            this.Nome.TabIndex = 9;
            this.Nome.Text = "FF";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(801, 306);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rclone Update Files   V0.15 - Filip Junio Felipe";
            this.Upload.ResumeLayout(false);
            this.Upload.PerformLayout();
            this.Download.ResumeLayout(false);
            this.Download.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Upload;
        private System.Windows.Forms.GroupBox Download;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.Button downalod_button;
        private System.Windows.Forms.TextBox folderupload;
        private System.Windows.Forms.Button sync_upload;
        private System.Windows.Forms.TextBox folderdownload;
        private System.Windows.Forms.Button sync_download;
        private System.Windows.Forms.Button config;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxname;
        private System.Windows.Forms.Button carregar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem conteúdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox folder_nuvem_upload;
        private System.Windows.Forms.ComboBox folder_nuvem_download;
        private System.Windows.Forms.ToolStripMenuItem limparCacheToolStripMenuItem;
        private System.Windows.Forms.Label Nome;
    }
}

