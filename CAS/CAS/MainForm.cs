using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS
{
    public partial class MainForm : Form
    {

        public bool tasi = false;
        public Point nokta = new Point(0, 0);

        public MainForm()
        {
            InitializeComponent();
        }

        public void yetki()
        {
            kullaniciGiris kgs = Application.OpenForms["kullaniciGiris"] as kullaniciGiris;
            string bolum = string.Empty;
            //abonelik rapor, içerik rapor
            //0 herşey açık
            //1 database personel bolumdüzenle kapalı
            //2 database personel tüm düzenlemelere kapalı genel rapor açık
            //3 tüm raporlar (personel hariç) genel rapor kapalı
            int check = -1;
            if (kgs.blm == "1") check = 0;
            if (kgs.blm == "2") check = 1;
            if (kgs.blm == "3") check = 2;
            if (kgs.blm == "4") check = 3;
            switch (check)
            {
                case 0:
                    show(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                    break;
                case 1:
                    show(true, true, true, true, true, true, true, true, true, true, false, false, false, true, true, false, false);
                    break;
                case 2:
                    show(false, true, false, true, false, true, false, true, false, true, false, false, false, true, true, false, false);
                    break;
                case 3:
                    show(false, true, false, true, false, true, false, true, false, true, false, false, false, true, false, false, false);
                    break;
            }
        }
        
        public void menuShow(ToolStripMenuItem item, bool isEnabled)
        {
            item.Enabled = isEnabled;
            if (isEnabled)
                item.ToolTipText = null;
            else
                item.ToolTipText = "Bu Alanı Kullanmak İçin Yetkiniz Yoktur!";
        }
        public void show(bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7, bool b8, bool b9, bool b10, bool b11, bool b12, bool b13, bool b14, bool b15, bool b16, bool b17)
        {
            menuShow(aboneDuzenle, b1);
            menuShow(raporToolStripMenuItem, b2);
            menuShow(abonelikDuzenle, b3);
            menuShow(raporlaToolStripMenuItem, b4);
            menuShow(dergiDuzenle, b5);
            menuShow(dergiRapor, b6);
            menuShow(turDuzenle, b7);
            menuShow(turRapor, b8);
            menuShow(fiyatDuzenle, b9);
            menuShow(fiyatRapor, b10);
            menuShow(personelDuzenle, b11);
            menuShow(personelRapor, b12);
            menuShow(bolumDuzenle, b13);
            menuShow(bolumRapor, b14);
            menuShow(nvbrGenelRaporlar, b15);
            menuShow(yedekleToolStripMenuItem, b16);
            menuShow(geriYükleToolStripMenuItem, b17);
        }


        fonksiyon fk = new fonksiyon();

        public void MainForm_Load(object sender, EventArgs e)
        {
            yetki();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abone abone = new abone();
            fk.nav(abone);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciGiris kg = Application.OpenForms["kullaniciGiris"] as kullaniciGiris;
            kg.kullaniciAdi().Text = string.Empty;
            kg.sifre().Text = string.Empty;
            kg.Show();
            this.Close();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abonelik abnlk = new abonelik();
            fk.nav(abnlk);
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dergiGazete dergi = new dergiGazete();
            fk.nav(dergi);
        }

        private void ekleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tur tur = new tur();
            fk.nav(tur);
        }

        private void ekleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            fiyatTipi fiyat = new fiyatTipi();
            fk.nav(fiyat);
        }

        private void ekleToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            personel prsnl = new personel();
            fk.nav(prsnl);
        }

        private void ekleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bolum blm = new bolum();
            fk.nav(blm);
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboneRapor abone = new aboneRapor();
            fk.nav(abone);
        }

        private void raporlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abonelikRapor abonelikRapor = new abonelikRapor();
            fk.nav(abonelikRapor);
        }

        private void raporlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dergiGazateRapor dergiGazateRapor = new dergiGazateRapor();
            fk.nav(dergiGazateRapor);
        }

        private void raporlaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            turRapor turRapor = new turRapor();
            fk.nav(turRapor);
        }

        private void raporlaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fiyatRapor fiyatRapor = new fiyatRapor();
            fk.nav(fiyatRapor);
        }

        private void raporToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            personelRapor personelRapor = new personelRapor();
            fk.nav(personelRapor);
        }

        private void raporlaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bolumRapor bolumRapor = new bolumRapor();
            fk.nav(bolumRapor);
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
                MessageBox.Show("Yedekleme İşlemi Tamamlanamadı!\n" + ex.Message);
                throw;
            }
        }

        public void preRestore()
        {

            bekleLabel.Text = "İşleminiz Gerçekleştiriliyor. Lütfen Bekleyin!";
        }

        public void forRestore()
        {
            msSQL ms = new msSQL("master");
            try
            {
                ms.sqlIslem("USE [master] ALTER DATABASE[JAS] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE[JAS] FROM  DISK = N'D:\\JAS.bak' WITH  FILE = 1, NOUNLOAD, REPLACE, STATS = 5 ALTER DATABASE[JAS] SET MULTI_USER");
                bekleLabel.Text = string.Empty; 
                MessageBox.Show("Geri Yükleme Başarıyla Tamamlandı!");
            }
            catch (Exception ex)
            {
                bekleLabel.Text = string.Empty; 
                MessageBox.Show("Geri Yükleme İşlemi Tamamlanamadı!\n" + ex.Message);
                throw;
            }
        }


        private void geriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread before = new Thread(new ThreadStart(preRestore));
            Thread after = new Thread(new ThreadStart(forRestore));
            before.Start();
            after.Start();
        }

        private void nvbrGenelRaporlar_Click(object sender, EventArgs e)
        {
            genelRapor genelRapor = new genelRapor();
            fk.nav(genelRapor);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            tasi = true;
            nokta = new Point(e.X, e.Y);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            tasi = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (tasi)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.nokta.X, p.Y - this.nokta.Y);
            }
        }
    }
}
