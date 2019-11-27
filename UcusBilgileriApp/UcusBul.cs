using System;
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

            UcusBL ubl = new UcusBL();
            Ucus u = ubl.UcusBul(txtUcusNo.Text.Trim());

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
                frm.ucus_numarasi = frm.txtUcusNumara.Text;

                frm.btnVazgec.Visible = true;
                frm.btnSil.Visible = true;
                frm.txtUcusNumara.Enabled = false;
                frm.btnKaydet.Text = "Guncelle";

            }


        }
    }
}
