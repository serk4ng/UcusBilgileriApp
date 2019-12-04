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

        private void menuUcusBilgileriListeleme_Click(object sender, EventArgs e)
        {
            frmUcusListe frm = new frmUcusListe();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }


        private void menuHavayoluEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            frmHavayollariIslemleri frm = new frmHavayollariIslemleri();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuHavayollariListele_Click(object sender, EventArgs e)
        {
            frmHavayoluListe frm = new frmHavayoluListe();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void havayoluEnvanterKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavayoluEnvanter frm = new frmHavayoluEnvanter();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuHavayoluEnvanterListele_Click(object sender, EventArgs e)
        {
            frmHavayoluEnvanterListele frm = new frmHavayoluEnvanterListele();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
