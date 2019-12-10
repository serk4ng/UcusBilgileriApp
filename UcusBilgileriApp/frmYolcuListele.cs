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
    public partial class frmYolcuListele : Form
    {
        DataTable dt;
        public frmYolcuListele()
        {
            InitializeComponent();
            grdYolcular.AutoGenerateColumns = false;
        }

        private void frmYolcuListele_Load(object sender, EventArgs e)
        {
            YolcuBL ybl = new YolcuBL();
            dt = ybl.YolcuTable();
            grdYolcular.DataSource = dt;
            ybl.Dispose();

            UcusBL ubl = new UcusBL();
            clmUcusNumarasi.DataSource = ubl.UcusNumarasiListesi();
            clmUcusNumarasi.DisplayMember = "Ucus_Numarasi";
            clmUcusNumarasi.ValueMember = "Ucus_Numarasi";
            ubl.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YolcuBL ybl = new YolcuBL();

            foreach (DataRow item in dt.Rows)
            {

                Yolcu y = new Yolcu();
                if (item.RowState != DataRowState.Deleted)
                {
                    y.Ad = item[0].ToString();
                    y.Soyad = item[1].ToString();
                    y.Ucus_Numarasi = item[2].ToString();
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        ybl.YolcuKaydet(y);
                        MessageBox.Show("Eklendi");
                        break;
                    case DataRowState.Deleted:
                        ybl.YolcuSil((string)(item[0, DataRowVersion.Original]), (string)(item[1, DataRowVersion.Original]));
                        MessageBox.Show("Silindi");
                        break;
                    case DataRowState.Modified:
                        y.Ad = item[0].ToString();
                        y.Soyad = item[1].ToString();
                        ybl.YolcuGuncelle(y);
                        MessageBox.Show("Guncellendi");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
