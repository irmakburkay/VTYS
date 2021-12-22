
namespace CAS
{
    partial class abone
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
            this.aboneAdıTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.Label();
            this.aboneSoyadTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aboneTelTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aboneAdresTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aboneDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.aboneMailTxt = new System.Windows.Forms.TextBox();
            this.aboneKytButon = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // aboneAdıTxt
            // 
            this.aboneAdıTxt.Location = new System.Drawing.Point(57, 26);
            this.aboneAdıTxt.Name = "aboneAdıTxt";
            this.aboneAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.aboneAdıTxt.TabIndex = 1;
            // 
            // soyadTxt
            // 
            this.soyadTxt.AutoSize = true;
            this.soyadTxt.Location = new System.Drawing.Point(163, 29);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(37, 13);
            this.soyadTxt.TabIndex = 0;
            this.soyadTxt.Text = "Soyad";
            // 
            // aboneSoyadTxt
            // 
            this.aboneSoyadTxt.Location = new System.Drawing.Point(206, 26);
            this.aboneSoyadTxt.Name = "aboneSoyadTxt";
            this.aboneSoyadTxt.Size = new System.Drawing.Size(100, 20);
            this.aboneSoyadTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon";
            // 
            // aboneTelTxt
            // 
            this.aboneTelTxt.Location = new System.Drawing.Point(355, 26);
            this.aboneTelTxt.Name = "aboneTelTxt";
            this.aboneTelTxt.Size = new System.Drawing.Size(100, 20);
            this.aboneTelTxt.TabIndex = 1;
            this.aboneTelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aboneTelTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres";
            // 
            // aboneAdresTxt
            // 
            this.aboneAdresTxt.Location = new System.Drawing.Point(57, 52);
            this.aboneAdresTxt.Multiline = true;
            this.aboneAdresTxt.Name = "aboneAdresTxt";
            this.aboneAdresTxt.Size = new System.Drawing.Size(249, 48);
            this.aboneAdresTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kayıt Tarihi";
            // 
            // aboneDate
            // 
            this.aboneDate.Location = new System.Drawing.Point(378, 55);
            this.aboneDate.Name = "aboneDate";
            this.aboneDate.Size = new System.Drawing.Size(135, 20);
            this.aboneDate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Mail";
            // 
            // aboneMailTxt
            // 
            this.aboneMailTxt.Location = new System.Drawing.Point(506, 26);
            this.aboneMailTxt.Name = "aboneMailTxt";
            this.aboneMailTxt.Size = new System.Drawing.Size(213, 20);
            this.aboneMailTxt.TabIndex = 1;
            // 
            // aboneKytButon
            // 
            this.aboneKytButon.Location = new System.Drawing.Point(6, 11);
            this.aboneKytButon.Name = "aboneKytButon";
            this.aboneKytButon.Size = new System.Drawing.Size(108, 40);
            this.aboneKytButon.TabIndex = 3;
            this.aboneKytButon.Text = "Kaydet";
            this.aboneKytButon.UseVisualStyleBackColor = true;
            this.aboneKytButon.Click += new System.EventHandler(this.aboneKytButon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 237);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleRadio);
            this.groupBox1.Controls.Add(this.silRadio);
            this.groupBox1.Controls.Add(this.ekleRadio);
            this.groupBox1.Controls.Add(this.aboneKytButon);
            this.groupBox1.Location = new System.Drawing.Point(519, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // guncelleRadio
            // 
            this.guncelleRadio.AutoSize = true;
            this.guncelleRadio.Location = new System.Drawing.Point(122, 57);
            this.guncelleRadio.Name = "guncelleRadio";
            this.guncelleRadio.Size = new System.Drawing.Size(67, 17);
            this.guncelleRadio.TabIndex = 22;
            this.guncelleRadio.TabStop = true;
            this.guncelleRadio.Text = "Güncelle";
            this.guncelleRadio.UseVisualStyleBackColor = true;
            this.guncelleRadio.Click += new System.EventHandler(this.guncelleRadio_Click);
            // 
            // silRadio
            // 
            this.silRadio.AutoSize = true;
            this.silRadio.Location = new System.Drawing.Point(122, 34);
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
            this.ekleRadio.Location = new System.Drawing.Point(122, 11);
            this.ekleRadio.Name = "ekleRadio";
            this.ekleRadio.Size = new System.Drawing.Size(46, 17);
            this.ekleRadio.TabIndex = 24;
            this.ekleRadio.TabStop = true;
            this.ekleRadio.Text = "Ekle";
            this.ekleRadio.UseVisualStyleBackColor = true;
            this.ekleRadio.Click += new System.EventHandler(this.ekleRadio_Click);
            // 
            // abone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aboneDate);
            this.Controls.Add(this.aboneMailTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aboneTelTxt);
            this.Controls.Add(this.aboneSoyadTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.aboneAdresTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aboneAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "abone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "aboneEkle";
            this.Load += new System.EventHandler(this.abone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aboneAdıTxt;
        private System.Windows.Forms.Label soyadTxt;
        private System.Windows.Forms.TextBox aboneSoyadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aboneTelTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aboneAdresTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker aboneDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aboneMailTxt;
        private System.Windows.Forms.Button aboneKytButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton guncelleRadio;
        private System.Windows.Forms.RadioButton silRadio;
        private System.Windows.Forms.RadioButton ekleRadio;
    }
}