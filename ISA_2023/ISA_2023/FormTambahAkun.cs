using rawatJalan_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_2023
{
    public partial class FormTambahAkun : Form
    {
        public FormTambahAkun()
        {
            InitializeComponent();
        }
        List<Posisi> listPosisi = new List<Posisi>();
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            DesCrypto crypto = new DesCrypto();
            Posisi posisi = (Posisi)comboBox1.SelectedItem;
            Akun a = new Akun(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxNIK.Text, textBoxAlamat.Text, dateTimePicker1.Value, posisi, textBoxUsername.Text, crypto.Encrypt(textBoxNIK.Text, textBoxPassword.Text));
            bool statusTambah = Akun.TambahData(a);
            if (statusTambah == true)
            {
                MessageBox.Show("Data Employee Berhasil Ditambahkan Selamat!", "Informasi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Data gagal Ditambahkan", "Kesalahan");
            }
        }

        private void FormTambahAkun_Load(object sender, EventArgs e)
        {
            listPosisi = Posisi.BacaData("", "");
            comboBox1.DataSource = listPosisi;
            comboBox1.DisplayMember = "Nama";
        }
    }
}
