
namespace ISA_2023
{
    partial class FormAkun_has_Apotek
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewAkun_has_Apotek = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkun_has_Apotek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 63);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Pengajuan Obat";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKeluar.Location = new System.Drawing.Point(649, 444);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(139, 42);
            this.buttonKeluar.TabIndex = 28;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewAkun_has_Apotek
            // 
            this.dataGridViewAkun_has_Apotek.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridViewAkun_has_Apotek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkun_has_Apotek.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewAkun_has_Apotek.Name = "dataGridViewAkun_has_Apotek";
            this.dataGridViewAkun_has_Apotek.RowHeadersWidth = 51;
            this.dataGridViewAkun_has_Apotek.RowTemplate.Height = 24;
            this.dataGridViewAkun_has_Apotek.Size = new System.Drawing.Size(776, 357);
            this.dataGridViewAkun_has_Apotek.TabIndex = 26;
            this.dataGridViewAkun_has_Apotek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAkun_has_Apotek_CellContentClick);
            // 
            // FormAkun_has_Apotek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewAkun_has_Apotek);
            this.Name = "FormAkun_has_Apotek";
            this.Text = "FormAkun_has_Apotek";
            this.Load += new System.EventHandler(this.FormAkun_has_Apotek_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkun_has_Apotek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewAkun_has_Apotek;
    }
}