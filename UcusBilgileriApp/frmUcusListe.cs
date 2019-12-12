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
    public partial class frmUcusListe : Form
    {
        DataTable dt;
        public frmUcusListe()
        {
            InitializeComponent();
            grdUcusBilgileri.AutoGenerateColumns = false;
        }

        private void frmUcusListe_Load(object sender, EventArgs e)
        {
            UcusBL ubl = new UcusBL();
            dt = ubl.UcusBilgileriTable3();
            grdUcusBilgileri.DataSource = dt;
            ubl.Dispose();

            UcakBL ucbl = new UcakBL();
            clmUcak.DataSource = ucbl.UcakListesi();
            clmUcak.DisplayMember = "Ucak_Adi";
            clmUcak.ValueMember = "Id_Ucak";
            ucbl.Dispose();

            HavayoluBL hbl = new HavayoluBL();
            clmHavayolu.DataSource = hbl.HavayoluListesi();
            clmHavayolu.DisplayMember = "Havayolu_Adi";
            clmHavayolu.ValueMember = "Id_Havayolu";
            hbl.Dispose();

            HavaalaniBL habl = new HavaalaniBL();
            clmKalkisYeri.DataSource = habl.HavaalaniListesi();
            clmKalkisYeri.DisplayMember = "Yer_Adi";
            clmKalkisYeri.ValueMember = "Id_Yer";

            clmVarisYeri.DataSource = habl.HavaalaniListesi();
            clmVarisYeri.DisplayMember = "Yer_Adi";
            clmVarisYeri.ValueMember = "Id_Yer2";

            habl.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            UcusBL ubl = new UcusBL();

            foreach (DataRow item in dt.Rows)
            {

                Ucus u = new Ucus();
                if (item.RowState != DataRowState.Deleted)
                {

                    /*for (int i = 0; i < 25; i++)
                    {
                        MessageBox.Show(item[i].ToString());
                    }
                    */

                    u.Ucus_Numarasi = item[0].ToString();
                    u.Id_Havayolu = item[2].ToString();
                    u.Kalkis_Yeri_Id = item[19].ToString();
                    u.Varis_Yeri_Id = item[20].ToString();
                    u.Kalkis_Tarih = Convert.ToDateTime(item[7].ToString());
                    u.Kalkis_Saat = TimeSpan.Parse(item[8].ToString());
                    u.Varis_Tarih = Convert.ToDateTime(item[9].ToString());
                    u.Varis_Saat = TimeSpan.Parse(item[10].ToString());
                    u.Tahmini_Sure = TimeSpan.Parse(item[11].ToString());
                    u.Id_Ucak = item[13].ToString();

                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        if (ubl.Kaydet(u))
                        {
                            MessageBox.Show(u.Ucus_Numarasi + " Numaralı Ucus Eklendi");
                        }
                        break;
                    case DataRowState.Deleted:
                        if (ubl.UcusSil((string)(item[0, DataRowVersion.Original])))
                        {
                            MessageBox.Show(item[0, DataRowVersion.Original] + " Numaralı Ucus Silindi");
                        }
                        break;
                    case DataRowState.Modified:
                        if (ubl.Guncelle(u))
                        {
                            MessageBox.Show(u.Ucus_Numarasi + " Numaralı Ucus Guncellendi");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
