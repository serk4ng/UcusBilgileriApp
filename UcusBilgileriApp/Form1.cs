using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UcusBilgileriApp.BLL;
using UcusBilgileriApp.MODELS;


namespace UcusBilgileriApp
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        public string ucus_numarasi = null;
        public Form1()
        {

            InitializeComponent();

            txtKalkisTarih.Format = DateTimePickerFormat.Custom;
            txtKalkisTarih.CustomFormat = "yyyy-M-d";
            txtVarisTarih.Format = DateTimePickerFormat.Custom;
            txtVarisTarih.CustomFormat = "yyyy-M-d";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            if (SecenekKontrol() == false)
            {
                CmbDropControl();
                return;
            }
            try
            {
                TimeSpan time = TimeSpan.Parse(txtKalkisSaat.Text);
                time.ToString();
                TimeSpan time2 = TimeSpan.Parse(txtVarisSaat.Text);
                time2.ToString();
                TimeSpan time3 = TimeSpan.Parse(txtTahminiSure.Text);
                time3.ToString();

                UcusBL u = new UcusBL();
                Ucus ucsK = new Ucus();

                ucsK.Ucus_Numarasi = txtUcusNumara.Text.Trim();
                //ucsK.Ucus_Numarasi = ucus_numarasi;
                ucsK.Id_Havayolu = cmbHavayolu.SelectedValue.ToString();
                ucsK.Kalkis_Yeri_Id = cmbKalkis.SelectedValue.ToString();
                ucsK.Varis_Yeri_Id = cmbVaris.SelectedValue.ToString();
                ucsK.Kalkis_Tarih = txtKalkisTarih.Value;
                ucsK.Kalkis_Saat = time;
                ucsK.Varis_Tarih = txtVarisTarih.Value;
                ucsK.Varis_Saat = time2;
                ucsK.Tahmini_Sure = time3;
                ucsK.Id_Ucak = cmbUcak.SelectedValue.ToString();

                if (ucus_numarasi == null)
                {
                    MessageBox.Show(u.Kaydet(ucsK) ? "Başarılı" : "Başarısız");
                }
                else
                {
                    if (u.Guncelle(ucsK))
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
            foreach (Control item in this.Controls["pnlUcusNo"].Controls)
            {
                item.Text = string.Empty;
            }
            foreach (Control item in this.Controls["pnlSaat"].Controls)
            {
                item.Text = string.Empty;
            }
            txtKalkisSaat.Text = string.Empty;
            btnKaydet.Text = "Ekle";
            ucus_numarasi = null;
            cmbHavayolu.SelectedIndex = 0;
            cmbKalkis.SelectedIndex = 0;
            cmbVaris.SelectedIndex = 0;
            cmbUcak.SelectedIndex = 0;
            btnVazgec.Visible = false;
            btnSil.Visible = false;
            txtUcusNumara.Enabled = true;
            lblUcusNo.Cursor = Cursors.Default;
            txtKalkisTarih.Value = DateTime.Now;
            txtVarisTarih.Value = DateTime.Now;

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            HavayoluBL hy = new HavayoluBL();
            cmbHavayolu.DisplayMember = "Havayolu_Adi";
            cmbHavayolu.ValueMember = "Id_Havayolu";
            cmbHavayolu.DataSource = hy.HavayoluListesi();

            HavaalaniBL ha = new HavaalaniBL();
            cmbKalkis.DisplayMember = "Yer_Adi";
            cmbKalkis.ValueMember = "Id_Yer";
            cmbKalkis.DataSource = ha.HavaalaniListesi();

            cmbVaris.DisplayMember = "Yer_Adi";
            cmbVaris.ValueMember = "Id_Yer";
            cmbVaris.DataSource = ha.HavaalaniListesi();

            UcakBL uc = new UcakBL();
            cmbUcak.DisplayMember = "Ucak_Adi";
            cmbUcak.ValueMember = "Id_Ucak";
            cmbUcak.DataSource = uc.UcakListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcusBul ucs = new UcusBul(this);
            ucs.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kayıt Silinecek. Eminminisiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (cvp == DialogResult.Yes)
            {
                UcusBL ubl = new UcusBL();
                if (ubl.UcusSil(ucus_numarasi))
                {
                    MessageBox.Show("Silme Başarılı!");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme hatalı!");
                }
                ubl.Dispose();
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi!");
                Temizle();

            }
        }

        private void Saat_KeyPress(object sender, KeyPressEventArgs e)
        {
            int a = (int)e.KeyChar;

            if ((a >= 48 && a <= 58) || a == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        public bool SecenekKontrol()
        {

            if (cmbHavayolu.SelectedIndex == 0 || cmbKalkis.SelectedIndex == 0 ||
            cmbVaris.SelectedIndex == 0 || cmbUcak.SelectedIndex == 0)
            {
                return false;
            }

            else
            {
                return true;
            }


        }
        public void CmbDropControl()
        {
            if (SecenekKontrol() == false)
            {
                if (cmbHavayolu.SelectedIndex == 0)
                {
                    MessageBox.Show("Havayolu Seçiniz");
                    cmbHavayolu.DroppedDown = true;
                }
                else if (cmbKalkis.SelectedIndex == 0)
                {
                    MessageBox.Show("Kalkış Yeri Seçiniz");
                    cmbKalkis.DroppedDown = true;
                }
                else if (cmbVaris.SelectedIndex == 0)
                {
                    MessageBox.Show("Varış Yeri Seçiniz");
                    cmbVaris.DroppedDown = true;
                }
                else if (cmbUcak.SelectedIndex == 0)
                {
                    MessageBox.Show("Ucak Seçiniz");
                    cmbUcak.DroppedDown = true;
                }
            }
        }
    }




}


