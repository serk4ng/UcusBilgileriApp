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
            this.menuHavayollariListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayoluEnvanterIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayoluEnvanterListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavaalaniIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavaalaniEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavaalanlariniListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYolcuIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYolcuEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYolculariListele = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uçuşİşlemleriToolStripMenuItem,
            this.menuHavayoluIslemleri,
            this.menuHavaalaniIslemleri,
            this.menuYolcuIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
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
            // menuHavaalaniIslemleri
            // 
            this.menuHavaalaniIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHavaalaniEkleSilGuncelle,
            this.menuHavaalanlariniListele});
            this.menuHavaalaniIslemleri.Name = "menuHavaalaniIslemleri";
            this.menuHavaalaniIslemleri.Size = new System.Drawing.Size(118, 20);
            this.menuHavaalaniIslemleri.Text = "Havaalanı İşlemleri";
            // 
            // menuHavaalaniEkleSilGuncelle
            // 
            this.menuHavaalaniEkleSilGuncelle.Name = "menuHavaalaniEkleSilGuncelle";
            this.menuHavaalaniEkleSilGuncelle.Size = new System.Drawing.Size(218, 22);
            this.menuHavaalaniEkleSilGuncelle.Text = "Havaalanı Ekle-Sil-Güncelle";
            this.menuHavaalaniEkleSilGuncelle.Click += new System.EventHandler(this.menuHavaalaniEkleSilGuncelle_Click);
            // 
            // menuHavaalanlariniListele
            // 
            this.menuHavaalanlariniListele.Name = "menuHavaalanlariniListele";
            this.menuHavaalanlariniListele.Size = new System.Drawing.Size(218, 22);
            this.menuHavaalanlariniListele.Text = "Havaalanlarını Listele";
            this.menuHavaalanlariniListele.Click += new System.EventHandler(this.menuHavaalanlariniListele_Click);
            // 
            // menuYolcuIslemleri
            // 
            this.menuYolcuIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYolcuEkleSilGuncelle,
            this.menuYolculariListele});
            this.menuYolcuIslemleri.Name = "menuYolcuIslemleri";
            this.menuYolcuIslemleri.Size = new System.Drawing.Size(95, 20);
            this.menuYolcuIslemleri.Text = "Yolcu İşlemleri";
            // 
            // menuYolcuEkleSilGuncelle
            // 
            this.menuYolcuEkleSilGuncelle.Name = "menuYolcuEkleSilGuncelle";
            this.menuYolcuEkleSilGuncelle.Size = new System.Drawing.Size(195, 22);
            this.menuYolcuEkleSilGuncelle.Text = "Yolcu Ekle-Sil-Guncelle";
            this.menuYolcuEkleSilGuncelle.Click += new System.EventHandler(this.menuYolcuEkleSilGuncelle_Click);
            // 
            // menuYolculariListele
            // 
            this.menuYolculariListele.Name = "menuYolculariListele";
            this.menuYolculariListele.Size = new System.Drawing.Size(195, 22);
            this.menuYolculariListele.Text = "Yolcuları Listele";
            this.menuYolculariListele.Click += new System.EventHandler(this.menuYolculariListele_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Ucus Bilgileri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem uçuşİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUcusEkleSilGuncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluEkleSilGuncelle;
        private System.Windows.Forms.ToolStripMenuItem menuUcusBilgileriListeleme;
        private System.Windows.Forms.ToolStripMenuItem menuHavayollariListele;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluEnvanterIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuHavayoluEnvanterListele;
        private System.Windows.Forms.ToolStripMenuItem menuHavaalaniIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuHavaalaniEkleSilGuncelle;
        private System.Windows.Forms.ToolStripMenuItem menuHavaalanlariniListele;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuYolcuIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuYolcuEkleSilGuncelle;
        private System.Windows.Forms.ToolStripMenuItem menuYolculariListele;
    }
}