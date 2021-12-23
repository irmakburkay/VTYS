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
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı' from bolum ");
        }

        private void bolumAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı' from bolum where bolumAdi like '%"+bolumAdıTxt.Text+"%'");
        }
    }
}
