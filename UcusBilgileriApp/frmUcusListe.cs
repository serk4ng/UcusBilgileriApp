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
    public partial class frmUcusListe : Form
    {
        public frmUcusListe()
        {
            InitializeComponent();
        }

        private void frmUcusListe_Load(object sender, EventArgs e)
        {
            UcusBL ubl = new UcusBL();
            grdUcusBilgileri.DataSource = ubl.UcusBilgileriTable();
            ubl.Dispose();
        }
    }
}
