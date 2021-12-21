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
    public partial class dergiGazete : formlar
    {

        public string icerikID;

        public dergiGazete()
        {
            InitializeComponent();
        }

        private void dergiGazeteEkle_Load(object sender, EventArgs e)
        {
            icerikID = "0";
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            icerikAdıTxt.Text = "";
            turCombo.SelectedIndex = -1;
            turCombo.Text = "";
            turCombo.Items.Clear();
            foreach (DataRow row in mssql.sqlTablo("select turAdi from tur").Rows)
                turCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select icerikID as 'İçerik Numarası',icerikAdi as 'İçerik Adı',turAdi as 'Tür Adı' from icerik,tur where icerik.turID = tur.turID");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            icerikID = dataGridView1.SelectedRows[0].Cells["İçerik Numarası"].Value.ToString();
            icerikAdıTxt.Text = dataGridView1.SelectedRows[0].Cells["İçerik Adı"].Value.ToString();
            turCombo.SelectedIndex = turCombo.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["Tür Adı"].Value.ToString());
        }

        private void icerikKaydetBtn_Click(object sender, EventArgs e)
        {
            int check = -1;
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch(check)
            {
                case 0:
                    if (!(turCombo.SelectedIndex == -1 || icerikAdıTxt.Text=="") )
                    {
                        mssql.sqlIslem("insert into icerik values('" + mssql.sqlString("select turID from tur where turAdi='" + turCombo.SelectedItem + "'") + "','" + icerikAdıTxt.Text + "')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:
                    if(mssql.sqlString("select count(*) from icerik where icerikID=" + icerikID ).Equals("1"))
                    {
                        mssql.sqlIslem("update icerik set icerikAdi='" + icerikAdıTxt.Text + "', turID='" + mssql.sqlString("select turID from tur where turAdi='" + turCombo.SelectedItem + "'") + "' where icerikID=" + icerikID );
                        MessageBox.Show(icerikID + " Numaralı Kayıt Başarıyla Güncellendi!");
                    }
                    else
                        MessageBox.Show(icerikID + " Numaralı Kayıt Bulunamadı!");
                    break;
                case 2:
                    //string s = mssql.sqlString("select count(*) from icerik where icerikID=" + icerikID);
                    if (mssql.sqlString("select count(*) from icerik where icerikID=" + icerikID ).Equals("1"))
                    {
                        mssql.sqlIslem("delete icerik where icerikID=" + icerikID );
                        MessageBox.Show(icerikID + " Numaralı Kayıt Başarıyla Silindi!");
                    }
                    else
                        MessageBox.Show(icerikID + " Numaralı Kayıt Bulunamadı!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if(check!=-1)
              dergiGazeteEkle_Load(sender, e);
        }
    }
}
