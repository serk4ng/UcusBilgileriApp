using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcusBilgileriApp.BLL;
using UcusBilgileriApp.MODELS;

namespace UcusBilgileriApp
{

    public partial class frmYolcuBul : Form
    {
        frmYolcuIslemleri frm;
        public frmYolcuBul()
        {
            InitializeComponent();
        }
        public frmYolcuBul(frmYolcuIslemleri frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            YolcuBL ybl = new YolcuBL();
            Yolcu y = ybl.YolcuBul(cmbAd.Text.Trim(),cmbSoyad.Text.Trim());

            if (y == null)
            {
                MessageBox.Show("Yolcu Bulunamadı");
            }
            else
            {
                
                frm.cmbAd.DisplayMember = "Ad";
                frm.cmbAd.ValueMember = "Ad";
                frm.cmbSoyad.DisplayMember = "Soyad";
                frm.cmbSoyad.ValueMember = "Soyad";
                frm.cmbUcusNumarasi.DisplayMember = "Ucus_Numarasi";
                frm.cmbUcusNumarasi.ValueMember = "Ucus_Numarasi";
                frm.cmbAd.DataSource = ybl.YolcuListesi(y.Ad, y.Soyad);
                frm.cmbSoyad.DataSource = ybl.YolcuListesi(y.Ad, y.Soyad);
                UcusBL ubl = new UcusBL();
                frm.cmbUcusNumarasi.DataSource = ubl.UcusNumarasiListesi();
                
                frm.cmbAd.SelectedValue= y.Ad;
                frm.cmbSoyad.SelectedValue = y.Soyad;

                frm.cmbUcusNumarasi.SelectedValue = y.Ucus_Numarasi;
                frm.ad = y.Ad;
                frm.soyad = y.Soyad;
                frm.ucus_numarasi = y.Ucus_Numarasi;
                frm.txtKoltukNo.Text = y.Koltuk_No;
                frm.cmbAd.Enabled = false;
                frm.cmbSoyad.Enabled = false;
                frm.btnVazgec.Visible = true;
                frm.btnSil.Visible = true;
                frm.btnEkle.Text = "Guncelle";
                this.Close();

            }
        }

        private void frmYolcuBul_Load(object sender, EventArgs e)
        {
            YolcuBL ybl = new YolcuBL();
            cmbAd.DisplayMember = "Ad";
            cmbAd.ValueMember = "Ad";
            cmbSoyad.DisplayMember = "Soyad";
            cmbSoyad.ValueMember = "Soyad";
            cmbUcusNo.DisplayMember = "Ucus_Numarasi";
            cmbUcusNo.ValueMember = "Ucus_Numarasi";

            cmbAd.DataSource = ybl.YolcuListesi();
            cmbSoyad.DataSource = ybl.YolcuListesi();
            cmbUcusNo.DataSource = ybl.YolcuListesi();

            
        }

        private void cmbAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexad = cmbAd.SelectedIndex;
            int indexsoyad = cmbSoyad.SelectedIndex;
            if (indexad != 0)
            {
                cmbSoyad.SelectedIndex = indexad;
                cmbUcusNo.SelectedIndex = indexad;
            }

            if (indexsoyad != 0)
            {
                cmbAd.SelectedIndex = indexsoyad;
                cmbUcusNo.SelectedIndex = indexsoyad;
            }

        }
    }
}
