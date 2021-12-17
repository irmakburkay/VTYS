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
            aboneEkle abone = new aboneEkle();
            fk.nav(abone);
            this.CenterToScreen();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baslangic();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abonelikEkle abnlk = new abonelikEkle();
            fk.nav(abnlk);
            this.CenterToScreen();
        }
    }
}
