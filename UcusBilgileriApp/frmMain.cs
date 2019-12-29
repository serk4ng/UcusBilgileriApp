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

        private void menuHavaalaniEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            frmHavaalaniIslemleri frm = new frmHavaalaniIslemleri();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuHavaalanlariniListele_Click(object sender, EventArgs e)
        {
            frmHavaalaniListe frm = new frmHavaalaniListe();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuYolcuEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            frmYolcuIslemleri frm = new frmYolcuIslemleri();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuYolculariListele_Click(object sender, EventArgs e)
        {
            frmYolcuListele frm = new frmYolcuListele();
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.MdiParent = this;
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
        }
    }
}
