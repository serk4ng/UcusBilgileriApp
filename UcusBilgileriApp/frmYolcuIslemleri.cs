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
    public partial class frmYolcuIslemleri : Form
    {

        SqlConnection cn = null;
        public string ad = null;
        public string soyad = null;
        public string ucus_numarasi = null;
        public frmYolcuIslemleri()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmYolcuBul frm = new frmYolcuBul(this);
            frm.Show();
        }


        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            btnEkle.Text = "Ekle";
            ucus_numarasi = null;
            btnVazgec.Visible = false;
            btnSil.Visible = false;       
            cmbUcusNumarasi.SelectedIndex = 0;
            cmbAd.Enabled = true;
            cmbSoyad.Enabled = true;
            txtKoltukNo.Clear();
            


            YolcuBL ybl = new YolcuBL();
            cmbUcusNumarasi.DisplayMember = "Ucus_Numarasi";
            cmbUcusNumarasi.ValueMember = "Ucus_Numarasi";
            cmbUcusNumarasi.DataSource = ybl.YolcuListesi();

            cmbAd.ResetText();
            cmbSoyad.ResetText();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                YolcuBL ybl = new YolcuBL();
                Yolcu y = new Yolcu();

                y.Ad = cmbAd.Text.Trim();
                y.Soyad = cmbSoyad.Text.Trim();
                y.Ucus_Numarasi = cmbUcusNumarasi.Text.Trim();
                y.Koltuk_No = txtKoltukNo.Text.Trim();

                if (ucus_numarasi == null)
                {
                    MessageBox.Show(ybl.YolcuKaydet(y) ? "Başarılı" : "Başarısız");
                    Temizle();
                }
                else
                {
                    if (ybl.YolcuGuncelle(y))
                    {
                        ucus_numarasi = null;
                        Temizle();
                        MessageBox.Show("Güncelleme Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız!");
                    }
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    default:
                        MessageBox.Show("Veritabanı Hatası" + ex.Number);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Eminminisiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cvp == DialogResult.Yes)
            {
                YolcuBL ybl = new YolcuBL();
                if (ybl.YolcuSil(ad,soyad))
                {
                    MessageBox.Show("Silme Başarılı!");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme hatalı!");
                }
                ybl.Dispose();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!");
                Temizle();

            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void frmYolcuIslemleri_Load(object sender, EventArgs e)
        {
            UcusBL ubl = new UcusBL();
            cmbUcusNumarasi.DisplayMember = "Ucus_Numarasi";
            cmbUcusNumarasi.ValueMember = "Ucus_Numarasi";
            cmbUcusNumarasi.DataSource = ubl.UcusNumarasiListesi();
            /*
            YolcuBL ybl = new YolcuBL();
            cmbAd.DisplayMember = "Ad";
            cmbAd.ValueMember = "Ad";
            cmbAd.DataSource = ybl.YolcuListesi();

            cmbSoyad.DisplayMember = "Soyad";
            cmbSoyad.ValueMember = "Soyad";
            cmbSoyad.DataSource = ybl.YolcuListesi();
            */
        }

        private void cmbAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexad = cmbAd.SelectedIndex;
            int indexsoyad = cmbSoyad.SelectedIndex;

            if (indexad != 0 && indexsoyad !=0)
            {
               cmbSoyad.SelectedIndex = indexad;
               cmbUcusNumarasi.SelectedIndex = indexad;
            }       
        }

        private void cmbSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexsoyad = cmbSoyad.SelectedIndex;

            if (indexsoyad != 0)
            {
                cmbAd.SelectedIndex = indexsoyad;
                cmbUcusNumarasi.SelectedIndex = indexsoyad;
            }
        }
    }
}
