
using System;

namespace ISA_2023
{
    partial class DaftarFormJadwalTemu
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
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewDaftarJadwalTemu = new System.Windows.Forms.DataGridView();
            this.comboBoxDaftarJadwalTemu = new System.Windows.Forms.ComboBox();
            this.textBoxDaftarJadwalTemu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarJadwalTemu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 63);
            this.panel1.TabIndex = 14;
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
            this.label1.Text = "DAFTAR JADWAL TEMU";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKeluar.Location = new System.Drawing.Point(649, 444);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(139, 42);
            this.buttonKeluar.TabIndex = 20;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(12, 444);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(139, 42);
            this.buttonTambah.TabIndex = 19;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDaftarJadwalTemu
            // 
            this.dataGridViewDaftarJadwalTemu.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridViewDaftarJadwalTemu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarJadwalTemu.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewDaftarJadwalTemu.Name = "dataGridViewDaftarJadwalTemu";
            this.dataGridViewDaftarJadwalTemu.RowHeadersWidth = 51;
            this.dataGridViewDaftarJadwalTemu.RowTemplate.Height = 24;
            this.dataGridViewDaftarJadwalTemu.Size = new System.Drawing.Size(776, 290);
            this.dataGridViewDaftarJadwalTemu.TabIndex = 18;
            // 
            // comboBoxDaftarJadwalTemu
            // 
            this.comboBoxDaftarJadwalTemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDaftarJadwalTemu.FormattingEnabled = true;
            this.comboBoxDaftarJadwalTemu.Location = new System.Drawing.Point(216, 93);
            this.comboBoxDaftarJadwalTemu.Name = "comboBoxDaftarJadwalTemu";
            this.comboBoxDaftarJadwalTemu.Size = new System.Drawing.Size(169, 33);
            this.comboBoxDaftarJadwalTemu.TabIndex = 17;
            // 
            // textBoxDaftarJadwalTemu
            // 
            this.textBoxDaftarJadwalTemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDaftarJadwalTemu.Location = new System.Drawing.Point(391, 96);
            this.textBoxDaftarJadwalTemu.Name = "textBoxDaftarJadwalTemu";
            this.textBoxDaftarJadwalTemu.Size = new System.Drawing.Size(397, 30);
            this.textBoxDaftarJadwalTemu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cari Berdasarkan : ";
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonUbah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUbah.Location = new System.Drawing.Point(329, 444);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(139, 42);
            this.buttonUbah.TabIndex = 21;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            // 
            // DaftarFormJadwalTemu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewDaftarJadwalTemu);
            this.Controls.Add(this.comboBoxDaftarJadwalTemu);
            this.Controls.Add(this.textBoxDaftarJadwalTemu);
            this.Controls.Add(this.label2);
            this.Name = "DaftarFormJadwalTemu";
            this.Text = "DaftarFormJadwalTemu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarJadwalTemu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewDaftarJadwalTemu;
        private System.Windows.Forms.ComboBox comboBoxDaftarJadwalTemu;
        private System.Windows.Forms.TextBox textBoxDaftarJadwalTemu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUbah;
        private EventHandler DaftarFormJadwalTemu_Load;
    }
}