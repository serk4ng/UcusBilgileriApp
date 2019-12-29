namespace UcusBilgileriApp
{
    partial class frmYolcuIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYolcuIslemleri));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbUcusNumarasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.cmbAd = new System.Windows.Forms.ComboBox();
            this.cmbSoyad = new System.Windows.Forms.ComboBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(134, 187);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 29);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(134, 233);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(85, 31);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(262, 187);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(85, 29);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "Vazgec";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(251, 233);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 31);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbUcusNumarasi
            // 
            this.cmbUcusNumarasi.FormattingEnabled = true;
            this.cmbUcusNumarasi.Location = new System.Drawing.Point(133, 62);
            this.cmbUcusNumarasi.Name = "cmbUcusNumarasi";
            this.cmbUcusNumarasi.Size = new System.Drawing.Size(121, 21);
            this.cmbUcusNumarasi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ucus Numarası Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyad :";
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.Transparent;
            this.pnlText.Controls.Add(this.txtKoltukNo);
            this.pnlText.Controls.Add(this.cmbAd);
            this.pnlText.Controls.Add(this.cmbSoyad);
            this.pnlText.Location = new System.Drawing.Point(133, 89);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(157, 82);
            this.pnlText.TabIndex = 10;
            // 
            // cmbAd
            // 
            this.cmbAd.FormattingEnabled = true;
            this.cmbAd.Location = new System.Drawing.Point(3, 3);
            this.cmbAd.Name = "cmbAd";
            this.cmbAd.Size = new System.Drawing.Size(121, 21);
            this.cmbAd.TabIndex = 11;
            this.cmbAd.SelectedIndexChanged += new System.EventHandler(this.cmbAd_SelectedIndexChanged);
            // 
            // cmbSoyad
            // 
            this.cmbSoyad.FormattingEnabled = true;
            this.cmbSoyad.Location = new System.Drawing.Point(4, 28);
            this.cmbSoyad.Name = "cmbSoyad";
            this.cmbSoyad.Size = new System.Drawing.Size(121, 21);
            this.cmbSoyad.TabIndex = 12;
            this.cmbSoyad.SelectedIndexChanged += new System.EventHandler(this.cmbSoyad_SelectedIndexChanged);
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(4, 55);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukNo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Koltuk No :";
            // 
            // frmYolcuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUcusNumarasi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnEkle);
            this.Name = "frmYolcuIslemleri";
            this.Text = "frmYolcuIslemleri";
            this.Load += new System.EventHandler(this.frmYolcuIslemleri_Load);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.Button btnVazgec;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ComboBox cmbUcusNumarasi;
        public System.Windows.Forms.ComboBox cmbAd;
        public System.Windows.Forms.ComboBox cmbSoyad;
        public System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtKoltukNo;
    }
}