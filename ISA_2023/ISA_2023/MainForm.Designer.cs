
namespace ISA_2023
{
    partial class MainForm
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
            this.label_posisi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarJadwalTemuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarKartuKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarObatApotekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPengajuanObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalTemuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartuKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apotikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obatPasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_posisi
            // 
            this.label_posisi.AutoSize = true;
            this.label_posisi.Location = new System.Drawing.Point(676, 9);
            this.label_posisi.Name = "label_posisi";
            this.label_posisi.Size = new System.Drawing.Size(57, 17);
            this.label_posisi.TabIndex = 1;
            this.label_posisi.Text = "position";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarAkunToolStripMenuItem,
            this.daftarJadwalTemuToolStripMenuItem,
            this.daftarKartuKontrolToolStripMenuItem,
            this.daftarObatApotekToolStripMenuItem,
            this.daftarPengajuanObatToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // daftarAkunToolStripMenuItem
            // 
            this.daftarAkunToolStripMenuItem.Name = "daftarAkunToolStripMenuItem";
            this.daftarAkunToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.daftarAkunToolStripMenuItem.Text = "Daftar Akun";
            // 
            // daftarJadwalTemuToolStripMenuItem
            // 
            this.daftarJadwalTemuToolStripMenuItem.Name = "daftarJadwalTemuToolStripMenuItem";
            this.daftarJadwalTemuToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.daftarJadwalTemuToolStripMenuItem.Text = "Daftar Jadwal Temu";
            // 
            // daftarKartuKontrolToolStripMenuItem
            // 
            this.daftarKartuKontrolToolStripMenuItem.Name = "daftarKartuKontrolToolStripMenuItem";
            this.daftarKartuKontrolToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.daftarKartuKontrolToolStripMenuItem.Text = "Daftar Kartu Kontrol";
            // 
            // daftarObatApotekToolStripMenuItem
            // 
            this.daftarObatApotekToolStripMenuItem.Name = "daftarObatApotekToolStripMenuItem";
            this.daftarObatApotekToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.daftarObatApotekToolStripMenuItem.Text = "Daftar Obat Apotek";
            this.daftarObatApotekToolStripMenuItem.Click += new System.EventHandler(this.daftarObatApotekToolStripMenuItem_Click);
            // 
            // daftarPengajuanObatToolStripMenuItem
            // 
            this.daftarPengajuanObatToolStripMenuItem.Name = "daftarPengajuanObatToolStripMenuItem";
            this.daftarPengajuanObatToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.daftarPengajuanObatToolStripMenuItem.Text = "Daftar Pengajuan Obat";
            this.daftarPengajuanObatToolStripMenuItem.Click += new System.EventHandler(this.daftarPengajuanObatToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalTemuToolStripMenuItem,
            this.kartuKontrolToolStripMenuItem,
            this.apotikToolStripMenuItem,
            this.obatPasienToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // jadwalTemuToolStripMenuItem
            // 
            this.jadwalTemuToolStripMenuItem.Name = "jadwalTemuToolStripMenuItem";
            this.jadwalTemuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.jadwalTemuToolStripMenuItem.Text = "Jadwal Temu";
            this.jadwalTemuToolStripMenuItem.Click += new System.EventHandler(this.jadwalTemuToolStripMenuItem_Click);
            // 
            // kartuKontrolToolStripMenuItem
            // 
            this.kartuKontrolToolStripMenuItem.Name = "kartuKontrolToolStripMenuItem";
            this.kartuKontrolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kartuKontrolToolStripMenuItem.Text = "Kartu Kontrol";
            // 
            // apotikToolStripMenuItem
            // 
            this.apotikToolStripMenuItem.Name = "apotikToolStripMenuItem";
            this.apotikToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apotikToolStripMenuItem.Text = "Apotek";
            this.apotikToolStripMenuItem.Click += new System.EventHandler(this.apotikToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // obatPasienToolStripMenuItem
            // 
            this.obatPasienToolStripMenuItem.Name = "obatPasienToolStripMenuItem";
            this.obatPasienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obatPasienToolStripMenuItem.Text = "Obat Pasien";
            this.obatPasienToolStripMenuItem.Click += new System.EventHandler(this.obatPasienToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_posisi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_posisi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarJadwalTemuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarKartuKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalTemuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartuKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apotikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarObatApotekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarPengajuanObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obatPasienToolStripMenuItem;
    }
}