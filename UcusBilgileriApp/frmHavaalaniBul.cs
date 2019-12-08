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
    public partial class frmHavaalaniBul : Form
    {

        frmHavaalaniIslemleri frm;
        public frmHavaalaniBul()
        {
            InitializeComponent();
        }

        public frmHavaalaniBul(frmHavaalaniIslemleri frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmHavaalaniBul_Load(object sender, EventArgs e)
        {
            HavaalaniBL hy = new HavaalaniBL();
            cmbHavaalani.DisplayMember = "Yer_Adi";
            cmbHavaalani.ValueMember = "Id_Yer";
            cmbHavaalani.DataSource = hy.HavaalaniListesi();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            HavaalaniBL hbl = new HavaalaniBL();
            Havaalani ha = hbl.HavaalaniBul((string)cmbHavaalani.SelectedValue);

            if (ha == null)
            {
                MessageBox.Show("Havaalani Bulunamadı");
            }
            else
            {
                frm.txtHavaalaniID.Text = ha.Id_Yer;
                frm.txtHavaalaniAdi.Text = ha.Yer_Adi;
                frm.id_havaalani = ha.Id_Yer;

                frm.btnVazgec.Visible = true;
                frm.btnSil.Visible = true;
                frm.lblID.Cursor = Cursors.No;
                frm.txtHavaalaniID.Enabled = false;
                frm.btnEkle.Text = "Guncelle";
                this.Close();
            }

        }
    }
}
