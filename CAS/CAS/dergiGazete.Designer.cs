namespace CAS
{
    partial class dergiGazete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleRadio = new System.Windows.Forms.RadioButton();
            this.silRadio = new System.Windows.Forms.RadioButton();
            this.ekleRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.icerikKaydetBtn.Location = new System.Drawing.Point(6, 19);
            this.icerikKaydetBtn.Name = "icerikKaydetBtn";
            this.icerikKaydetBtn.Size = new System.Drawing.Size(85, 36);
            this.icerikKaydetBtn.TabIndex = 4;
            this.icerikKaydetBtn.Text = "Kaydet";
            this.icerikKaydetBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(326, 116);
            this.dataGridView1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleRadio);
            this.groupBox1.Controls.Add(this.silRadio);
            this.groupBox1.Controls.Add(this.ekleRadio);
            this.groupBox1.Controls.Add(this.icerikKaydetBtn);
            this.groupBox1.Location = new System.Drawing.Point(175, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 88);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // guncelleRadio
            // 
            this.guncelleRadio.AutoSize = true;
            this.guncelleRadio.Location = new System.Drawing.Point(97, 61);
            this.guncelleRadio.Name = "guncelleRadio";
            this.guncelleRadio.Size = new System.Drawing.Size(67, 17);
            this.guncelleRadio.TabIndex = 22;
            this.guncelleRadio.TabStop = true;
            this.guncelleRadio.Text = "Güncelle";
            this.guncelleRadio.UseVisualStyleBackColor = true;
            // 
            // silRadio
            // 
            this.silRadio.AutoSize = true;
            this.silRadio.Location = new System.Drawing.Point(97, 38);
            this.silRadio.Name = "silRadio";
            this.silRadio.Size = new System.Drawing.Size(36, 17);
            this.silRadio.TabIndex = 23;
            this.silRadio.TabStop = true;
            this.silRadio.Text = "Sil";
            this.silRadio.UseVisualStyleBackColor = true;
            // 
            // ekleRadio
            // 
            this.ekleRadio.AutoSize = true;
            this.ekleRadio.Location = new System.Drawing.Point(97, 15);
            this.ekleRadio.Name = "ekleRadio";
            this.ekleRadio.Size = new System.Drawing.Size(46, 17);
            this.ekleRadio.TabIndex = 24;
            this.ekleRadio.TabStop = true;
            this.ekleRadio.Text = "Ekle";
            this.ekleRadio.UseVisualStyleBackColor = true;
            // 
            // dergiGazete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.turCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icerikAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dergiGazete";
            this.Text = "dergiGazeteEkle";
            this.Load += new System.EventHandler(this.dergiGazeteEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox icerikAdıTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turCombo;
        private System.Windows.Forms.Button icerikKaydetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton guncelleRadio;
        private System.Windows.Forms.RadioButton silRadio;
        private System.Windows.Forms.RadioButton ekleRadio;
    }
}