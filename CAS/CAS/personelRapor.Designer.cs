namespace CAS
{
    partial class personelRapor
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
            this.bolumCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(25, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(733, 233);
            this.dataGridView1.TabIndex = 41;
            // 
            // bolumCombo
            // 
            this.bolumCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bolumCombo.FormattingEnabled = true;
            this.bolumCombo.Location = new System.Drawing.Point(627, 49);
            this.bolumCombo.Name = "bolumCombo";
            this.bolumCombo.Size = new System.Drawing.Size(131, 21);
            this.bolumCombo.TabIndex = 7;
            this.bolumCombo.SelectedIndexChanged += new System.EventHandler(this.bolumCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Bölümü";
            // 
            // personelMailTxt
            // 
            this.personelMailTxt.Location = new System.Drawing.Point(345, 49);
            this.personelMailTxt.Name = "personelMailTxt";
            this.personelMailTxt.Size = new System.Drawing.Size(213, 20);
            this.personelMailTxt.TabIndex = 6;
            this.personelMailTxt.TextChanged += new System.EventHandler(this.personelMailTxt_TextChanged);
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(659, 23);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(100, 20);
            this.sifreTxt.TabIndex = 4;
            this.sifreTxt.TextChanged += new System.EventHandler(this.sifreTxt_TextChanged);
            // 
            // kullaiciAdıTxt
            // 
            this.kullaiciAdıTxt.Location = new System.Drawing.Point(521, 23);
            this.kullaiciAdıTxt.Name = "kullaiciAdıTxt";
            this.kullaiciAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.kullaiciAdıTxt.TabIndex = 3;
            this.kullaiciAdıTxt.TextChanged += new System.EventHandler(this.kullaiciAdıTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "E-Mail";
            // 
            // personelTelefonTxt
            // 
            this.personelTelefonTxt.Location = new System.Drawing.Point(346, 23);
            this.personelTelefonTxt.Name = "personelTelefonTxt";
            this.personelTelefonTxt.Size = new System.Drawing.Size(100, 20);
            this.personelTelefonTxt.TabIndex = 2;
            this.personelTelefonTxt.TextChanged += new System.EventHandler(this.personelTelefonTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Şifre";
            // 
            // personelSoyadTxt
            // 
            this.personelSoyadTxt.Location = new System.Drawing.Point(197, 23);
            this.personelSoyadTxt.Name = "personelSoyadTxt";
            this.personelSoyadTxt.Size = new System.Drawing.Size(100, 20);
            this.personelSoyadTxt.TabIndex = 1;
            this.personelSoyadTxt.TextChanged += new System.EventHandler(this.personelSoyadTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Telefon";
            // 
            // soyadTxt
            // 
            this.soyadTxt.AutoSize = true;
            this.soyadTxt.Location = new System.Drawing.Point(154, 25);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(37, 13);
            this.soyadTxt.TabIndex = 27;
            this.soyadTxt.Text = "Soyad";
            // 
            // personelAdresTxt
            // 
            this.personelAdresTxt.Location = new System.Drawing.Point(48, 49);
            this.personelAdresTxt.Multiline = true;
            this.personelAdresTxt.Name = "personelAdresTxt";
            this.personelAdresTxt.Size = new System.Drawing.Size(249, 55);
            this.personelAdresTxt.TabIndex = 5;
            this.personelAdresTxt.TextChanged += new System.EventHandler(this.personelAdresTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adres";
            // 
            // personelAdıTxt
            // 
            this.personelAdıTxt.Location = new System.Drawing.Point(48, 23);
            this.personelAdıTxt.Name = "personelAdıTxt";
            this.personelAdıTxt.Size = new System.Drawing.Size(100, 20);
            this.personelAdıTxt.TabIndex = 0;
            this.personelAdıTxt.TextChanged += new System.EventHandler(this.personelAdıTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ad";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(669, 401);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(90, 25);
            this.export.TabIndex = 42;
            this.export.Text = "Expor to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // personelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 431);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "personelRapor";
            this.Text = "personelRapor";
            this.Load += new System.EventHandler(this.personelRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox bolumCombo;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Button export;
    }
}