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
    public partial class bolumRapor : formlar
    {
        public bolumRapor()
        {
            InitializeComponent();
        }

        private void bolumRapor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı', yetkiTipi as 'Yetki Seviyesi' from bolum ");
        }

        private void bolumAdıTxt_TextChanged(object sender, EventArgs e)
        {
            string yetki;
            if (comboBox1.SelectedIndex > 0)
                yetki = (comboBox1.SelectedItem.ToString().Substring(0, comboBox1.SelectedItem.ToString().IndexOf(" "))).ToString();
            else
                yetki = "";
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı', yetkiTipi as 'Yetki Seviyesi' from bolum where bolumAdi like '%" + bolumAdıTxt.Text + "%' and yetkiTipi like '%" + yetki + "%'");
        }

        private void export_Click(object sender, EventArgs e)
        {
            raporla(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yetki;
            if (comboBox1.SelectedIndex > 0)
                yetki = (comboBox1.SelectedItem.ToString().Substring(0, comboBox1.SelectedItem.ToString().IndexOf(" "))).ToString();
            else
                yetki = "";
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı', yetkiTipi as 'Yetki Seviyesi' from bolum where bolumAdi like '%" + bolumAdıTxt.Text + "%' and yetkiTipi like '%" + yetki + "%'"); ;
        }
    }
}
