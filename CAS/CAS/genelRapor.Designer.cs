
namespace CAS
{
    partial class genelRapor
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
            this.kalanKullanim_rb = new System.Windows.Forms.RadioButton();
            this.turHasilat_rb = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.icerikAded_rb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kalanKullanim_rb
            // 
            this.kalanKullanim_rb.AutoSize = true;
            this.kalanKullanim_rb.Location = new System.Drawing.Point(54, 59);
            this.kalanKullanim_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kalanKullanim_rb.Name = "kalanKullanim_rb";
            this.kalanKullanim_rb.Size = new System.Drawing.Size(122, 21);
            this.kalanKullanim_rb.TabIndex = 1;
            this.kalanKullanim_rb.TabStop = true;
            this.kalanKullanim_rb.Text = "Kalan Kullanım";
            this.kalanKullanim_rb.UseVisualStyleBackColor = true;
            this.kalanKullanim_rb.CheckedChanged += new System.EventHandler(this.kalanKullanim_rb_CheckedChanged);
            // 
            // turHasilat_rb
            // 
            this.turHasilat_rb.AutoSize = true;
            this.turHasilat_rb.Location = new System.Drawing.Point(223, 59);
            this.turHasilat_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turHasilat_rb.Name = "turHasilat_rb";
            this.turHasilat_rb.Size = new System.Drawing.Size(117, 21);
            this.turHasilat_rb.TabIndex = 2;
            this.turHasilat_rb.TabStop = true;
            this.turHasilat_rb.Text = "Türün Hasılatı";
            this.turHasilat_rb.UseVisualStyleBackColor = true;
            this.turHasilat_rb.CheckedChanged += new System.EventHandler(this.turHasilat_rb_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 115);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(950, 292);
            this.dataGridView.TabIndex = 26;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(828, 427);
            this.export.Margin = new System.Windows.Forms.Padding(4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(120, 31);
            this.export.TabIndex = 40;
            this.export.Text = "Export to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // icerikAded_rb
            // 
            this.icerikAded_rb.AutoSize = true;
            this.icerikAded_rb.Location = new System.Drawing.Point(370, 59);
            this.icerikAded_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icerikAded_rb.Name = "icerikAded_rb";
            this.icerikAded_rb.Size = new System.Drawing.Size(145, 21);
            this.icerikAded_rb.TabIndex = 2;
            this.icerikAded_rb.TabStop = true;
            this.icerikAded_rb.Text = "Alınan İçerik Adedi";
            this.icerikAded_rb.UseVisualStyleBackColor = true;
            this.icerikAded_rb.CheckedChanged += new System.EventHandler(this.icerikAded_rb_CheckedChanged);
            // 
            // genelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 482);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.icerikAded_rb);
            this.Controls.Add(this.turHasilat_rb);
            this.Controls.Add(this.kalanKullanim_rb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "genelRapor";
            this.Text = "genelRapor";
            this.Load += new System.EventHandler(this.genelRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton kalanKullanim_rb;
        private System.Windows.Forms.RadioButton turHasilat_rb;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.RadioButton icerikAded_rb;
    }
}