namespace CAS
{
    partial class fiyatTipiEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.tipAdıTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyatTxt = new System.Windows.Forms.TextBox();
            this.fiyatKaydetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip Adı";
            // 
            // tipAdıTxt
            // 
            this.tipAdıTxt.Location = new System.Drawing.Point(55, 13);
            this.tipAdıTxt.Name = "tipAdıTxt";
            this.tipAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.tipAdıTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ücreti";
            // 
            // fiyatTxt
            // 
            this.fiyatTxt.Location = new System.Drawing.Point(208, 13);
            this.fiyatTxt.Name = "fiyatTxt";
            this.fiyatTxt.Size = new System.Drawing.Size(100, 20);
            this.fiyatTxt.TabIndex = 1;
            // 
            // fiyatKaydetbtn
            // 
            this.fiyatKaydetbtn.Location = new System.Drawing.Point(232, 40);
            this.fiyatKaydetbtn.Name = "fiyatKaydetbtn";
            this.fiyatKaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.fiyatKaydetbtn.TabIndex = 2;
            this.fiyatKaydetbtn.Text = "button1";
            this.fiyatKaydetbtn.UseVisualStyleBackColor = true;
            // 
            // fiyatTipiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 76);
            this.Controls.Add(this.fiyatKaydetbtn);
            this.Controls.Add(this.fiyatTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fiyatTipiEkle";
            this.Text = "fiyatTipiEkle";
            this.Load += new System.EventHandler(this.fiyatTipiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipAdıTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiyatTxt;
        private System.Windows.Forms.Button fiyatKaydetbtn;
    }
}