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
    public partial class personel : formlar
    {
        public string personelID;
        public personel()
        {
            InitializeComponent();
        }

        private void personelEkle_Load(object sender, EventArgs e)
        {
            personelTelefonTxt.MaxLength = 11;
            personelID = "0";                                       //id varsayılan olarak 0 
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            bolumCombo.SelectedIndex = -1;
            bolumCombo.Text = "";
            bolumCombo.Items.Clear();
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

        private void personelKytButon_Click(object sender, EventArgs e)
        {
            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch (check)
            {
                case 0:     //ekleme işlemi 
                    if (!(bolumCombo.SelectedIndex == -1)||personelAdresTxt.Text!=""|| personelAdıTxt.Text != ""|| kullaiciAdıTxt.Text != ""|| personelSoyadTxt.Text != ""|| personelTelefonTxt.Text != ""|| sifreTxt.Text != ""|| personelMailTxt.Text != "")     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into personel values('" + mssql.sqlString("select bolumID from bolum where bolumAdi = '"+ bolumCombo.SelectedItem + "'") + "','" + personelAdıTxt.Text + "','" + personelSoyadTxt.Text + "','" + personelTelefonTxt .Text+ "','" + kullaiciAdıTxt.Text +"' , '" +sifreTxt.Text + "', '" + personelAdresTxt.Text + "', '" + personelMailTxt.Text + "')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (personelID != "0")
                    {
                        if (mssql.sqlString("select count(*) from personel where personelID=" + personelID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update personel set bolumID='" + mssql.sqlString("select bolumID from bolum where bolumAdi = '" + bolumCombo.SelectedItem + "'") + "', ad='" + personelAdıTxt.Text + "', soyad='" + personelSoyadTxt.Text + "' , tel='" + personelTelefonTxt.Text + "' , kullaniciAdi='" + kullaiciAdıTxt.Text + "' , sifre='" + sifreTxt.Text + "' , adres='" + personelAdresTxt.Text + "' , eMail='" + personelMailTxt.Text+"'where personelID="+personelID);
                            MessageBox.Show(personelID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(personelID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi
                    if (personelID != "0")
                    {
                        if (mssql.sqlString("select count(*) from personel where personelID=" + personelID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete personel where personelID=" + personelID);
                            MessageBox.Show(personelID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(personelID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if (check != -1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                personelEkle_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            personelAdıTxt.Text= dataGridView1.SelectedRows[0].Cells["Personel Adı"].Value.ToString();
            personelSoyadTxt.Text= dataGridView1.SelectedRows[0].Cells["Personel Soyadı"].Value.ToString();
            personelTelefonTxt.Text= dataGridView1.SelectedRows[0].Cells["Telefon"].Value.ToString();
            kullaiciAdıTxt.Text= dataGridView1.SelectedRows[0].Cells["KUllanıcı Adı"].Value.ToString();
            sifreTxt.Text= dataGridView1.SelectedRows[0].Cells["Şifre"].Value.ToString();
            personelAdresTxt.Text= dataGridView1.SelectedRows[0].Cells["Adres"].Value.ToString();
            personelMailTxt.Text= dataGridView1.SelectedRows[0].Cells["E-Mail"].Value.ToString();
            bolumCombo.SelectedIndex = bolumCombo.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["Bölüm Adı"].Value.ToString());
            personelID= dataGridView1.SelectedRows[0].Cells["Personel Numarası"].Value.ToString();
        }

        private void personelTelefonTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ekleRadio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personel Kayıt İşlemi Kurralları\n" +
                        "1-) Lütfen hiçbir alanı boş bırakmayınız.\n" +
                        "2-) Telefon Numarası 11 hane ve rakamlardan oluşmak zorundadır.\n" +
                        "3-) Adres '....Mahalle ....Sokak ....Cadde' şeklinde olmalıdır.\n" +
                        "4-) E-Mail adresi '.......@...'.'...' şeklinde olmalıdır.\n" +
                        "5-) Kayıt Tarihi, mevcut sistemin tarihinden ileri bir tarihte olamak zorundadır.\n" +
                        "6-) Kullanıcı Adı en az 8 karakter uzunluğunda olmalıdır.\n" +
                        "7-) Şifre en az 8 karakter uzunluğunda olmalıdır.");
        }

        private void guncelleRadio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personel Güncelleme İşlemi Kurralları\n" +
                       "1-) Lütfen hiçbir alanı boş bırakmayınız.\n" +
                       "2-) Telefon Numarası 11 hane ve rakamlardan oluşmak zorundadır.\n" +
                       "3-) Adres '....Mahalle ....Sokak ....Cadde' şeklinde olmalıdır.\n" +
                       "4-) E-Mail adresi '.......@...'.'...' şeklinde olmalıdır.\n" +
                       "5-) Kayıt Tarihi, mevcut sistemin tarihinden ileri bir tarihte olamak zorundadır.\n" +
                       "6-) Kullanıcı Adı en az 8 karakter uzunluğunda olmalıdır.\n" +
                       "7-) Şifre en az 8 karakter uzunluğunda olmalıdır.");
        }
    }
}
