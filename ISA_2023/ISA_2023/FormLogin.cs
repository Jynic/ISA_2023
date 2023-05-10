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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DesCrypto crypto = new DesCrypto();
                Koneksi koneksi = new Koneksi();
                Akun a = new Akun();
                string username = textBoxUsername.Text;
                string nik = Akun.CekNIK(username);
                a = Akun.CekLogin(username, crypto.Encrypt(nik, textBoxPassword.Text));

                MainForm frmMain = (MainForm)this.Owner;
                frmMain.akun = a;
                if (!(a is null))
                {
                    frmMain.status = Akun.CekPosisi(a);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelBuatAkun_Click(object sender, EventArgs e)
        {
            FormTambahAkun frm = new FormTambahAkun();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
