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
            ((System.ComponentModel.ISupportInitialize)(this.grdYolcular)).BeginInit();
            this.SuspendLayout();
            // 
            // grdYolcular
            // 
            this.grdYolcular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdYolcular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYolcular.Location = new System.Drawing.Point(102, 42);
            this.grdYolcular.Name = "grdYolcular";
            this.grdYolcular.Size = new System.Drawing.Size(601, 340);
            this.grdYolcular.TabIndex = 0;
            // 
            // frmYolcuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdYolcular);
            this.Name = "frmYolcuListele";
            this.Text = "frmYolcuListele";
            this.Load += new System.EventHandler(this.frmYolcuListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYolcular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdYolcular;
    }
}