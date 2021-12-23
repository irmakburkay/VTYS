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

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboneRapor abone = new aboneRapor();
            fk.nav(abone);
            this.CenterToScreen();
        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abonelikRapor abonelikRapor = new abonelikRapor();
            fk.nav(abonelikRapor);
            this.CenterToScreen();
        }

        private void raporlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dergiGazateRapor dergiGazateRapor = new dergiGazateRapor();
            fk.nav(dergiGazateRapor);
            this.CenterToScreen();
        }

        private void raporlaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            turRapor turRapor = new turRapor();
            fk.nav(turRapor);
            this.CenterToScreen();
        }

        private void raporlaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fiyatRapor fiyatRapor = new fiyatRapor();
            fk.nav(fiyatRapor);
            this.CenterToScreen();
        }

        private void raporToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            personelRapor personelRapor = new personelRapor();
            fk.nav(personelRapor);
            this.CenterToScreen();
        }

        private void raporlaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bolumRapor bolumRapor = new bolumRapor();
            fk.nav(bolumRapor);
            this.CenterToScreen();
        }

        private void yedekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msSQL ms = new msSQL();
            try
            {
                ms.sqlIslem("use JAS exec backupdatabase");
                MessageBox.Show("Yedekleme Başarıyla Tamamlandı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yedekleme İşlemi Tamamlanamadı!\n"+ex.Message);
                throw;
            }
        }

        private void geriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msSQL ms = new msSQL("master");
            try
            {
                ms.sqlIslem("USE [master] ALTER DATABASE[JAS] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE[JAS] FROM  DISK = N'D:\\JAS.bak' WITH  FILE = 8, NOUNLOAD, REPLACE, STATS = 5 ALTER DATABASE[JAS] SET MULTI_USER"); 
                MessageBox.Show("Geri Yükleme Başarıyla Tamamlandı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geri Yükleme İşlemi Tamamlanamadı!\n" + ex.Message);
                throw;
            }
        }

        private void nvbrGenelRaporlar_Click(object sender, EventArgs e)
        {
            genelRapor genelRapor = new genelRapor();
            fk.nav(genelRapor);
            this.CenterToScreen();
        }
    }
}
