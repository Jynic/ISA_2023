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
                        masterToolStripMenuItem.Enabled = false;
                        masterToolStripMenuItem.Visible = false;
                    }
                    else if (status == "Pasien")
                    {
                        label_posisi.Text = "pasien";
                        masterToolStripMenuItem.Enabled = false;
                        masterToolStripMenuItem.Visible = false; ;
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

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void daftarKartuKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarKartuKontrol frm = new FormDaftarKartuKontrol();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void kartuKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKartuKontrol frm = new FormKartuKontrol();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
