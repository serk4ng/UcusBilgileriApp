namespace UcusBilgileriApp
{
    partial class frmHavayoluListe
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
            this.grdHavayollari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayollari)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHavayollari
            // 
            this.grdHavayollari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHavayollari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHavayollari.Location = new System.Drawing.Point(12, 12);
            this.grdHavayollari.Name = "grdHavayollari";
            this.grdHavayollari.Size = new System.Drawing.Size(776, 344);
            this.grdHavayollari.TabIndex = 0;
            // 
            // frmHavayoluListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdHavayollari);
            this.Name = "frmHavayoluListe";
            this.Text = "frmHavaalaniListe";
            this.Load += new System.EventHandler(this.frmHavayoluListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayollari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHavayollari;
    }
}