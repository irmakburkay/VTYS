using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS
{
    public partial class MainForm : Form
    { 

        public MainForm()
        {
            InitializeComponent();
        }

        public void baslangic()
        {
            MainForm mf = Application.OpenForms["MainForm"] as MainForm;
            mf.Opacity = 0;
            mf.mainPanel.Controls.Clear();
            mf.Width = 800;
            mf.Height = 450;
            kullaniciGiris kg = new kullaniciGiris();
            kg.StartPosition = FormStartPosition.CenterScreen;
            kg.Show();
            this.CenterToScreen();
        }
        fonksiyon fk = new fonksiyon();

        public void MainForm_Load(object sender, EventArgs e)
        {
            baslangic();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abone abone = new abone();
            fk.nav(abone);
            this.CenterToScreen();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baslangic();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abonelik abnlk = new abonelik();
            fk.nav(abnlk);
            this.CenterToScreen();
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dergiGazete dergi = new dergiGazete();
            fk.nav(dergi);
            this.CenterToScreen();
        }

        private void ekleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tur tur = new tur();
            fk.nav(tur);
            this.CenterToScreen();
        }

        private void ekleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            fiyatTipi fiyat = new fiyatTipi();
            fk.nav(fiyat);
            this.CenterToScreen();
        }

        private void ekleToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            personel prsnl = new personel();
            fk.nav(prsnl);
            this.CenterToScreen();
        }

        private void ekleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bolum blm = new bolum();
            fk.nav(blm);
            this.CenterToScreen();
        }
    }
}
