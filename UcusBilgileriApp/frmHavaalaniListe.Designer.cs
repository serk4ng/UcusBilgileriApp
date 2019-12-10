namespace UcusBilgileriApp
{
    partial class frmHavaalaniListe
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
            this.grdHavaalanlari = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdHavaalanlari)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHavaalanlari
            // 
            this.grdHavaalanlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHavaalanlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHavaalanlari.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdHavaalanlari.Location = new System.Drawing.Point(0, 0);
            this.grdHavaalanlari.Name = "grdHavaalanlari";
            this.grdHavaalanlari.Size = new System.Drawing.Size(800, 235);
            this.grdHavaalanlari.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(342, 305);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 44);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmHavaalaniListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdHavaalanlari);
            this.Name = "frmHavaalaniListe";
            this.Text = "frmHavaalaniListe";
            this.Load += new System.EventHandler(this.frmHavaalaniListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHavaalanlari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHavaalanlari;
        private System.Windows.Forms.Button btnKaydet;
    }
}