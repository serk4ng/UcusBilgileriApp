namespace UcusBilgileriApp
{
    partial class frmUcusListe
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
            this.grdUcusBilgileri = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmUcusNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHavayolu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmKalkisYeri = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmVarisYeri = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmKalkisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKalkisSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVarisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVarisSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTahminiSure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUcak = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUcusBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUcusBilgileri
            // 
            this.grdUcusBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUcusBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUcusBilgileri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUcusNumarasi,
            this.clmHavayolu,
            this.clmKalkisYeri,
            this.clmVarisYeri,
            this.clmKalkisTarih,
            this.clmKalkisSaat,
            this.clmVarisTarih,
            this.clmVarisSaat,
            this.clmTahminiSure,
            this.clmUcak});
            this.grdUcusBilgileri.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdUcusBilgileri.GridColor = System.Drawing.SystemColors.ControlLight;
            this.grdUcusBilgileri.Location = new System.Drawing.Point(0, 0);
            this.grdUcusBilgileri.Name = "grdUcusBilgileri";
            this.grdUcusBilgileri.Size = new System.Drawing.Size(787, 225);
            this.grdUcusBilgileri.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(332, 287);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 45);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmUcusNumarasi
            // 
            this.clmUcusNumarasi.DataPropertyName = "Ucus_Numarasi";
            this.clmUcusNumarasi.HeaderText = "Ucus_Numarasi";
            this.clmUcusNumarasi.Name = "clmUcusNumarasi";
            this.clmUcusNumarasi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmHavayolu
            // 
            this.clmHavayolu.DataPropertyName = "Id_Havayolu";
            this.clmHavayolu.HeaderText = "Havayolu";
            this.clmHavayolu.Name = "clmHavayolu";
            this.clmHavayolu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmHavayolu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmKalkisYeri
            // 
            this.clmKalkisYeri.DataPropertyName = "Id_Yer";
            this.clmKalkisYeri.HeaderText = "Kalkis_Yeri";
            this.clmKalkisYeri.Name = "clmKalkisYeri";
            this.clmKalkisYeri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmKalkisYeri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmVarisYeri
            // 
            this.clmVarisYeri.DataPropertyName = "Id_Yer2";
            this.clmVarisYeri.HeaderText = "Varis_Yeri";
            this.clmVarisYeri.Name = "clmVarisYeri";
            this.clmVarisYeri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmVarisYeri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmKalkisTarih
            // 
            this.clmKalkisTarih.DataPropertyName = "Kalkis_Tarih";
            this.clmKalkisTarih.HeaderText = "Kalkis_Tarih";
            this.clmKalkisTarih.Name = "clmKalkisTarih";
            // 
            // clmKalkisSaat
            // 
            this.clmKalkisSaat.DataPropertyName = "Kalkis_Saat";
            this.clmKalkisSaat.HeaderText = "Kalkis_Saat";
            this.clmKalkisSaat.Name = "clmKalkisSaat";
            // 
            // clmVarisTarih
            // 
            this.clmVarisTarih.DataPropertyName = "Varis_Tarih";
            this.clmVarisTarih.HeaderText = "Varis_Tarih";
            this.clmVarisTarih.Name = "clmVarisTarih";
            // 
            // clmVarisSaat
            // 
            this.clmVarisSaat.DataPropertyName = "Varis_Saat";
            this.clmVarisSaat.HeaderText = "Varis_Saat";
            this.clmVarisSaat.Name = "clmVarisSaat";
            // 
            // clmTahminiSure
            // 
            this.clmTahminiSure.DataPropertyName = "Tahmini_Sure";
            this.clmTahminiSure.HeaderText = "Tahmini_Sure";
            this.clmTahminiSure.Name = "clmTahminiSure";
            // 
            // clmUcak
            // 
            this.clmUcak.DataPropertyName = "Id_Ucak";
            this.clmUcak.HeaderText = "Ucak";
            this.clmUcak.Name = "clmUcak";
            // 
            // frmUcusListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 405);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdUcusBilgileri);
            this.Name = "frmUcusListe";
            this.Text = "frmUcusListe";
            this.Load += new System.EventHandler(this.frmUcusListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUcusBilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUcusBilgileri;
        public System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUcusNumarasi;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmHavayolu;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmKalkisYeri;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmVarisYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKalkisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKalkisSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVarisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVarisSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTahminiSure;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmUcak;
    }
}