namespace UcusBilgileriApp
{
    partial class frmYolcuBul
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
            this.btnBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAd = new System.Windows.Forms.ComboBox();
            this.cmbSoyad = new System.Windows.Forms.ComboBox();
            this.cmbUcusNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(96, 128);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad :";
            // 
            // cmbAd
            // 
            this.cmbAd.FormattingEnabled = true;
            this.cmbAd.Location = new System.Drawing.Point(82, 47);
            this.cmbAd.Name = "cmbAd";
            this.cmbAd.Size = new System.Drawing.Size(121, 21);
            this.cmbAd.TabIndex = 6;
            this.cmbAd.SelectedIndexChanged += new System.EventHandler(this.cmbAd_SelectedIndexChanged);
            // 
            // cmbSoyad
            // 
            this.cmbSoyad.FormattingEnabled = true;
            this.cmbSoyad.Location = new System.Drawing.Point(82, 73);
            this.cmbSoyad.Name = "cmbSoyad";
            this.cmbSoyad.Size = new System.Drawing.Size(121, 21);
            this.cmbSoyad.TabIndex = 7;
            // 
            // cmbUcusNo
            // 
            this.cmbUcusNo.FormattingEnabled = true;
            this.cmbUcusNo.Location = new System.Drawing.Point(82, 101);
            this.cmbUcusNo.Name = "cmbUcusNo";
            this.cmbUcusNo.Size = new System.Drawing.Size(121, 21);
            this.cmbUcusNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ucus No:";
            // 
            // frmYolcuBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUcusNo);
            this.Controls.Add(this.cmbSoyad);
            this.Controls.Add(this.cmbAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBul);
            this.Name = "frmYolcuBul";
            this.Text = "frmYolcuBul";
            this.Load += new System.EventHandler(this.frmYolcuBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.ComboBox cmbAd;
        public System.Windows.Forms.ComboBox cmbSoyad;
        public System.Windows.Forms.ComboBox cmbUcusNo;
        private System.Windows.Forms.Label label3;
    }
}