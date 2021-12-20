namespace CAS
{
    partial class fiyatTipi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleRadio = new System.Windows.Forms.RadioButton();
            this.silRadio = new System.Windows.Forms.RadioButton();
            this.ekleRadio = new System.Windows.Forms.RadioButton();
            this.turKaydetBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleRadio);
            this.groupBox1.Controls.Add(this.silRadio);
            this.groupBox1.Controls.Add(this.ekleRadio);
            this.groupBox1.Controls.Add(this.turKaydetBtn);
            this.groupBox1.Location = new System.Drawing.Point(143, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 84);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // guncelleRadio
            // 
            this.guncelleRadio.AutoSize = true;
            this.guncelleRadio.Location = new System.Drawing.Point(87, 58);
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
            this.silRadio.Location = new System.Drawing.Point(87, 35);
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
            this.ekleRadio.Location = new System.Drawing.Point(87, 12);
            this.ekleRadio.Name = "ekleRadio";
            this.ekleRadio.Size = new System.Drawing.Size(46, 17);
            this.ekleRadio.TabIndex = 24;
            this.ekleRadio.TabStop = true;
            this.ekleRadio.Text = "Ekle";
            this.ekleRadio.UseVisualStyleBackColor = true;
            // 
            // turKaydetBtn
            // 
            this.turKaydetBtn.Location = new System.Drawing.Point(6, 12);
            this.turKaydetBtn.Name = "turKaydetBtn";
            this.turKaydetBtn.Size = new System.Drawing.Size(75, 29);
            this.turKaydetBtn.TabIndex = 8;
            this.turKaydetBtn.Text = "Kaydet";
            this.turKaydetBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 123);
            this.dataGridView1.TabIndex = 28;
            // 
            // fiyatTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 264);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fiyatTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fiyatTipi";
            this.Text = "fiyatTipiEkle";
            this.Load += new System.EventHandler(this.fiyatTipiEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipAdıTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiyatTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton guncelleRadio;
        private System.Windows.Forms.RadioButton silRadio;
        private System.Windows.Forms.RadioButton ekleRadio;
        private System.Windows.Forms.Button turKaydetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}