﻿namespace UcusBilgileriApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uçuşİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUcusEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.havaalaniİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavaalaniEkleSilGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uçuşİşlemleriToolStripMenuItem,
            this.havaalaniİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uçuşİşlemleriToolStripMenuItem
            // 
            this.uçuşİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUcusEkleSilGuncelle});
            this.uçuşİşlemleriToolStripMenuItem.Name = "uçuşİşlemleriToolStripMenuItem";
            this.uçuşİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.uçuşİşlemleriToolStripMenuItem.Text = "Uçuş İşlemleri";
            // 
            // menuUcusEkleSilGuncelle
            // 
            this.menuUcusEkleSilGuncelle.Name = "menuUcusEkleSilGuncelle";
            this.menuUcusEkleSilGuncelle.Size = new System.Drawing.Size(192, 22);
            this.menuUcusEkleSilGuncelle.Text = "Uçuş Ekle-Sil-Güncelle";
            this.menuUcusEkleSilGuncelle.Click += new System.EventHandler(this.menuUcusEkleSilGuncelle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // havaalaniİşlemleriToolStripMenuItem
            // 
            this.havaalaniİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHavaalaniEkleSilGuncelle});
            this.havaalaniİşlemleriToolStripMenuItem.Name = "havaalaniİşlemleriToolStripMenuItem";
            this.havaalaniİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.havaalaniİşlemleriToolStripMenuItem.Text = "Havaalani İşlemleri";
            // 
            // menuHavaalaniEkleSilGuncelle
            // 
            this.menuHavaalaniEkleSilGuncelle.Name = "menuHavaalaniEkleSilGuncelle";
            this.menuHavaalaniEkleSilGuncelle.Size = new System.Drawing.Size(218, 22);
            this.menuHavaalaniEkleSilGuncelle.Text = "Havaalani Ekle-Sil-Güncelle";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
        private System.Windows.Forms.ToolStripMenuItem havaalaniİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHavaalaniEkleSilGuncelle;
    }
}