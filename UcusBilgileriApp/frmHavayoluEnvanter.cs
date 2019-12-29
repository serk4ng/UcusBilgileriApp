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
    public partial class frmHavayoluEnvanter : Form
    {
        SqlConnection cn = null;
        public string id_havayolu = null;
        public string id_ucak = null;


        public frmHavayoluEnvanter()
        {
            InitializeComponent();
        }

        private void frmHavayoluEnvanter_Load(object sender, EventArgs e)
        {
            HavayoluBL hy = new HavayoluBL();
            cmbHavayolu.DisplayMember = "Havayolu_Adi";
            cmbHavayolu.ValueMember = "Id_Havayolu";
            cmbHavayolu.DataSource = hy.HavayoluListesi();

            UcakBL uc = new UcakBL();
            cmbUcak.DisplayMember = "Ucak_Adi";
            cmbUcak.ValueMember = "Id_Ucak";
            cmbUcak.DataSource = uc.UcakListesi();

        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            frmHavayoluEnvanterBul frm = new frmHavayoluEnvanterBul(this);
            frm.Show();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSil.Visible != true)
                {
                    if (SecenekKontrol())
                    {
                        CmbDropControl();
                        return;
                    }
                }
               

                HavayoluBL hbl = new HavayoluBL();
                Ucak u = new Ucak();
                u.Id_Havayolu = cmbHavayolu.SelectedValue.ToString();
                u.Id_Ucak = cmbUcak.SelectedValue.ToString();
                u.Adet = int.Parse(cmbAdet.Text.ToString());
                id_ucak = cmbUcak.SelectedValue.ToString();

                if (id_havayolu == null)
                {
                    MessageBox.Show(hbl.HavayoluEnvanterKaydet(u) ? "Başarılı" : "Başarısız");
                    Temizle();
                }
                else
                {
                    if (hbl.EnvanterGuncelle(u))
                    {
                        id_havayolu = null;
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
                    case 245:
                        MessageBox.Show("Sayısal Değerleri Doğru Giriniz.");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası" + ex.Number);
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sayısal Değerleri Doğru Giriniz.");
            }

            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }


        }

        void Temizle()
        {
            btnEkle.Text = "Ekle";
            HavayoluBL hy = new HavayoluBL();
            cmbHavayolu.DisplayMember = "Havayolu_Adi";
            cmbHavayolu.ValueMember = "Id_Havayolu";
            cmbHavayolu.DataSource = hy.HavayoluListesi();
            UcakBL uc = new UcakBL();
            cmbUcak.DisplayMember = "Ucak_Adi";
            cmbUcak.ValueMember = "Id_Ucak";
            cmbUcak.DataSource = uc.UcakListesi();
            cmbAdet.Text = "";
            cmbAdet.ResetText();
            
            id_havayolu = null;
            id_ucak = null;
            btnVazgec.Visible = false;
            btnSil.Visible = false;
            cmbHavayolu.Enabled = true;

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        public bool SecenekKontrol()
        {

            if (cmbHavayolu.SelectedIndex == 0 || cmbUcak.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void CmbDropControl()
        {
            if (btnSil.Visible != true)
            {
                if (cmbHavayolu.SelectedIndex == 0)
                {
                    MessageBox.Show("Havayolu Seçiniz");
                    cmbHavayolu.DroppedDown = true;
                }

                else if (cmbUcak.SelectedIndex == 0)
                {
                    MessageBox.Show("Ucak Seçiniz");
                    cmbUcak.DroppedDown = true;
                }
            }
            
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            id_ucak = cmbUcak.SelectedValue.ToString();
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Eminminisiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cvp == DialogResult.Yes)
            {
                HavayoluBL hbl = new HavayoluBL();
                if (hbl.HavayoluEnvanterSil(id_havayolu,id_ucak))
                {
                    MessageBox.Show("Silme Başarılı!");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme hatalı!");
                }

                hbl.Dispose();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!");
                Temizle();

            }
        }

        private void cmbUcak_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ucakindex = cmbUcak.SelectedIndex;
            int adetindex = cmbAdet.SelectedIndex;


            if (btnSil.Visible == true)
            {

                if (ucakindex != 0)
                {
                    adetindex = cmbAdet.SelectedIndex;
                    cmbAdet.SelectedIndex = ucakindex;
                }

            }
         
        }
    }

}
