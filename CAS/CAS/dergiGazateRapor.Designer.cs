namespace CAS
{
    partial class dergiGazateRapor
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
            this.turCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.icerikAdıTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(450, 199);
            this.dataGridView1.TabIndex = 30;
            // 
            // turCombo
            // 
            this.turCombo.FormattingEnabled = true;
            this.turCombo.Location = new System.Drawing.Point(303, 13);
            this.turCombo.Margin = new System.Windows.Forms.Padding(4);
            this.turCombo.Name = "turCombo";
            this.turCombo.Size = new System.Drawing.Size(160, 24);
            this.turCombo.TabIndex = 29;
            this.turCombo.SelectedIndexChanged += new System.EventHandler(this.turCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Türü";
            // 
            // icerikAdıTxt
            // 
            this.icerikAdıTxt.Location = new System.Drawing.Point(86, 13);
            this.icerikAdıTxt.Margin = new System.Windows.Forms.Padding(4);
            this.icerikAdıTxt.Name = "icerikAdıTxt";
            this.icerikAdıTxt.Size = new System.Drawing.Size(132, 22);
            this.icerikAdıTxt.TabIndex = 27;
            this.icerikAdıTxt.TextChanged += new System.EventHandler(this.icerikAdıTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "İçerik Adı";
            // 
            // dergiGazateRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.turCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.icerikAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dergiGazateRapor";
            this.Text = "dergiGazateRapor";
            this.Load += new System.EventHandler(this.dergiGazateRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox turCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox icerikAdıTxt;
        private System.Windows.Forms.Label label1;
    }
}