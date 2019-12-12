namespace UcusBilgileriApp
{
    partial class frmHavayoluEnvanterListele
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
            this.grdHavayoluEnvanter = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmHavayoluAdi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmUcakAdi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayoluEnvanter)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHavayoluEnvanter
            // 
            this.grdHavayoluEnvanter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHavayoluEnvanter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHavayoluEnvanter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmHavayoluAdi,
            this.clmUcakAdi,
            this.clmAdet});
            this.grdHavayoluEnvanter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdHavayoluEnvanter.Location = new System.Drawing.Point(0, 0);
            this.grdHavayoluEnvanter.Name = "grdHavayoluEnvanter";
            this.grdHavayoluEnvanter.Size = new System.Drawing.Size(800, 228);
            this.grdHavayoluEnvanter.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(337, 309);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 41);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmHavayoluAdi
            // 
            this.clmHavayoluAdi.DataPropertyName = "Id_Havayolu";
            this.clmHavayoluAdi.HeaderText = "Havayolu_Adi";
            this.clmHavayoluAdi.Name = "clmHavayoluAdi";
            this.clmHavayoluAdi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmHavayoluAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmUcakAdi
            // 
            this.clmUcakAdi.DataPropertyName = "Id_Ucak";
            this.clmUcakAdi.HeaderText = "Ucak_Adi";
            this.clmUcakAdi.Name = "clmUcakAdi";
            // 
            // clmAdet
            // 
            this.clmAdet.DataPropertyName = "Adet";
            this.clmAdet.HeaderText = "Adet";
            this.clmAdet.Name = "clmAdet";
            // 
            // frmHavayoluEnvanterListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdHavayoluEnvanter);
            this.Name = "frmHavayoluEnvanterListele";
            this.Text = "frmHavayoluEnvanterListele";
            this.Load += new System.EventHandler(this.frmHavayoluEnvanterListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayoluEnvanter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHavayoluEnvanter;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmHavayoluAdi;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmUcakAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdet;
    }
}