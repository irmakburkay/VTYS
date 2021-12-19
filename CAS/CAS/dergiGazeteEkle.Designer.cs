namespace CAS
{
    partial class dergiGazeteEkle
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
            this.icerikAdıTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turCombo = new System.Windows.Forms.ComboBox();
            this.icerikKaydetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İçerik Adı";
            // 
            // icerikAdıTxt
            // 
            this.icerikAdıTxt.Location = new System.Drawing.Point(70, 10);
            this.icerikAdıTxt.Name = "icerikAdıTxt";
            this.icerikAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.icerikAdıTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türü";
            // 
            // turCombo
            // 
            this.turCombo.FormattingEnabled = true;
            this.turCombo.Location = new System.Drawing.Point(221, 9);
            this.turCombo.Name = "turCombo";
            this.turCombo.Size = new System.Drawing.Size(121, 21);
            this.turCombo.TabIndex = 3;
            // 
            // icerikKaydetBtn
            // 
            this.icerikKaydetBtn.Location = new System.Drawing.Point(266, 37);
            this.icerikKaydetBtn.Name = "icerikKaydetBtn";
            this.icerikKaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.icerikKaydetBtn.TabIndex = 4;
            this.icerikKaydetBtn.Text = "Kaydet";
            this.icerikKaydetBtn.UseVisualStyleBackColor = true;
            // 
            // dergiGazeteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 72);
            this.Controls.Add(this.icerikKaydetBtn);
            this.Controls.Add(this.turCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icerikAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dergiGazeteEkle";
            this.Text = "dergiGazeteEkle";
            this.Load += new System.EventHandler(this.dergiGazeteEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox icerikAdıTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turCombo;
        private System.Windows.Forms.Button icerikKaydetBtn;
    }
}