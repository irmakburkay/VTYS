
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
            this.nbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonelikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiGazeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nbsToolStripMenuItem,
            this.abonelikToolStripMenuItem,
            this.içeriklerToolStripMenuItem,
            this.yetkiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.navBar.Size = new System.Drawing.Size(600, 24);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "menuStrip1";
            // 
            // nbsToolStripMenuItem
            // 
            this.nbsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.nbsToolStripMenuItem.Name = "nbsToolStripMenuItem";
            this.nbsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nbsToolStripMenuItem.Text = "Abone";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporToolStripMenuItem.Text = "Raporlar";
            // 
            // abonelikToolStripMenuItem
            // 
            this.abonelikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.raporlaToolStripMenuItem});
            this.abonelikToolStripMenuItem.Name = "abonelikToolStripMenuItem";
            this.abonelikToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.abonelikToolStripMenuItem.Text = "Abonelik";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.raporlaToolStripMenuItem.Text = "Raporla";
            // 
            // içeriklerToolStripMenuItem
            // 
            this.içeriklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dergiGazeteToolStripMenuItem,
            this.türToolStripMenuItem,
            this.fiyatToolStripMenuItem});
            this.içeriklerToolStripMenuItem.Name = "içeriklerToolStripMenuItem";
            this.içeriklerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.içeriklerToolStripMenuItem.Text = "İçerikler";
            // 
            // dergiGazeteToolStripMenuItem
            // 
            this.dergiGazeteToolStripMenuItem.Name = "dergiGazeteToolStripMenuItem";
            this.dergiGazeteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dergiGazeteToolStripMenuItem.Text = "Dergi/Gazete";
            // 
            // türToolStripMenuItem
            // 
            this.türToolStripMenuItem.Name = "türToolStripMenuItem";
            this.türToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.türToolStripMenuItem.Text = "Tür";
            // 
            // fiyatToolStripMenuItem
            // 
            this.fiyatToolStripMenuItem.Name = "fiyatToolStripMenuItem";
            this.fiyatToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fiyatToolStripMenuItem.Text = "Fiyat";
            // 
            // yetkiToolStripMenuItem
            // 
            this.yetkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.bölümToolStripMenuItem});
            this.yetkiToolStripMenuItem.Name = "yetkiToolStripMenuItem";
            this.yetkiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.yetkiToolStripMenuItem.Text = "Yetki";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // bölümToolStripMenuItem
            // 
            this.bölümToolStripMenuItem.Name = "bölümToolStripMenuItem";
            this.bölümToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.bölümToolStripMenuItem.Text = "Bölüm";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(9, 22);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 334);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.navBar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem nbsToolStripMenuItem;
        public System.Windows.Forms.MenuStrip navBar;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonelikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dergiGazeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

