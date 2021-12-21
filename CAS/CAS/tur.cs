using System;
using System.Data;
using System.Windows.Forms;

namespace CAS
{
    public partial class tur : formlar
    {

        public string turID;          //veri işlemleri için id nesnesi

        public tur()
        {
            InitializeComponent();
        }

        private void turEkle_Load(object sender, EventArgs e)     //başlangıçtaki tüm ayarların sıfırlanması
        {
            turID = "0";
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            turBaslıkTxt.Text = "";
            fiyatCombo.SelectedIndex = -1;
            fiyatCombo.Text = "";
            fiyatCombo.Items.Clear();
            foreach (DataRow row in mssql.sqlTablo("select ucret from fiyat").Rows)         // comboBox daki elemanları veritabanından çeken kod
                fiyatCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select turID as 'Tür Numarası',turAdi as 'Tür Adı',ucret as 'Fiyat' from tur,fiyat where fiyat.fiyatID = tur.fiyatID");        //datagridview içini veritabanından dolduran kod
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)        //datagridview üzerinde bir satır seçildiğinde ilgili alanları satırdaki verilerle dolduran kod
        {
            turID = dataGridView1.SelectedRows[0].Cells["Tür Numarası"].Value.ToString();
            turBaslıkTxt.Text = dataGridView1.SelectedRows[0].Cells["Tür Adı"].Value.ToString();
            fiyatCombo.SelectedIndex = fiyatCombo.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["Fiyat"].Value.ToString());
        }

        private void turKaydetBtn_Click(object sender, EventArgs e)       //kaydet butonunda ekle,güncelle,sil işlemleri
        {
            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch (check)
            {
                case 0:     //ekleme işlemi 
                    if (!(fiyatCombo.SelectedIndex == -1 || turBaslıkTxt.Text == ""))     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into tur values('" + mssql.sqlString("select fiyatID from fiyat where ucret='" + fiyatCombo.SelectedItem.ToString().Replace(',', '.') + "'") + "','" + turBaslıkTxt.Text + "')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (turID != "0")
                    {
                        if (mssql.sqlString("select count(*) from tur where turID=" + turID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update tur set turAdi='" + turBaslıkTxt.Text + "', fiyatID='" + mssql.sqlString("select fiyatID from fiyat where ucret='" + fiyatCombo.SelectedItem.ToString().Replace(',', '.') + "'") + "' where turID=" + turID);
                            MessageBox.Show(turID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(turID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi
                    if (turID != "0")
                    {
                        if (mssql.sqlString("select count(*) from tur where turID=" + turID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete tur where turID=" + turID);
                            MessageBox.Show(turID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(turID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if (check != -1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                turEkle_Load(sender, e);
        }
    }
}
