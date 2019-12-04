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
    public partial class frmHavayoluEnvanterBul : Form
    {
        frmHavayoluEnvanter frm;

        public frmHavayoluEnvanterBul()
        {
            InitializeComponent();
        }

        public frmHavayoluEnvanterBul(frmHavayoluEnvanter frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmHavayoluEnvanterBul_Load(object sender, EventArgs e)
        {
            HavayoluBL hy = new HavayoluBL();
            cmbHavayolu.DisplayMember = "Havayolu_Adi";
            cmbHavayolu.ValueMember = "Id_Havayolu";
            cmbHavayolu.DataSource = hy.HavayoluListesi();
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
                frm.cmbHavayolu.SelectedValue = ha.Id_Havayolu;
                frm.cmbUcak.SelectedValue = ha.Havayolu_Adi;
                frm.txtAdet.Text = ha.Adet.ToString();
                frm.id_havayolu = ha.Id_Havayolu;

                frm.btnVazgec.Visible = true;
                frm.btnSil.Visible = true;
                frm.btnEkle.Text = "Guncelle";
            }
        }
    }
}
