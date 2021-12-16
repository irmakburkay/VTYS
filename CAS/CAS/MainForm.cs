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
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();
        }
        
        public void MainForm_Load(object sender, EventArgs e)
        {
            //navBar.Enabled = false;
            mainPanel.Controls.Clear();
            kullaniciGiris kg = new kullaniciGiris();
            kg.Dock = DockStyle.None;
            mainPanel.Width = kg.Width;
            mainPanel.Height = kg.Height;
            kg.TopLevel = false;
            kg.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(kg);
            Width = kg.Width + 40;
            Height = kg.Height + 83;
            kg.Show();
            this.CenterToScreen();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            aboneEkle abone = new aboneEkle();
            abone.Dock = DockStyle.None;
            mainPanel.Width = abone.Width;
            mainPanel.Height = abone.Height;
            abone.TopLevel = false;
            abone.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(abone);
            Width = abone.Width + 40;
            Height = abone.Height + 83;
            abone.Show();
            this.CenterToScreen();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            kullaniciGiris kg = new kullaniciGiris();
            kg.Dock = DockStyle.None;
            mainPanel.Width = kg.Width;
            mainPanel.Height = kg.Height;
            kg.TopLevel = false;
            kg.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Add(kg);
            Width = kg.Width + 40;
            Height = kg.Height + 83;
            kg.Show();
            this.CenterToScreen();
        }
    }
}
