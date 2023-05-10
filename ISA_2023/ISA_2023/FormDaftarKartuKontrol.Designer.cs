
namespace ISA_2023
{
    partial class FormDaftarKartuKontrol
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.Location = new System.Drawing.Point(468, 309);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(134, 43);
            this.buttonKeluar.TabIndex = 1;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = true;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(45, 309);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(134, 43);
            this.buttonTambah.TabIndex = 2;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormDaftarKartuKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 374);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDaftarKartuKontrol";
            this.Text = "FormDaftarKartuKontrol";
            this.Load += new System.EventHandler(this.FormDaftarKartuKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
    }
}