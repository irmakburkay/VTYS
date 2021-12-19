namespace CAS
{
    partial class turEkle
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
            this.turKaydetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.turBaslıkTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fiyatCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // turKaydetBtn
            // 
            this.turKaydetBtn.Location = new System.Drawing.Point(280, 38);
            this.turKaydetBtn.Name = "turKaydetBtn";
            this.turKaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.turKaydetBtn.TabIndex = 8;
            this.turKaydetBtn.Text = "Kaydet";
            this.turKaydetBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fiyat Tipi";
            // 
            // turBaslıkTxt
            // 
            this.turBaslıkTxt.Location = new System.Drawing.Point(68, 12);
            this.turBaslıkTxt.Name = "turBaslıkTxt";
            this.turBaslıkTxt.Size = new System.Drawing.Size(100, 20);
            this.turBaslıkTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tür Başlığı";
            // 
            // fiyatCombo
            // 
            this.fiyatCombo.FormattingEnabled = true;
            this.fiyatCombo.Location = new System.Drawing.Point(234, 11);
            this.fiyatCombo.Name = "fiyatCombo";
            this.fiyatCombo.Size = new System.Drawing.Size(121, 21);
            this.fiyatCombo.TabIndex = 9;
            // 
            // turEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 73);
            this.Controls.Add(this.fiyatCombo);
            this.Controls.Add(this.turKaydetBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turBaslıkTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "turEkle";
            this.Text = "turEkle";
            this.Load += new System.EventHandler(this.turEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turKaydetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox turBaslıkTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fiyatCombo;
    }
}