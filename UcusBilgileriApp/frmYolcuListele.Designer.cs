namespace UcusBilgileriApp
{
    partial class frmYolcuListele
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
            this.grdYolcular = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUcusNumarasi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdYolcular)).BeginInit();
            this.SuspendLayout();
            // 
            // grdYolcular
            // 
            this.grdYolcular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdYolcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYolcular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmSoyad,
            this.clmUcusNumarasi});
            this.grdYolcular.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdYolcular.Location = new System.Drawing.Point(0, 0);
            this.grdYolcular.Name = "grdYolcular";
            this.grdYolcular.Size = new System.Drawing.Size(800, 239);
            this.grdYolcular.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(343, 324);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 42);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmAd
            // 
            this.clmAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmAd.DataPropertyName = "Ad";
            this.clmAd.HeaderText = "Ad";
            this.clmAd.Name = "clmAd";
            this.clmAd.Width = 252;
            // 
            // clmSoyad
            // 
            this.clmSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmSoyad.DataPropertyName = "Soyad";
            this.clmSoyad.HeaderText = "Soyad";
            this.clmSoyad.Name = "clmSoyad";
            this.clmSoyad.Width = 253;
            // 
            // clmUcusNumarasi
            // 
            this.clmUcusNumarasi.DataPropertyName = "Ucus_Numarasi";
            this.clmUcusNumarasi.HeaderText = "Ucus_Numarasi";
            this.clmUcusNumarasi.Name = "clmUcusNumarasi";
            // 
            // frmYolcuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdYolcular);
            this.Name = "frmYolcuListele";
            this.Text = "frmYolcuListele";
            this.Load += new System.EventHandler(this.frmYolcuListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYolcular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdYolcular;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmUcusNumarasi;
    }
}