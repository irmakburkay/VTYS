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
    public partial class personelRapor : formlar
    {
        public personelRapor()
        {
            InitializeComponent();
        }

        private void personelRapor_Load(object sender, EventArgs e)
        {
            bolumCombo.Items.Add("");
            foreach (DataRow row in mssql.sqlTablo("select bolumAdi from bolum").Rows)       //comboBox daki elemanları veritabanından çeken kod
                bolumCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select " +
                "personelID as 'Personel Numarası'," +     //datagridview içini veritabanından dolduran kod
                "bolum.bolumAdi as 'Bölüm Adı'," +
                "ad as 'Personel Adı'," +
                "soyad as 'Personel Soyadı'," +
                "tel as 'Telefon'," +
                "kullaniciAdi as 'Kullanıcı Adı'," +
                "sifre as 'Şifre'," +
                "adres as 'Adres'," +
                "eMail as 'E-Mail'" +
                "from personel,bolum where bolum.bolumID = personel.bolumID");
        }

        public void dtgfiltrele()
        {
            string bolumsql = " like '%' ";
            if (bolumCombo.SelectedItem != "" && bolumCombo.SelectedItem != null)
                bolumsql = " ='" + mssql.sqlString("select bolumID from bolum where bolumAdi = '" + bolumCombo.SelectedItem + "'") + "' ";
            dataGridView1.DataSource = mssql.sqlTablo("select " +
                "personelID as 'Personel Numarası'," +     //datagridview içini veritabanından dolduran kod
                "bolum.bolumAdi as 'Bölüm Adı'," +
                "ad as 'Personel Adı'," +
                "soyad as 'Personel Soyadı'," +
                "tel as 'Telefon'," +
                "kullaniciAdi as 'Kullanıcı Adı'," +
                "sifre as 'Şifre'," +
                "adres as 'Adres'," +
                "eMail as 'E-Mail'" +
                "from personel,bolum where bolum.bolumID = personel.bolumID and " +
                "personel.bolumID " + bolumsql + " and " +
                "ad like '%" + personelAdıTxt.Text + "%' and " +
                "soyad like '%" + personelSoyadTxt.Text + "%' and " +
                "tel like '%" + personelTelefonTxt.Text + "%' and " +
                "kullaniciAdi like '%" + kullaiciAdıTxt.Text + "%' and " +
                "sifre like '%" + sifreTxt.Text + "%' and " +
                "adres like '%" + personelAdresTxt.Text + "%' and " +
                "eMail like '%" + personelMailTxt.Text + "%'");
        }

        private void personelAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void personelSoyadTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void personelTelefonTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void kullaiciAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void sifreTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void personelAdresTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void personelMailTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void bolumCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void export_Click(object sender, EventArgs e)
        {
            formlar fm = new formlar();
            fm.raporla(dataGridView1);
        }
    }
}
