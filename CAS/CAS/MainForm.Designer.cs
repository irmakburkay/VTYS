﻿
namespace CAS
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.nvbrAbone = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrAbonelik = new System.Windows.Forms.ToolStripMenuItem();
            this.abonelikDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrIcerik = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarDergi = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarTur = new System.Windows.Forms.ToolStripMenuItem();
            this.turDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarFiyat = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrYtki = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarBolum = new System.Windows.Forms.ToolStripMenuItem();
            this.bolumDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrGenelRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.raporlaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nvbrAbone,
            this.nvbrAbonelik,
            this.nvbrIcerik,
            this.nvbrYtki,
            this.nvbrGenelRaporlar,
            this.nvbrCıkıs});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.navBar.ShowItemToolTips = true;
            this.navBar.Size = new System.Drawing.Size(800, 28);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "Navbar";
            // 
            // nvbrAbone
            // 
            this.nvbrAbone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboneDuzenle,
            this.raporToolStripMenuItem});
            this.nvbrAbone.Name = "nvbrAbone";
            this.nvbrAbone.Size = new System.Drawing.Size(67, 24);
            this.nvbrAbone.Text = "Abone";
            // 
            // aboneDuzenle
            // 
            this.aboneDuzenle.Name = "aboneDuzenle";
            this.aboneDuzenle.Size = new System.Drawing.Size(224, 26);
            this.aboneDuzenle.Text = "Düzenle";
            this.aboneDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.raporToolStripMenuItem.Text = "Raporla";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // nvbrAbonelik
            // 
            this.nvbrAbonelik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonelikDuzenle,
            this.raporlaToolStripMenuItem});
            this.nvbrAbonelik.Name = "nvbrAbonelik";
            this.nvbrAbonelik.Size = new System.Drawing.Size(82, 24);
            this.nvbrAbonelik.Text = "Abonelik";
            // 
            // abonelikDuzenle
            // 
            this.abonelikDuzenle.Name = "abonelikDuzenle";
            this.abonelikDuzenle.Size = new System.Drawing.Size(146, 26);
            this.abonelikDuzenle.Text = "Düzenle";
            this.abonelikDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.raporlaToolStripMenuItem.Text = "Raporla";
            this.raporlaToolStripMenuItem.Click += new System.EventHandler(this.raporlaToolStripMenuItem_Click);
            // 
            // nvbrIcerik
            // 
            this.nvbrIcerik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navbarDergi,
            this.navbarTur,
            this.navbarFiyat});
            this.nvbrIcerik.Name = "nvbrIcerik";
            this.nvbrIcerik.Size = new System.Drawing.Size(75, 24);
            this.nvbrIcerik.Text = "İçerikler";
            // 
            // navbarDergi
            // 
            this.navbarDergi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dergiDuzenle,
            this.raporlaToolStripMenuItem1});
            this.navbarDergi.Name = "navbarDergi";
            this.navbarDergi.Size = new System.Drawing.Size(224, 26);
            this.navbarDergi.Text = "Dergi/Gazete";
            // 
            // dergiDuzenle
            // 
            this.dergiDuzenle.Name = "dergiDuzenle";
            this.dergiDuzenle.Size = new System.Drawing.Size(146, 26);
            this.dergiDuzenle.Text = "Düzenle";
            this.dergiDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem2_Click);
            // 
            // navbarTur
            // 
            this.navbarTur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turDuzenle,
            this.raporlaToolStripMenuItem2});
            this.navbarTur.Name = "navbarTur";
            this.navbarTur.Size = new System.Drawing.Size(224, 26);
            this.navbarTur.Text = "Tür";
            // 
            // turDuzenle
            // 
            this.turDuzenle.Name = "turDuzenle";
            this.turDuzenle.Size = new System.Drawing.Size(146, 26);
            this.turDuzenle.Text = "Düzenle";
            this.turDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem3_Click);
            // 
            // navbarFiyat
            // 
            this.navbarFiyat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiyatDuzenle,
            this.raporlaToolStripMenuItem3});
            this.navbarFiyat.Name = "navbarFiyat";
            this.navbarFiyat.Size = new System.Drawing.Size(224, 26);
            this.navbarFiyat.Text = "Fiyat";
            // 
            // fiyatDuzenle
            // 
            this.fiyatDuzenle.Name = "fiyatDuzenle";
            this.fiyatDuzenle.Size = new System.Drawing.Size(146, 26);
            this.fiyatDuzenle.Text = "Düzenle";
            this.fiyatDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem4_Click);
            // 
            // nvbrYtki
            // 
            this.nvbrYtki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navbarPersonel,
            this.navbarBolum});
            this.nvbrYtki.Name = "nvbrYtki";
            this.nvbrYtki.Size = new System.Drawing.Size(54, 24);
            this.nvbrYtki.Text = "Yetki";
            // 
            // navbarPersonel
            // 
            this.navbarPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDuzenle,
            this.raporToolStripMenuItem1});
            this.navbarPersonel.Name = "navbarPersonel";
            this.navbarPersonel.Size = new System.Drawing.Size(224, 26);
            this.navbarPersonel.Text = "Personel";
            // 
            // personelDuzenle
            // 
            this.personelDuzenle.Name = "personelDuzenle";
            this.personelDuzenle.Size = new System.Drawing.Size(146, 26);
            this.personelDuzenle.Text = "Düzenle";
            this.personelDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem5_Click);
            // 
            // navbarBolum
            // 
            this.navbarBolum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolumDuzenle,
            this.raporlaToolStripMenuItem4});
            this.navbarBolum.Name = "navbarBolum";
            this.navbarBolum.Size = new System.Drawing.Size(224, 26);
            this.navbarBolum.Text = "Bölüm";
            // 
            // bolumDuzenle
            // 
            this.bolumDuzenle.Name = "bolumDuzenle";
            this.bolumDuzenle.Size = new System.Drawing.Size(146, 26);
            this.bolumDuzenle.Text = "Düzenle";
            this.bolumDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem6_Click);
            // 
            // nvbrGenelRaporlar
            // 
            this.nvbrGenelRaporlar.Name = "nvbrGenelRaporlar";
            this.nvbrGenelRaporlar.Size = new System.Drawing.Size(122, 24);
            this.nvbrGenelRaporlar.Text = "Genel Raporlar";
            // 
            // nvbrCıkıs
            // 
            this.nvbrCıkıs.Name = "nvbrCıkıs";
            this.nvbrCıkıs.Size = new System.Drawing.Size(53, 24);
            this.nvbrCıkıs.Text = "Çıkış";
            this.nvbrCıkıs.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 32);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 406);
            this.mainPanel.TabIndex = 1;
            // 
            // raporlaToolStripMenuItem1
            // 
            this.raporlaToolStripMenuItem1.Name = "raporlaToolStripMenuItem1";
            this.raporlaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.raporlaToolStripMenuItem1.Text = "Raporla";
            this.raporlaToolStripMenuItem1.Click += new System.EventHandler(this.raporlaToolStripMenuItem1_Click);
            // 
            // raporlaToolStripMenuItem2
            // 
            this.raporlaToolStripMenuItem2.Name = "raporlaToolStripMenuItem2";
            this.raporlaToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.raporlaToolStripMenuItem2.Text = "Raporla";
            this.raporlaToolStripMenuItem2.Click += new System.EventHandler(this.raporlaToolStripMenuItem2_Click);
            // 
            // raporlaToolStripMenuItem3
            // 
            this.raporlaToolStripMenuItem3.Name = "raporlaToolStripMenuItem3";
            this.raporlaToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.raporlaToolStripMenuItem3.Text = "Raporla";
            this.raporlaToolStripMenuItem3.Click += new System.EventHandler(this.raporlaToolStripMenuItem3_Click);
            // 
            // raporToolStripMenuItem1
            // 
            this.raporToolStripMenuItem1.Name = "raporToolStripMenuItem1";
            this.raporToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.raporToolStripMenuItem1.Text = "Raporla";
            this.raporToolStripMenuItem1.Click += new System.EventHandler(this.raporToolStripMenuItem1_Click);
            // 
            // raporlaToolStripMenuItem4
            // 
            this.raporlaToolStripMenuItem4.Name = "raporlaToolStripMenuItem4";
            this.raporlaToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.raporlaToolStripMenuItem4.Text = "Raporla";
            this.raporlaToolStripMenuItem4.Click += new System.EventHandler(this.raporlaToolStripMenuItem4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.navBar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Abonelik Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem nvbrAbone;
        public System.Windows.Forms.MenuStrip navBar;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem aboneDuzenle;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvbrAbonelik;
        private System.Windows.Forms.ToolStripMenuItem nvbrIcerik;
        private System.Windows.Forms.ToolStripMenuItem abonelikDuzenle;
        private System.Windows.Forms.ToolStripMenuItem navbarDergi;
        private System.Windows.Forms.ToolStripMenuItem navbarTur;
        private System.Windows.Forms.ToolStripMenuItem navbarFiyat;
        private System.Windows.Forms.ToolStripMenuItem nvbrYtki;
        private System.Windows.Forms.ToolStripMenuItem navbarPersonel;
        private System.Windows.Forms.ToolStripMenuItem navbarBolum;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvbrCıkıs;
        private System.Windows.Forms.ToolStripMenuItem dergiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem turDuzenle;
        private System.Windows.Forms.ToolStripMenuItem fiyatDuzenle;
        private System.Windows.Forms.ToolStripMenuItem personelDuzenle;
        private System.Windows.Forms.ToolStripMenuItem bolumDuzenle;
        private System.Windows.Forms.ToolStripMenuItem nvbrGenelRaporlar;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem4;
    }
}

