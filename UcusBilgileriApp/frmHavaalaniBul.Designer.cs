﻿namespace UcusBilgileriApp
{
    partial class frmHavaalaniBul
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
            this.btnBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHavaalani = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(134, 109);
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
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Havaalani Seciniz :";
            // 
            // cmbHavaalani
            // 
            this.cmbHavaalani.FormattingEnabled = true;
            this.cmbHavaalani.Location = new System.Drawing.Point(118, 59);
            this.cmbHavaalani.Name = "cmbHavaalani";
            this.cmbHavaalani.Size = new System.Drawing.Size(121, 21);
            this.cmbHavaalani.TabIndex = 3;
            // 
            // frmHavaalaniBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 217);
            this.Controls.Add(this.cmbHavaalani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBul);
            this.Name = "frmHavaalaniBul";
            this.Text = "frmHavaalaniBul";
            this.Load += new System.EventHandler(this.frmHavaalaniBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHavaalani;
    }
}