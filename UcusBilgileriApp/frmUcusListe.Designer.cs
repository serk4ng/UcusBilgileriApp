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
            ((System.ComponentModel.ISupportInitialize)(this.grdUcusBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // grdUcusBilgileri
            // 
            this.grdUcusBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUcusBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUcusBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUcusBilgileri.Location = new System.Drawing.Point(0, 0);
            this.grdUcusBilgileri.Name = "grdUcusBilgileri";
            this.grdUcusBilgileri.Size = new System.Drawing.Size(806, 405);
            this.grdUcusBilgileri.TabIndex = 0;
            // 
            // frmUcusListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 405);
            this.Controls.Add(this.grdUcusBilgileri);
            this.Name = "frmUcusListe";
            this.Text = "frmUcusListe";
            this.Load += new System.EventHandler(this.frmUcusListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUcusBilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUcusBilgileri;
    }
}