namespace CAS
{
    partial class bolumEkle
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
            this.fiyatKaydetbtn = new System.Windows.Forms.Button();
            this.tipAdıTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fiyatKaydetbtn
            // 
            this.fiyatKaydetbtn.Location = new System.Drawing.Point(178, 15);
            this.fiyatKaydetbtn.Name = "fiyatKaydetbtn";
            this.fiyatKaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.fiyatKaydetbtn.TabIndex = 7;
            this.fiyatKaydetbtn.Text = "Kaydet";
            this.fiyatKaydetbtn.UseVisualStyleBackColor = true;
            // 
            // tipAdıTxt
            // 
            this.tipAdıTxt.Location = new System.Drawing.Point(72, 17);
            this.tipAdıTxt.Name = "tipAdıTxt";
            this.tipAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.tipAdıTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bölüm Adı";
            // 
            // bolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 61);
            this.Controls.Add(this.fiyatKaydetbtn);
            this.Controls.Add(this.tipAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bolumEkle";
            this.Text = "bolumEkle";
            this.Load += new System.EventHandler(this.bolumEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fiyatKaydetbtn;
        private System.Windows.Forms.TextBox tipAdıTxt;
        private System.Windows.Forms.Label label1;
    }
}