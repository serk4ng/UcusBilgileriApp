﻿namespace UcusBilgileriApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUcusNumara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKalkisSaat = new System.Windows.Forms.TextBox();
            this.txtVarisSaat = new System.Windows.Forms.TextBox();
            this.txtTahminiSure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKalkisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtVarisTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbKalkis = new System.Windows.Forms.ComboBox();
            this.cmbHavayolu = new System.Windows.Forms.ComboBox();
            this.cmbVaris = new System.Windows.Forms.ComboBox();
            this.cmbUcak = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUcusNumara
            // 
            this.txtUcusNumara.Location = new System.Drawing.Point(143, 68);
            this.txtUcusNumara.Name = "txtUcusNumara";
            this.txtUcusNumara.Size = new System.Drawing.Size(100, 20);
            this.txtUcusNumara.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Uçuş Numarası :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Havayolu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kalkış Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Varış Yeri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kalkış Tarih :";
            // 
            // txtKalkisSaat
            // 
            this.txtKalkisSaat.Location = new System.Drawing.Point(143, 198);
            this.txtKalkisSaat.Name = "txtKalkisSaat";
            this.txtKalkisSaat.Size = new System.Drawing.Size(100, 20);
            this.txtKalkisSaat.TabIndex = 11;
            // 
            // txtVarisSaat
            // 
            this.txtVarisSaat.Location = new System.Drawing.Point(143, 250);
            this.txtVarisSaat.Name = "txtVarisSaat";
            this.txtVarisSaat.Size = new System.Drawing.Size(100, 20);
            this.txtVarisSaat.TabIndex = 13;
            // 
            // txtTahminiSure
            // 
            this.txtTahminiSure.Location = new System.Drawing.Point(143, 276);
            this.txtTahminiSure.Name = "txtTahminiSure";
            this.txtTahminiSure.Size = new System.Drawing.Size(100, 20);
            this.txtTahminiSure.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kalkış Saat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Varış Tarih :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Varış Saat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tahmini Süre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Uçak :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(119, 328);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(171, 37);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKalkisTarih
            // 
            this.txtKalkisTarih.Location = new System.Drawing.Point(143, 172);
            this.txtKalkisTarih.Name = "txtKalkisTarih";
            this.txtKalkisTarih.Size = new System.Drawing.Size(200, 20);
            this.txtKalkisTarih.TabIndex = 22;
            // 
            // txtVarisTarih
            // 
            this.txtVarisTarih.Location = new System.Drawing.Point(143, 224);
            this.txtVarisTarih.Name = "txtVarisTarih";
            this.txtVarisTarih.Size = new System.Drawing.Size(200, 20);
            this.txtVarisTarih.TabIndex = 23;
            // 
            // cmbKalkis
            // 
            this.cmbKalkis.FormattingEnabled = true;
            this.cmbKalkis.Location = new System.Drawing.Point(143, 119);
            this.cmbKalkis.Name = "cmbKalkis";
            this.cmbKalkis.Size = new System.Drawing.Size(154, 21);
            this.cmbKalkis.TabIndex = 24;
            // 
            // cmbHavayolu
            // 
            this.cmbHavayolu.FormattingEnabled = true;
            this.cmbHavayolu.Location = new System.Drawing.Point(143, 94);
            this.cmbHavayolu.Name = "cmbHavayolu";
            this.cmbHavayolu.Size = new System.Drawing.Size(154, 21);
            this.cmbHavayolu.TabIndex = 25;
            // 
            // cmbVaris
            // 
            this.cmbVaris.FormattingEnabled = true;
            this.cmbVaris.Location = new System.Drawing.Point(143, 146);
            this.cmbVaris.Name = "cmbVaris";
            this.cmbVaris.Size = new System.Drawing.Size(154, 21);
            this.cmbVaris.TabIndex = 26;
            // 
            // cmbUcak
            // 
            this.cmbUcak.FormattingEnabled = true;
            this.cmbUcak.Location = new System.Drawing.Point(143, 302);
            this.cmbUcak.Name = "cmbUcak";
            this.cmbUcak.Size = new System.Drawing.Size(154, 21);
            this.cmbUcak.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Uçuş Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbUcak);
            this.Controls.Add(this.cmbVaris);
            this.Controls.Add(this.cmbHavayolu);
            this.Controls.Add(this.cmbKalkis);
            this.Controls.Add(this.txtVarisTarih);
            this.Controls.Add(this.txtKalkisTarih);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTahminiSure);
            this.Controls.Add(this.txtVarisSaat);
            this.Controls.Add(this.txtKalkisSaat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUcusNumara);
            this.Name = "Form1";
            this.Text = "Uçuş Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.TextBox txtUcusNumara;
        public System.Windows.Forms.TextBox txtKalkisSaat;
        public System.Windows.Forms.TextBox txtVarisSaat;
        public System.Windows.Forms.TextBox txtTahminiSure;
        public System.Windows.Forms.DateTimePicker txtKalkisTarih;
        public System.Windows.Forms.DateTimePicker txtVarisTarih;
        public System.Windows.Forms.ComboBox cmbKalkis;
        public System.Windows.Forms.ComboBox cmbHavayolu;
        public System.Windows.Forms.ComboBox cmbVaris;
        public System.Windows.Forms.ComboBox cmbUcak;
        private System.Windows.Forms.Button button1;
    }
}
