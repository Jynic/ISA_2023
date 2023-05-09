
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalTemuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartuKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apotikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_posisi
            // 
            this.label_posisi.AutoSize = true;
            this.label_posisi.Location = new System.Drawing.Point(676, 9);
            this.label_posisi.Name = "label_posisi";
            this.label_posisi.Size = new System.Drawing.Size(55, 16);
            this.label_posisi.TabIndex = 1;
            this.label_posisi.Text = "position";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarAkunToolStripMenuItem,
            this.daftarJadwalTemuToolStripMenuItem,
            this.daftarKartuKontrolToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // daftarAkunToolStripMenuItem
            // 
            this.daftarAkunToolStripMenuItem.Name = "daftarAkunToolStripMenuItem";
            this.daftarAkunToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.daftarAkunToolStripMenuItem.Text = "Daftar Akun";
            // 
            // daftarJadwalTemuToolStripMenuItem
            // 
            this.daftarJadwalTemuToolStripMenuItem.Name = "daftarJadwalTemuToolStripMenuItem";
            this.daftarJadwalTemuToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.daftarJadwalTemuToolStripMenuItem.Text = "Daftar Jadwal Temu";
            // 
            // daftarKartuKontrolToolStripMenuItem
            // 
            this.daftarKartuKontrolToolStripMenuItem.Name = "daftarKartuKontrolToolStripMenuItem";
            this.daftarKartuKontrolToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.daftarKartuKontrolToolStripMenuItem.Text = "Daftar Kartu Kontrol";
            this.daftarKartuKontrolToolStripMenuItem.Click += new System.EventHandler(this.daftarKartuKontrolToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalTemuToolStripMenuItem,
            this.kartuKontrolToolStripMenuItem,
            this.apotikToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // jadwalTemuToolStripMenuItem
            // 
            this.jadwalTemuToolStripMenuItem.Name = "jadwalTemuToolStripMenuItem";
            this.jadwalTemuToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.jadwalTemuToolStripMenuItem.Text = "Jadwal Temu";
            this.jadwalTemuToolStripMenuItem.Click += new System.EventHandler(this.jadwalTemuToolStripMenuItem_Click);
            // 
            // kartuKontrolToolStripMenuItem
            // 
            this.kartuKontrolToolStripMenuItem.Name = "kartuKontrolToolStripMenuItem";
            this.kartuKontrolToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.kartuKontrolToolStripMenuItem.Text = "Kartu Kontrol";
            this.kartuKontrolToolStripMenuItem.Click += new System.EventHandler(this.kartuKontrolToolStripMenuItem_Click);
            // 
            // apotikToolStripMenuItem
            // 
            this.apotikToolStripMenuItem.Name = "apotikToolStripMenuItem";
            this.apotikToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.apotikToolStripMenuItem.Text = "Apotek";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
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
    }
}