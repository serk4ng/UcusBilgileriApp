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
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayoluEnvanter)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHavayoluEnvanter
            // 
            this.grdHavayoluEnvanter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHavayoluEnvanter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHavayoluEnvanter.Location = new System.Drawing.Point(47, 30);
            this.grdHavayoluEnvanter.Name = "grdHavayoluEnvanter";
            this.grdHavayoluEnvanter.Size = new System.Drawing.Size(675, 321);
            this.grdHavayoluEnvanter.TabIndex = 0;
            // 
            // frmHavayoluEnvanterListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdHavayoluEnvanter);
            this.Name = "frmHavayoluEnvanterListele";
            this.Text = "frmHavayoluEnvanterListele";
            this.Load += new System.EventHandler(this.frmHavayoluEnvanterListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayoluEnvanter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHavayoluEnvanter;
    }
}