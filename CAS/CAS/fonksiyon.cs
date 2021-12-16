using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS
{
    internal class fonksiyon
    {
        public void nav()
        {
            aboneEkle abone = new aboneEkle();
            MainForm main=new MainForm();
            abone.Dock = DockStyle.None;
            main.mainPanel.Width = abone.Width;
            main.mainPanel.Height = abone.Height;
            abone.TopLevel = false;
            abone.FormBorderStyle = FormBorderStyle.None;
            main.mainPanel.Controls.Add(abone);
            main.Width = abone.Width + 40;
            main.Height = abone.Height + 83;
            abone.Show();
        }

    }
    
}
