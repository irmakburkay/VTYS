namespace CAS
{
    partial class personel
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
            this.aboneKytButon = new System.Windows.Forms.Button();
            this.personelMailTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.kullaiciAdıTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.personelTelefonTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personelSoyadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.Label();
            this.personelAdresTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personelAdıTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bolumCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleRadio = new System.Windows.Forms.RadioButton();
            this.silRadio = new System.Windows.Forms.RadioButton();
            this.ekleRadio = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboneKytButon
            // 
            this.aboneKytButon.Location = new System.Drawing.Point(6, 19);
            this.aboneKytButon.Name = "aboneKytButon";
            this.aboneKytButon.Size = new System.Drawing.Size(99, 40);
            this.aboneKytButon.TabIndex = 20;
            this.aboneKytButon.Text = "Kaydet";
            this.aboneKytButon.UseVisualStyleBackColor = true;
            this.aboneKytButon.Click += new System.EventHandler(this.personelKytButon_Click);
            // 
            // personelMailTxt
            // 
            this.personelMailTxt.Location = new System.Drawing.Point(349, 37);
            this.personelMailTxt.Name = "personelMailTxt";
            this.personelMailTxt.Size = new System.Drawing.Size(213, 20);
            this.personelMailTxt.TabIndex = 17;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(663, 11);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(100, 20);
            this.sifreTxt.TabIndex = 16;
            // 
            // kullaiciAdıTxt
            // 
            this.kullaiciAdıTxt.Location = new System.Drawing.Point(525, 11);
            this.kullaiciAdıTxt.Name = "kullaiciAdıTxt";
            this.kullaiciAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.kullaiciAdıTxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "E-Mail";
            // 
            // personelTelefonTxt
            // 
            this.personelTelefonTxt.Location = new System.Drawing.Point(350, 11);
            this.personelTelefonTxt.Name = "personelTelefonTxt";
            this.personelTelefonTxt.Size = new System.Drawing.Size(100, 20);
            this.personelTelefonTxt.TabIndex = 14;
            this.personelTelefonTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personelTelefonTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre";
            // 
            // personelSoyadTxt
            // 
            this.personelSoyadTxt.Location = new System.Drawing.Point(201, 11);
            this.personelSoyadTxt.Name = "personelSoyadTxt";
            this.personelSoyadTxt.Size = new System.Drawing.Size(100, 20);
            this.personelSoyadTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefon";
            // 
            // soyadTxt
            // 
            this.soyadTxt.AutoSize = true;
            this.soyadTxt.Location = new System.Drawing.Point(158, 14);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(37, 13);
            this.soyadTxt.TabIndex = 6;
            this.soyadTxt.Text = "Soyad";
            // 
            // personelAdresTxt
            // 
            this.personelAdresTxt.Location = new System.Drawing.Point(52, 37);
            this.personelAdresTxt.Multiline = true;
            this.personelAdresTxt.Name = "personelAdresTxt";
            this.personelAdresTxt.Size = new System.Drawing.Size(249, 55);
            this.personelAdresTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adres";
            // 
            // personelAdıTxt
            // 
            this.personelAdıTxt.Location = new System.Drawing.Point(52, 11);
            this.personelAdıTxt.Name = "personelAdıTxt";
            this.personelAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.personelAdıTxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bölümü";
            // 
            // bolumCombo
            // 
            this.bolumCombo.FormattingEnabled = true;
            this.bolumCombo.Location = new System.Drawing.Point(631, 37);
            this.bolumCombo.Name = "bolumCombo";
            this.bolumCombo.Size = new System.Drawing.Size(131, 21);
            this.bolumCombo.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleRadio);
            this.groupBox1.Controls.Add(this.silRadio);
            this.groupBox1.Controls.Add(this.ekleRadio);
            this.groupBox1.Controls.Add(this.aboneKytButon);
            this.groupBox1.Location = new System.Drawing.Point(571, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 91);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // guncelleRadio
            // 
            this.guncelleRadio.AutoSize = true;
            this.guncelleRadio.Location = new System.Drawing.Point(111, 65);
            this.guncelleRadio.Name = "guncelleRadio";
            this.guncelleRadio.Size = new System.Drawing.Size(67, 17);
            this.guncelleRadio.TabIndex = 21;
            this.guncelleRadio.TabStop = true;
            this.guncelleRadio.Text = "Güncelle";
            this.guncelleRadio.UseVisualStyleBackColor = true;
            this.guncelleRadio.Click += new System.EventHandler(this.guncelleRadio_Click);
            // 
            // silRadio
            // 
            this.silRadio.AutoSize = true;
            this.silRadio.Location = new System.Drawing.Point(111, 42);
            this.silRadio.Name = "silRadio";
            this.silRadio.Size = new System.Drawing.Size(36, 17);
            this.silRadio.TabIndex = 21;
            this.silRadio.TabStop = true;
            this.silRadio.Text = "Sil";
            this.silRadio.UseVisualStyleBackColor = true;
            // 
            // ekleRadio
            // 
            this.ekleRadio.AutoSize = true;
            this.ekleRadio.Location = new System.Drawing.Point(111, 19);
            this.ekleRadio.Name = "ekleRadio";
            this.ekleRadio.Size = new System.Drawing.Size(46, 17);
            this.ekleRadio.TabIndex = 21;
            this.ekleRadio.TabStop = true;
            this.ekleRadio.Text = "Ekle";
            this.ekleRadio.UseVisualStyleBackColor = true;
            this.ekleRadio.Click += new System.EventHandler(this.ekleRadio_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 233);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bolumCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.personelMailTxt);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kullaiciAdıTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.personelTelefonTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.personelSoyadTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.personelAdresTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.personelAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personel";
            this.Text = "personelEkle";
            this.Load += new System.EventHandler(this.personelEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboneKytButon;
        private System.Windows.Forms.TextBox personelMailTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.TextBox kullaiciAdıTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personelTelefonTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personelSoyadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label soyadTxt;
        private System.Windows.Forms.TextBox personelAdresTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personelAdıTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox bolumCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton guncelleRadio;
        private System.Windows.Forms.RadioButton silRadio;
        private System.Windows.Forms.RadioButton ekleRadio;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}