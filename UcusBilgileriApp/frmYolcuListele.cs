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
    public partial class frmYolcuListele : Form
    {
        public frmYolcuListele()
        {
            InitializeComponent();
        }

        private void frmYolcuListele_Load(object sender, EventArgs e)
        {
            YolcuBL ybl = new YolcuBL();
            grdYolcular.DataSource = ybl.YolcuTable();
            ybl.Dispose();
        }
    }
}
