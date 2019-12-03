using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcusBilgileriApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuUcusEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.WindowState = FormWindowState.Maximized;

            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
