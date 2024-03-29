﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcusBilgileriApp.BLL;
using UcusBilgileriApp.MODELS;

namespace UcusBilgileriApp
{
    public partial class UcusBul : Form
    {
        SqlConnection cn;
        Form1 frm;
        public UcusBul()
        {
            InitializeComponent();
        }

        public UcusBul(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                UcusBL ubl = new UcusBL();
                Ucus u = ubl.UcusBul(cmbUcusNo.SelectedValue.ToString());

                if (u == null)
                {
                    MessageBox.Show("Uçuş Bulunamadı");
                }
                else
                {
                    frm.txtUcusNumara.Text = u.Ucus_Numarasi;
                    frm.cmbHavayolu.SelectedValue = u.Id_Havayolu;
                    frm.cmbKalkis.SelectedValue = u.Kalkis_Yeri_Id;
                    frm.cmbVaris.SelectedValue = u.Varis_Yeri_Id;
                    frm.txtKalkisTarih.Value = u.Kalkis_Tarih;
                    frm.txtKalkisSaat.Text = u.Kalkis_Saat.ToString();
                    frm.txtVarisTarih.Value = u.Varis_Tarih;
                    frm.txtVarisSaat.Text = u.Varis_Saat.ToString();
                    frm.txtTahminiSure.Text = u.Tahmini_Sure.ToString();
                    frm.cmbUcak.SelectedValue = u.Id_Ucak;
                   // frm.ucus_numarasi = frm.txtUcusNumara.Text;
                    frm.ucus_numarasi = cmbUcusNo.SelectedValue.ToString();

                    frm.btnVazgec.Visible = true;
                    frm.btnSil.Visible = true;
                    frm.lblUcusNo.Cursor = Cursors.No;
                    frm.txtUcusNumara.Enabled = false;
                    frm.btnKaydet.Text = "Guncelle";
                    this.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void UcusBul_Load(object sender, EventArgs e)
        {
            UcusBL hy = new UcusBL();
            cmbUcusNo.DisplayMember = "Ucus_Numarasi";
            cmbUcusNo.ValueMember = "Ucus_Numarasi";
            cmbUcusNo.DataSource = hy.UcusNumarasiListesi();
        }
    }
}
