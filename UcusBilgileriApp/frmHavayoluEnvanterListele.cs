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
    public partial class frmHavayoluEnvanterListele : Form
    {
        DataTable dt;
        public frmHavayoluEnvanterListele()
        {
            InitializeComponent();
            grdHavayoluEnvanter.AutoGenerateColumns = false;

        }

        private void frmHavayoluEnvanterListele_Load(object sender, EventArgs e)
        {
            HavayoluBL hbl = new HavayoluBL();
            dt = hbl.HavayollariEnvanterTable();
            grdHavayoluEnvanter.DataSource = dt;

            clmHavayoluAdi.DataSource = hbl.HavayoluListesi();
            clmHavayoluAdi.DisplayMember = "Havayolu_Adi";
            clmHavayoluAdi.ValueMember = "Havayolu_Adi";
            hbl.Dispose();

            UcakBL ubl = new UcakBL();
            clmUcakAdi.DataSource = ubl.UcakListesi();
            clmUcakAdi.DisplayMember = "Ucak_Adi";
            clmUcakAdi.ValueMember = "Ucak_Adi";
            ubl.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            HavayoluBL hbl = new HavayoluBL();

            foreach (DataRow item in dt.Rows)
            {
                Ucak u = new Ucak();
                if (item.RowState != DataRowState.Deleted)
                {
                    u.Id_Havayolu = item[0].ToString();
                    u.Id_Ucak = item[1].ToString();
                    u.Adet = Convert.ToInt32(item[2].ToString());

                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        hbl.HavayoluEnvanterKaydet(u);
                        MessageBox.Show("Eklendi");
                        break;
                    case DataRowState.Deleted:
                        hbl.HavayoluEnvanterSil((string)(item[0, DataRowVersion.Original]), (string)(item[1, DataRowVersion.Original]));
                        MessageBox.Show("Silindi");
                        break;
                    case DataRowState.Modified:
                        u.Id_Havayolu = item[0].ToString();
                        u.Id_Ucak = item[2].ToString();
                        hbl.EnvanterGuncelle(u);
                        MessageBox.Show("Guncellendi");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
