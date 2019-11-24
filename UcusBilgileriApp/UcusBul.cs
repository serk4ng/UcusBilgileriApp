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
                frm.cmbHavayolu.Text = u.Id_Havayolu;
                frm.cmbKalkis.Text = u.Kalkis_Yeri_Id;
                frm.cmbVaris.Text = u.Varis_Yeri_Id;
                frm.txtKalkisTarih.Text = u.Kalkis_Tarih.ToString();
                frm.txtKalkisSaat.Text = u.Kalkis_Saat.ToString();
                frm.cmbVaris.Text = u.Varis_Tarih.ToString();
                frm.txtVarisSaat.Text = u.Varis_Saat.ToString();
                frm.txtTahminiSure.Text = u.Tahmini_Sure.ToString();
                frm.cmbUcak.Text = u.Id_Ucak;
                frm.ucus_Numarasi = u.Ucus_Numarasi;

            }
        }
    }
}
