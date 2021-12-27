namespace CAS
{
    partial class abonelikRapor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.icerikAdıCombo = new System.Windows.Forms.ComboBox();
            this.aboneAdıCombo = new System.Windows.Forms.ComboBox();
            this.bitisDate = new System.Windows.Forms.DateTimePicker();
            this.icerikLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboneLbl = new System.Windows.Forms.Label();
            this.baslangıcDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.baslangic_cb = new System.Windows.Forms.CheckBox();
            this.bitis_cb = new System.Windows.Forms.CheckBox();
            this.export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(682, 208);
            this.dataGridView1.TabIndex = 35;
            // 
            // icerikAdıCombo
            // 
            this.icerikAdıCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icerikAdıCombo.FormattingEnabled = true;
            this.icerikAdıCombo.Location = new System.Drawing.Point(491, 21);
            this.icerikAdıCombo.Name = "icerikAdıCombo";
            this.icerikAdıCombo.Size = new System.Drawing.Size(137, 21);
            this.icerikAdıCombo.TabIndex = 33;
            this.icerikAdıCombo.SelectedIndexChanged += new System.EventHandler(this.icerikAdıCombo_SelectedIndexChanged);
            // 
            // aboneAdıCombo
            // 
            this.aboneAdıCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aboneAdıCombo.FormattingEnabled = true;
            this.aboneAdıCombo.Location = new System.Drawing.Point(100, 20);
            this.aboneAdıCombo.Name = "aboneAdıCombo";
            this.aboneAdıCombo.Size = new System.Drawing.Size(158, 21);
            this.aboneAdıCombo.TabIndex = 34;
            this.aboneAdıCombo.SelectedIndexChanged += new System.EventHandler(this.aboneAdıCombo_SelectedIndexChanged);
            // 
            // bitisDate
            // 
            this.bitisDate.Location = new System.Drawing.Point(488, 62);
            this.bitisDate.Name = "bitisDate";
            this.bitisDate.Size = new System.Drawing.Size(137, 20);
            this.bitisDate.TabIndex = 31;
            this.bitisDate.ValueChanged += new System.EventHandler(this.bitisDate_ValueChanged);
            // 
            // icerikLbl
            // 
            this.icerikLbl.AutoSize = true;
            this.icerikLbl.Location = new System.Drawing.Point(434, 26);
            this.icerikLbl.Name = "icerikLbl";
            this.icerikLbl.Size = new System.Drawing.Size(51, 13);
            this.icerikLbl.TabIndex = 27;
            this.icerikLbl.Text = "İçerik Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // aboneLbl
            // 
            this.aboneLbl.AutoSize = true;
            this.aboneLbl.Location = new System.Drawing.Point(35, 24);
            this.aboneLbl.Name = "aboneLbl";
            this.aboneLbl.Size = new System.Drawing.Size(56, 13);
            this.aboneLbl.TabIndex = 29;
            this.aboneLbl.Text = "Abone Adı";
            // 
            // baslangıcDate
            // 
            this.baslangıcDate.Location = new System.Drawing.Point(120, 59);
            this.baslangıcDate.Name = "baslangıcDate";
            this.baslangıcDate.Size = new System.Drawing.Size(135, 20);
            this.baslangıcDate.TabIndex = 32;
            this.baslangıcDate.ValueChanged += new System.EventHandler(this.baslangıcDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Başlangıç Tarihi";
            // 
            // baslangic_cb
            // 
            this.baslangic_cb.AutoSize = true;
            this.baslangic_cb.Location = new System.Drawing.Point(260, 62);
            this.baslangic_cb.Margin = new System.Windows.Forms.Padding(2);
            this.baslangic_cb.Name = "baslangic_cb";
            this.baslangic_cb.Size = new System.Drawing.Size(15, 14);
            this.baslangic_cb.TabIndex = 36;
            this.baslangic_cb.UseVisualStyleBackColor = true;
            this.baslangic_cb.CheckedChanged += new System.EventHandler(this.baslangic_cb_CheckedChanged);
            // 
            // bitis_cb
            // 
            this.bitis_cb.AutoSize = true;
            this.bitis_cb.Location = new System.Drawing.Point(629, 63);
            this.bitis_cb.Margin = new System.Windows.Forms.Padding(2);
            this.bitis_cb.Name = "bitis_cb";
            this.bitis_cb.Size = new System.Drawing.Size(15, 14);
            this.bitis_cb.TabIndex = 37;
            this.bitis_cb.UseVisualStyleBackColor = true;
            this.bitis_cb.CheckedChanged += new System.EventHandler(this.bitis_cb_CheckedChanged);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(599, 326);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(90, 25);
            this.export.TabIndex = 38;
            this.export.Text = "Expor to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // abonelikRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 363);
            this.Controls.Add(this.export);
            this.Controls.Add(this.bitis_cb);
            this.Controls.Add(this.baslangic_cb);
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
            this.Name = "abonelikRapor";
            this.Text = "abonelikRapor";
            this.Load += new System.EventHandler(this.abonelikRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox icerikAdıCombo;
        private System.Windows.Forms.ComboBox aboneAdıCombo;
        private System.Windows.Forms.DateTimePicker bitisDate;
        private System.Windows.Forms.Label icerikLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aboneLbl;
        private System.Windows.Forms.DateTimePicker baslangıcDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox baslangic_cb;
        private System.Windows.Forms.CheckBox bitis_cb;
        private System.Windows.Forms.Button export;
    }
}