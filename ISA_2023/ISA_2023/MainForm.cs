using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rawatJalan_LIB;

namespace ISA_2023
{
    public partial class MainForm : Form
    {
        public Akun akun;
        public Posisi posisi;
        public string status = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();
                FormLogin frmLogin = new FormLogin();
                frmLogin.Owner = this;
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    if (status == "Admin")
                    {
                        label_posisi.Text = "admin";
                    }
                    else if (status == "Dokter")
                    {
                        label_posisi.Text = "dokter";
                    }
                    else if (status == "Pasien")
                    {
                        label_posisi.Text = "pasien";
                    }
                }
                else
                {
                    MessageBox.Show("Gagal Login");
                    Application.Exit();
                }
            }
            catch (Exception ex) { MessageBox.Show("Koneksi Gagal. " + ex.Message); this.Close(); }
        }

        private void jadwalTemuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJadwalTemu frmJt = new FormJadwalTemu();
            frmJt.Owner = this;
            frmJt.Show();
        }

        private void apotikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApotek frmapotek = new FormApotek();
            frmapotek.Owner = this;
            frmapotek.Show();
        }

        private void daftarObatApotekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarApotek frmtambahapotek = new FormDaftarApotek();
            frmtambahapotek.Owner = this;
            frmtambahapotek.Show();
        }

        private void daftarPengajuanObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAkun_has_Apotek frm = new FormAkun_has_Apotek();
            frm.Owner = this;
            frm.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void obatPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarObatPasien frm = new FormDaftarObatPasien();
            frm.Owner = this;
            frm.Show();
        }
    }
}
