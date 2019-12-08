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
    public partial class frmHavaalaniIslemleri : Form
    {

        SqlConnection cn = null;
        public string id_havaalani = null;

        public frmHavaalaniIslemleri()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            foreach (Control item in this.Controls["pnlText"].Controls)
            {
                item.Text = string.Empty;
            }
            btnEkle.Text = "Ekle";
            id_havaalani = null;
            txtHavaalaniID.Enabled = true;
            btnVazgec.Visible = false;
            btnSil.Visible = false;
            lblID.Cursor = Cursors.Default;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                HavaalaniBL hbl = new HavaalaniBL();
                Havaalani ha = new Havaalani();

                ha.Id_Yer = txtHavaalaniID.Text.Trim();
                ha.Yer_Adi = txtHavaalaniAdi.Text.Trim();


                if (id_havaalani == null)
                {
                    MessageBox.Show(hbl.HavaalaniKaydet(ha) ? "Başarılı" : "Başarısız");
                    Temizle();
                }
                else
                {
                    if (hbl.HavaalaniGuncelle(ha))
                    {
                        id_havaalani = null;
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
                HavaalaniBL hbl = new HavaalaniBL();
                if (hbl.HavaalaniSil(id_havaalani))
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

        private void btnBul_Click(object sender, EventArgs e)
        {
            frmHavaalaniBul frm = new frmHavaalaniBul(this);
            frm.Show();
        }
    }
    
}
