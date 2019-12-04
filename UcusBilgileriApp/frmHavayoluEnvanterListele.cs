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

namespace UcusBilgileriApp
{
    public partial class frmHavayoluEnvanterListele : Form
    {
        public frmHavayoluEnvanterListele()
        {
            InitializeComponent();
        }

        private void frmHavayoluEnvanterListele_Load(object sender, EventArgs e)
        {
            HavayoluBL hbl = new HavayoluBL();
            grdHavayoluEnvanter.DataSource = hbl.HavayollariEnvanterTable();
            hbl.Dispose();
        }
    }
}
