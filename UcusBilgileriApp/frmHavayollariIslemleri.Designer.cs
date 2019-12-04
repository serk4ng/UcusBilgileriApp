namespace UcusBilgileriApp
{
    partial class frmHavayollariIslemleri
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
            this.txtHavayoluID = new System.Windows.Forms.TextBox();
            this.txtHavayoluAdi = new System.Windows.Forms.TextBox();
            this.lblHavaalaniID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHavayoluID
            // 
            this.txtHavayoluID.Location = new System.Drawing.Point(3, 3);
            this.txtHavayoluID.Name = "txtHavayoluID";
            this.txtHavayoluID.Size = new System.Drawing.Size(100, 20);
            this.txtHavayoluID.TabIndex = 0;
            // 
            // txtHavayoluAdi
            // 
            this.txtHavayoluAdi.Location = new System.Drawing.Point(3, 29);
            this.txtHavayoluAdi.Name = "txtHavayoluAdi";
            this.txtHavayoluAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHavayoluAdi.TabIndex = 1;
            // 
            // lblHavaalaniID
            // 
            this.lblHavaalaniID.AutoSize = true;
            this.lblHavaalaniID.Location = new System.Drawing.Point(79, 73);
            this.lblHavaalaniID.Name = "lblHavaalaniID";
            this.lblHavaalaniID.Size = new System.Drawing.Size(72, 13);
            this.lblHavaalaniID.TabIndex = 2;
            this.lblHavaalaniID.Text = "Havayolu ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Havayolu Adı :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(157, 147);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 33);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(286, 147);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(94, 33);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Vazgec";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(157, 199);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(94, 33);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Havayolu Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(286, 199);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 33);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.txtHavayoluID);
            this.pnlText.Controls.Add(this.txtHavayoluAdi);
            this.pnlText.Location = new System.Drawing.Point(157, 67);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(107, 51);
            this.pnlText.TabIndex = 8;
            // 
            // frmHavayollariIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHavaalaniID);
            this.Name = "frmHavayollariIslemleri";
            this.Text = "frmHavayoluIslemleri";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtHavayoluID;
        public System.Windows.Forms.TextBox txtHavayoluAdi;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnVazgec;
        public System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Label lblHavaalaniID;
        private System.Windows.Forms.Panel pnlText;
    }
}