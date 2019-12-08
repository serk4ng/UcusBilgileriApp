namespace UcusBilgileriApp
{
    partial class frmHavaalaniIslemleri
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
            this.txtHavaalaniID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtHavaalaniAdi = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHavaalaniID
            // 
            this.txtHavaalaniID.Location = new System.Drawing.Point(3, 3);
            this.txtHavaalaniID.Name = "txtHavaalaniID";
            this.txtHavaalaniID.Size = new System.Drawing.Size(100, 20);
            this.txtHavaalaniID.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtHavaalaniAdi
            // 
            this.txtHavaalaniAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtHavaalaniAdi.Location = new System.Drawing.Point(3, 29);
            this.txtHavaalaniAdi.Name = "txtHavaalaniAdi";
            this.txtHavaalaniAdi.Size = new System.Drawing.Size(195, 20);
            this.txtHavaalaniAdi.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Havaalani ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Havaalani Adı :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(159, 146);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(89, 32);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(269, 146);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(83, 32);
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "Vazgec";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Visible = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(159, 198);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(89, 31);
            this.btnBul.TabIndex = 7;
            this.btnBul.Text = "Havaalani Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(269, 198);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 31);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.txtHavaalaniID);
            this.pnlText.Controls.Add(this.txtHavaalaniAdi);
            this.pnlText.Location = new System.Drawing.Point(138, 55);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(203, 54);
            this.pnlText.TabIndex = 9;
            // 
            // frmHavaalaniIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Name = "frmHavaalaniIslemleri";
            this.Text = "frmHavaalaniIslemleri";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtHavaalaniID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txtHavaalaniAdi;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnVazgec;
        public System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel pnlText;
        public System.Windows.Forms.Label lblID;
    }
}