namespace UcusBilgileriApp
{
    partial class frmHavayoluEnvanterBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHavayoluEnvanterBul));
            this.btnBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHavayolu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(132, 99);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Havayolu Seçiniz :";
            // 
            // cmbHavayolu
            // 
            this.cmbHavayolu.FormattingEnabled = true;
            this.cmbHavayolu.Location = new System.Drawing.Point(113, 63);
            this.cmbHavayolu.Name = "cmbHavayolu";
            this.cmbHavayolu.Size = new System.Drawing.Size(121, 21);
            this.cmbHavayolu.TabIndex = 3;
            // 
            // frmHavayoluEnvanterBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 232);
            this.Controls.Add(this.cmbHavayolu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBul);
            this.Name = "frmHavayoluEnvanterBul";
            this.Text = "frmHavayoluEnvanterBul";
            this.Load += new System.EventHandler(this.frmHavayoluEnvanterBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.ComboBox cmbHavayolu;
    }
}