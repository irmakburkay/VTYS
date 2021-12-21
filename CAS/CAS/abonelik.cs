using System;
using System.Data;
using System.Windows.Forms;

namespace CAS
{
    public partial class abonelik : formlar
    {

        public string abonelikID;           //veri işlemleri için id nesnesi

        public abonelik()
        {
            InitializeComponent();
        }

        private void abonelikEkle_Load(object sender, EventArgs e)  //başlangıçtaki tüm ayarların sıfırlanması
        {
            abonelikID = "0";                                       //id varsayılan olarak 0 
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            baslangıcDate.Value = DateTime.Today;
            bitisDate.Value = DateTime.Today;
            aboneAdıCombo.SelectedIndex = -1;
            aboneAdıCombo.Text = "";
            aboneAdıCombo.Items.Clear();
            foreach (DataRow row in mssql.sqlTablo("select aboneID from abone").Rows)       //comboBox daki elemanları veritabanından çeken kod
                aboneAdıCombo.Items.Add(row.ItemArray[0].ToString());
            icerikAdıCombo.SelectedIndex = -1;
            icerikAdıCombo.Text = "";
            icerikAdıCombo.Items.Clear();
            foreach (DataRow row in mssql.sqlTablo("select icerikID from icerik").Rows)     //comboBox daki elemanları veritabanından çeken kod
                icerikAdıCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select abonelikID as 'Abonelik Numarası'," +     //datagridview içini veritabanından dolduran kod
                "aboneID as 'Abone Numarası'," +
                "icerikID as 'İçerik Numarası'," +
                "baslangicTarih as 'Başlangıç Tarihi'," +
                "bitisTarih as 'Bitiş Tarihi' " +
                "from abonelik");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)        //datagridview üzerinde bir satır seçildiğinde ilgili alanları satırdaki verilerle dolduran kod
        {
            abonelikID = dataGridView1.SelectedRows[0].Cells["Abonelik Numarası"].Value.ToString();
            aboneAdıCombo.SelectedIndex = aboneAdıCombo.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["Abone Numarası"].Value.ToString());
            icerikAdıCombo.SelectedIndex = icerikAdıCombo.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["İçerik Numarası"].Value.ToString());
            baslangıcDate.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Başlangıç Tarihi"].Value.ToString());
            bitisDate.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Bitiş Tarihi"].Value.ToString());
        }

        private void aboneKytButon_Click(object sender, EventArgs e)       //kaydet butonunda ekle,güncelle,sil işlemleri
        {
            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch (check)
            {
                case 0:     //ekleme işlemi 
                    if (!(aboneAdıCombo.SelectedIndex == -1 || icerikAdıCombo.SelectedIndex == -1))     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into abonelik values('" +aboneAdıCombo.SelectedItem+ "','" + icerikAdıCombo.SelectedItem + "','"+baslangıcDate.Value.ToString("yyyy-MM-dd")+"','"+bitisDate.Value.ToString("yyyy-MM-dd")+"')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (abonelikID != "0")
                    {
                        if (mssql.sqlString("select count(*) from abonelik where abonelikID=" + abonelikID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update abonelik set aboneID='" + aboneAdıCombo.SelectedItem + "', icerikID='" + icerikAdıCombo.SelectedItem + "', baslagicTarih='"+ baslangıcDate.Value.ToString("yyyy-MM-dd") + "',bitisTarih='"+ bitisDate.Value.ToString("yyyy-MM-dd") + "' where abonelikID=" + abonelikID);
                            MessageBox.Show(abonelikID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(abonelikID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi
                    if (abonelikID != "0")
                    {
                        if (mssql.sqlString("select count(*) from abonelik where abonelikID=" + abonelikID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete abonelik where abonelikID=" + abonelikID);
                            MessageBox.Show(abonelikID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(abonelikID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if (check != -1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                abonelikEkle_Load(sender, e);
        }
    }
}
