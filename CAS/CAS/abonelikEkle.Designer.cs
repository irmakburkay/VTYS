namespace CAS
{
    partial class abonelikEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kaydetButon = new System.Windows.Forms.Button();
            this.baslangıcDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisDate = new System.Windows.Forms.DateTimePicker();
            this.aboneAdıCombo = new System.Windows.Forms.ComboBox();
            this.icerikAdıCombo = new System.Windows.Forms.ComboBox();
            this.aboneLbl = new System.Windows.Forms.Label();
            this.icerikLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaydetButon
            // 
            this.kaydetButon.Location = new System.Drawing.Point(354, 66);
            this.kaydetButon.Name = "kaydetButon";
            this.kaydetButon.Size = new System.Drawing.Size(108, 32);
            this.kaydetButon.TabIndex = 20;
            this.kaydetButon.Text = "Kaydet";
            this.kaydetButon.UseVisualStyleBackColor = true;
            // 
            // baslangıcDate
            // 
            this.baslangıcDate.Location = new System.Drawing.Point(111, 40);
            this.baslangıcDate.Name = "baslangıcDate";
            this.baslangıcDate.Size = new System.Drawing.Size(135, 20);
            this.baslangıcDate.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // bitisDate
            // 
            this.bitisDate.Location = new System.Drawing.Point(325, 40);
            this.bitisDate.Name = "bitisDate";
            this.bitisDate.Size = new System.Drawing.Size(137, 20);
            this.bitisDate.TabIndex = 19;
            // 
            // aboneAdıCombo
            // 
            this.aboneAdıCombo.FormattingEnabled = true;
            this.aboneAdıCombo.Location = new System.Drawing.Point(88, 13);
            this.aboneAdıCombo.Name = "aboneAdıCombo";
            this.aboneAdıCombo.Size = new System.Drawing.Size(158, 21);
            this.aboneAdıCombo.TabIndex = 21;
            // 
            // icerikAdıCombo
            // 
            this.icerikAdıCombo.FormattingEnabled = true;
            this.icerikAdıCombo.Location = new System.Drawing.Point(325, 12);
            this.icerikAdıCombo.Name = "icerikAdıCombo";
            this.icerikAdıCombo.Size = new System.Drawing.Size(137, 21);
            this.icerikAdıCombo.TabIndex = 21;
            // 
            // aboneLbl
            // 
            this.aboneLbl.AutoSize = true;
            this.aboneLbl.Location = new System.Drawing.Point(23, 17);
            this.aboneLbl.Name = "aboneLbl";
            this.aboneLbl.Size = new System.Drawing.Size(56, 13);
            this.aboneLbl.TabIndex = 11;
            this.aboneLbl.Text = "Abone Adı";
            // 
            // icerikLbl
            // 
            this.icerikLbl.AutoSize = true;
            this.icerikLbl.Location = new System.Drawing.Point(268, 17);
            this.icerikLbl.Name = "icerikLbl";
            this.icerikLbl.Size = new System.Drawing.Size(51, 13);
            this.icerikLbl.TabIndex = 11;
            this.icerikLbl.Text = "İçerik Adı";
            // 
            // abonelikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 104);
            this.Controls.Add(this.icerikAdıCombo);
            this.Controls.Add(this.aboneAdıCombo);
            this.Controls.Add(this.kaydetButon);
            this.Controls.Add(this.bitisDate);
            this.Controls.Add(this.icerikLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboneLbl);
            this.Controls.Add(this.baslangıcDate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "abonelikEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abonelikEkle";
            this.Load += new System.EventHandler(this.abonelikEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetButon;
        private System.Windows.Forms.DateTimePicker baslangıcDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bitisDate;
        private System.Windows.Forms.ComboBox aboneAdıCombo;
        private System.Windows.Forms.ComboBox icerikAdıCombo;
        private System.Windows.Forms.Label aboneLbl;
        private System.Windows.Forms.Label icerikLbl;
    }
}