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
    public partial class turRapor : formlar
    {
        public turRapor()
        {
            InitializeComponent();
        }

        private void turRapor_Load(object sender, EventArgs e)
        {
            fiyatCombo.Items.Add("");
            foreach (DataRow row in mssql.sqlTablo("select ucret from fiyat").Rows)         // comboBox daki elemanları veritabanından çeken kod
                fiyatCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select turID as 'Tür Numarası',turAdi as 'Tür Adı',ucret as 'Fiyat' from tur,fiyat where fiyat.fiyatID = tur.fiyatID");        //datagridview içini veritabanından dolduran 
        }

        public void dtgfiltrele()
        {
            string tursql = " like '%" + turBaslıkTxt.Text + "%' ", fiyatsql = " like '%' ";
            if (fiyatCombo.SelectedItem != "" && fiyatCombo.SelectedItem != null)
                fiyatsql = " ='" + mssql.sqlString("select fiyatID from fiyat where ucret = '" + fiyatCombo.SelectedItem.ToString().Replace(',', '.') + "'") + "' ";
            dataGridView1.DataSource = mssql.sqlTablo("select turID as 'Tür Numarası',turAdi as 'Tür Adı',ucret as 'Fiyat' " +
                "from tur,fiyat " +
                "where fiyat.fiyatID = tur.fiyatID and " +
                "turAdi" + tursql + " and " +
                "fiyat.fiyatID" + fiyatsql + "");        //datagridview içini veritabanından dolduran 

        }

        private void turBaslıkTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void fiyatCombo_SelectedIndexChanged(object sender, EventArgs e)
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
