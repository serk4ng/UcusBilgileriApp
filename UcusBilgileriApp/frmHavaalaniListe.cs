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
    public partial class frmHavaalaniListe : Form
    {
        public frmHavaalaniListe()
        {
            InitializeComponent();
        }

        private void frmHavaalaniListe_Load(object sender, EventArgs e)
        {
            HavaalaniBL hbl = new HavaalaniBL();
            grdHavaalanlari.DataSource = hbl.HavaalaniDataGridListesi();
            hbl.Dispose();
        }
    }
}
