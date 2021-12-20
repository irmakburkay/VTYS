namespace CAS
{
    partial class abonelik
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
            this.baslangıcDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisDate = new System.Windows.Forms.DateTimePicker();
            this.aboneAdıCombo = new System.Windows.Forms.ComboBox();
            this.icerikAdıCombo = new System.Windows.Forms.ComboBox();
            this.aboneLbl = new System.Windows.Forms.Label();
            this.icerikLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleRadio = new System.Windows.Forms.RadioButton();
            this.silRadio = new System.Windows.Forms.RadioButton();
            this.ekleRadio = new System.Windows.Forms.RadioButton();
            this.aboneKytButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(464, 180);
            this.dataGridView1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleRadio);
            this.groupBox1.Controls.Add(this.silRadio);
            this.groupBox1.Controls.Add(this.ekleRadio);
            this.groupBox1.Controls.Add(this.aboneKytButon);
            this.groupBox1.Location = new System.Drawing.Point(280, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 84);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // guncelleRadio
            // 
            this.guncelleRadio.AutoSize = true;
            this.guncelleRadio.Location = new System.Drawing.Point(102, 57);
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
            this.silRadio.Location = new System.Drawing.Point(102, 34);
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
            this.ekleRadio.Location = new System.Drawing.Point(102, 11);
            this.ekleRadio.Name = "ekleRadio";
            this.ekleRadio.Size = new System.Drawing.Size(46, 17);
            this.ekleRadio.TabIndex = 24;
            this.ekleRadio.TabStop = true;
            this.ekleRadio.Text = "Ekle";
            this.ekleRadio.UseVisualStyleBackColor = true;
            // 
            // aboneKytButon
            // 
            this.aboneKytButon.Location = new System.Drawing.Point(6, 11);
            this.aboneKytButon.Name = "aboneKytButon";
            this.aboneKytButon.Size = new System.Drawing.Size(90, 32);
            this.aboneKytButon.TabIndex = 3;
            this.aboneKytButon.Text = "Kaydet";
            this.aboneKytButon.UseVisualStyleBackColor = true;
            // 
            // abonelik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.icerikAdıCombo);
            this.Controls.Add(this.aboneAdıCombo);
            this.Controls.Add(this.bitisDate);
            this.Controls.Add(this.icerikLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboneLbl);
            this.Controls.Add(this.baslangıcDate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "abonelik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abonelikEkle";
            this.Load += new System.EventHandler(this.abonelikEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker baslangıcDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bitisDate;
        private System.Windows.Forms.ComboBox aboneAdıCombo;
        private System.Windows.Forms.ComboBox icerikAdıCombo;
        private System.Windows.Forms.Label aboneLbl;
        private System.Windows.Forms.Label icerikLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton guncelleRadio;
        private System.Windows.Forms.RadioButton silRadio;
        private System.Windows.Forms.RadioButton ekleRadio;
        private System.Windows.Forms.Button aboneKytButon;
    }
}