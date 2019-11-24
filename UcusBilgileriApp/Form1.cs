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
        public string ucus_Numarasi =null;
        public Form1()
        {

            InitializeComponent();

            //cmbKalkis.Items.Add("TR1");
            //cmbKalkis.Items.Add("DE1");

            txtKalkisTarih.Format = DateTimePickerFormat.Custom;
            txtKalkisTarih.CustomFormat = "d/M/yyyy";
            txtVarisTarih.Format = DateTimePickerFormat.Custom;
            txtVarisTarih.CustomFormat = "d/M/yyyy";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnKaydet_Click(object sender, EventArgs e)
        {
           
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
                ucsK.Id_Havayolu = cmbHavayolu.SelectedValue.ToString();
                ucsK.Kalkis_Yeri_Id = cmbKalkis.SelectedValue.ToString();
                ucsK.Varis_Yeri_Id = cmbVaris.SelectedValue.ToString();
                ucsK.Kalkis_Tarih = txtKalkisTarih.Value;
                ucsK.Kalkis_Saat = time;
                ucsK.Varis_Tarih = txtVarisTarih.Value;
                ucsK.Varis_Saat = time2;
                ucsK.Tahmini_Sure = time3;
                ucsK.Id_Ucak = cmbUcak.SelectedValue.ToString();
               
                
                MessageBox.Show(u.Kaydet(ucsK) ? "Başarılı" : "Başarısız");

                //if (u.Guncelle(ucsK))
                //{
                //    MessageBox.Show("Güncelleme Başarılı");
                //}
                //else
                //{
                //    MessageBox.Show("Güncelleme Başarısız");
                //}
             
                // txtKalkisCombo.Items.AddRange("@Kalkis_Yeri_Id", ucs.Kalkis_Yeri_Id);
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

       
        
    }
    



}


