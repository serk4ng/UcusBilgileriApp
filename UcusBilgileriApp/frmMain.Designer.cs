namespace UcusBilgileriApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uçuşİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUcusEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUcusBilgileriListeleme = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayoluIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayoluEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuHavayollariListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayoluEnvanterIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayoluEnvanterListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uçuşİşlemleriToolStripMenuItem,
            this.menuHavayoluIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uçuşİşlemleriToolStripMenuItem
            // 
            this.uçuşİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUcusEkleSilGuncelle,
            this.menuUcusBilgileriListeleme});
            this.uçuşİşlemleriToolStripMenuItem.Name = "uçuşİşlemleriToolStripMenuItem";
            this.uçuşİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.uçuşİşlemleriToolStripMenuItem.Text = "Uçuş İşlemleri";
            // 
            // menuUcusEkleSilGuncelle
            // 
            this.menuUcusEkleSilGuncelle.Name = "menuUcusEkleSilGuncelle";
            this.menuUcusEkleSilGuncelle.Size = new System.Drawing.Size(195, 22);
            this.menuUcusEkleSilGuncelle.Text = "Uçuş Ekle-Sil-Güncelle";
            this.menuUcusEkleSilGuncelle.Click += new System.EventHandler(this.menuUcusEkleSilGuncelle_Click);
            // 
            // menuUcusBilgileriListeleme
            // 
            this.menuUcusBilgileriListeleme.Name = "menuUcusBilgileriListeleme";
            this.menuUcusBilgileriListeleme.Size = new System.Drawing.Size(195, 22);
            this.menuUcusBilgileriListeleme.Text = "Uçuş Bilgileri Listeleme";
            this.menuUcusBilgileriListeleme.Click += new System.EventHandler(this.menuUcusBilgileriListeleme_Click);
            // 
            // menuHavayoluIslemleri
            // 
            this.menuHavayoluIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHavayoluEkleSilGuncelle,
            this.menuHavayollariListele,
            this.menuHavayoluEnvanterIslemleri,
            this.menuHavayoluEnvanterListele});
            this.menuHavayoluIslemleri.Name = "menuHavayoluIslemleri";
            this.menuHavayoluIslemleri.Size = new System.Drawing.Size(116, 20);
            this.menuHavayoluIslemleri.Text = "Havayolu İşlemleri";
            // 
            // menuHavayoluEkleSilGuncelle
            // 
            this.menuHavayoluEkleSilGuncelle.Name = "menuHavayoluEkleSilGuncelle";
            this.menuHavayoluEkleSilGuncelle.Size = new System.Drawing.Size(220, 22);
            this.menuHavayoluEkleSilGuncelle.Text = "Havayolu Ekle-Sil-Güncelle";
            this.menuHavayoluEkleSilGuncelle.Click += new System.EventHandler(this.menuHavayoluEkleSilGuncelle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuHavayollariListele
            // 
            this.menuHavayollariListele.Name = "menuHavayollariListele";
            this.menuHavayollariListele.Size = new System.Drawing.Size(220, 22);
            this.menuHavayollariListele.Text = "Havayollari Listele";
            this.menuHavayollariListele.Click += new System.EventHandler(this.menuHavayollariListele_Click);
            // 
            // menuHavayoluEnvanterIslemleri
            // 
            this.menuHavayoluEnvanterIslemleri.Name = "menuHavayoluEnvanterIslemleri";
            this.menuHavayoluEnvanterIslemleri.Size = new System.Drawing.Size(220, 22);
            this.menuHavayoluEnvanterIslemleri.Text = "Havayolu Envanter İşlemleri";
            this.menuHavayoluEnvanterIslemleri.Click += new System.EventHandler(this.havayoluEnvanterKayıtToolStripMenuItem_Click);
            // 
            // menuHavayoluEnvanterListele
            // 
            this.menuHavayoluEnvanterListele.Name = "menuHavayoluEnvanterListele";
            this.menuHavayoluEnvanterListele.Size = new System.Drawing.Size(220, 22);
            this.menuHavayoluEnvanterListele.Text = "Havayolu Envanter Listele";
            this.menuHavayoluEnvanterListele.Click += new System.EventHandler(this.menuHavayoluEnvanterListele_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uçuşİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUcusEkleSilGuncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluEkleSilGuncelle;
        private System.Windows.Forms.ToolStripMenuItem menuUcusBilgileriListeleme;
        private System.Windows.Forms.ToolStripMenuItem menuHavayollariListele;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluEnvanterIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluEnvanterListele;
    }
}