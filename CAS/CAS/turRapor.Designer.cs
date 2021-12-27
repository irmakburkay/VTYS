namespace CAS
{
    partial class turRapor
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
            this.fiyatCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turBaslıkTxt = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 161);
            this.dataGridView1.TabIndex = 30;
            // 
            // fiyatCombo
            // 
            this.fiyatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiyatCombo.FormattingEnabled = true;
            this.fiyatCombo.Location = new System.Drawing.Point(370, 49);
            this.fiyatCombo.Margin = new System.Windows.Forms.Padding(4);
            this.fiyatCombo.Name = "fiyatCombo";
            this.fiyatCombo.Size = new System.Drawing.Size(160, 24);
            this.fiyatCombo.TabIndex = 1;
            this.fiyatCombo.SelectedIndexChanged += new System.EventHandler(this.fiyatCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fiyat Tipi";
            // 
            // turBaslıkTxt
            // 
            this.turBaslıkTxt.Location = new System.Drawing.Point(102, 50);
            this.turBaslıkTxt.Margin = new System.Windows.Forms.Padding(4);
            this.turBaslıkTxt.Name = "turBaslıkTxt";
            this.turBaslıkTxt.Size = new System.Drawing.Size(132, 22);
            this.turBaslıkTxt.TabIndex = 0;
            this.turBaslıkTxt.TextChanged += new System.EventHandler(this.turBaslıkTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tür Başlığı";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(503, 302);
            this.export.Margin = new System.Windows.Forms.Padding(4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(120, 31);
            this.export.TabIndex = 40;
            this.export.Text = "Export to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // turRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 346);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fiyatCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turBaslıkTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "turRapor";
            this.Text = "turRapor";
            this.Load += new System.EventHandler(this.turRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox fiyatCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox turBaslıkTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button export;
    }
}