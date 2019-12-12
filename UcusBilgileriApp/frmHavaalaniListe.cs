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
    public partial class frmHavaalaniListe : Form
    {
        DataTable dt;
        public frmHavaalaniListe()
        {
            InitializeComponent();
            grdHavaalanlari.AutoGenerateColumns = false;
        }
        private void frmHavaalaniListe_Load(object sender, EventArgs e)
        {
            HavaalaniBL hbl = new HavaalaniBL();
            dt = hbl.HavaalanlariTable();
            grdHavaalanlari.DataSource = dt;
            hbl.Dispose();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HavaalaniBL hbl = new HavaalaniBL();

            foreach (DataRow item in dt.Rows)
            {

                Havaalani h = new Havaalani();
                if (item.RowState != DataRowState.Deleted)
                {
                    h.Id_Yer = item[0].ToString();
                    h.Yer_Adi = item[2].ToString();
                }

                switch (item.RowState)
                {
                    case DataRowState.Added:
                        hbl.HavaalaniKaydet(h);
                        MessageBox.Show("Eklendi");
                        break;
                    case DataRowState.Deleted:
                        hbl.HavaalaniSil((string)(item[0, DataRowVersion.Original]));
                        MessageBox.Show("Silindi");
                        break;
                    case DataRowState.Modified:
                        h.Id_Yer = item[0].ToString();
                        hbl.HavaalaniGuncelle(h);
                        MessageBox.Show("Guncellendi");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
