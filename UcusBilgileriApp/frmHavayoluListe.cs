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

    public partial class frmHavayoluListe : Form
    {
        DataTable dt;
        public frmHavayoluListe()
        {
            InitializeComponent();
        }

        private void frmHavayoluListe_Load(object sender, EventArgs e)
        {
            HavayoluBL hbl = new HavayoluBL();
            dt = hbl.HavayollariTable();
            grdHavayollari.DataSource = dt;
            hbl.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {        
            HavayoluBL hbl = new HavayoluBL();

            foreach (DataRow item in dt.Rows)
            {

                Havayolu h = new Havayolu();
                if (item.RowState != DataRowState.Deleted)
                {
                    h.Id_Havayolu = item[0].ToString();
                    h.Havayolu_Adi = item[1].ToString();
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        hbl.Kaydet(h);
                        MessageBox.Show("Eklendi");
                        break;
                    case DataRowState.Deleted:
                        hbl.HavayoluSil((string)(item[0, DataRowVersion.Original]));
                        MessageBox.Show("Silindi");
                        break;
                    case DataRowState.Modified:
                        h.Id_Havayolu = item[0].ToString();
                        hbl.Guncelle(h);
                        MessageBox.Show("Guncellendi");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
