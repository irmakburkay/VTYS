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
    public partial class kullaniciGiris : formlar
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            if(mssql.sqlString("select count(*) from personel where kullaniciAdi='"+kullaniciText.Text+"'").Equals("1"))
            {
                if(mssql.sqlString("select count(*) from personel where kullaniciAdi='" + kullaniciText.Text + "' and sifre='" + sifreText.Text + "'").Equals("1"))
                {
                    MessageBox.Show("Kullanıcı Girişi Başarılı!");
                    MainForm mf = Application.OpenForms["MainForm"] as MainForm;
                    mf.Show();
                    mf.Opacity = 100;
                    mf.navBar.Enabled = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Kullanıcı Şifre Yanlış!");
            }
            else
                MessageBox.Show("Kullanıcı Bulunmamakta!");
        }

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
        }
    }
}
