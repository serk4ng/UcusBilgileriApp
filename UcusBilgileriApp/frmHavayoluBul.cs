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
    public partial class frmHavayoluBul : Form
    {
        frmHavayollariIslemleri frm;
        public frmHavayoluBul()
        {
            InitializeComponent();
        }

        public frmHavayoluBul(frmHavayollariIslemleri frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            HavayoluBL hbl = new HavayoluBL();
            Havayolu ha = hbl.HavayoluBul((string)cmbHavayolu.SelectedValue);

            if (ha == null)
            {
                MessageBox.Show("Havayolu Bulunamadı");
            }
            else
            {
                frm.txtHavayoluID.Text = ha.Id_Havayolu;
                frm.txtHavayoluAdi.Text = ha.Havayolu_Adi;
                frm.id_havayolu = ha.Id_Havayolu;
                
                frm.btnVazgec.Visible = true;
                frm.btnSil.Visible = true;
                frm.lblHavaalaniID.Cursor = Cursors.No;
                frm.txtHavayoluID.Enabled = false;
                frm.btnEkle.Text = "Guncelle";
            }


        }

        private void frmHavayoluBul_Load(object sender, EventArgs e)
        {
            HavayoluBL hy = new HavayoluBL();
            cmbHavayolu.DisplayMember = "Havayolu_Adi";
            cmbHavayolu.ValueMember = "Id_Havayolu";
            cmbHavayolu.DataSource = hy.HavayoluListesi();
        }
    }
}
