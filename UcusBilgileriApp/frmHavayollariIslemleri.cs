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
    public partial class frmHavayollariIslemleri : Form
    {

        SqlConnection cn = null;
        public string id_havayolu = null;

        public frmHavayollariIslemleri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                HavayoluBL hbl = new HavayoluBL();
                Havayolu ha = new Havayolu();

                ha.Id_Havayolu = txtHavayoluID.Text.Trim();
                ha.Havayolu_Adi = txtHavayoluAdi.Text.Trim();


                if (id_havayolu == null)
                {
                    MessageBox.Show(hbl.Kaydet(ha) ? "Başarılı" : "Başarısız");
                }
                else
                {
                    if (hbl.Guncelle(ha))
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


        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            btnEkle.Text = "Ekle";
            id_havayolu = null;
            txtHavayoluID.Enabled = true;
            btnVazgec.Visible = false;
            btnSil.Visible = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmHavayoluBul frm = new frmHavayoluBul(this);
            frm.Show();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Eminminisiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cvp == DialogResult.Yes)
            {
                HavayoluBL hbl = new HavayoluBL();
                if (hbl.HavayoluSil(id_havayolu))
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

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
