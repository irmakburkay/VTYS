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
            MainForm mf = Application.OpenForms["MainForm"] as MainForm;
            mf.Show();
            mf.Opacity = 100;
            mf.navBar.Enabled = true;  
            this.Close();
        }

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
        }
    }
}
