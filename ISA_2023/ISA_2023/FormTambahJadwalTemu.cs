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
    public partial class FormTambahJadwalTemu : Form
    {
        public FormTambahJadwalTemu()
        {
            InitializeComponent();
        }
        public List<Akun> listAkunPasien = new List<Akun>();
        public List<Akun> listAkunDokter = new List<Akun>();

        private void FormTambahJadwalTemu_Load(object sender, EventArgs e)
        {
            listAkunPasien = Akun.BacaData("", "");
            listAkunDokter = Akun.BacaData("", "");
            comboBoxPasien.DataSource = listAkunPasien;
            comboBoxPasien.DisplayMember = "Id";
            comboBoxDokter.DataSource = listAkunDokter;
            comboBoxDokter.DisplayMember = "Id";
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggal = DateTime.Now;
                string id = JadwalTemu.GenerateId();
                Akun pasien = (Akun)comboBoxPasien.SelectedItem;
                Akun dokter = (Akun)comboBoxDokter.SelectedItem;
                JadwalTemu jdwl = new JadwalTemu(int.Parse(id), tanggal, label8.Text, textBoxKeluhan.Text, pasien, dokter);
                Boolean statusTambah = JadwalTemu.TambahData(jdwl);
                if (statusTambah == true)
                {
                    MessageBox.Show("Data Berhasil Ditambahkan!", "Informasi");
                }
                else
                {
                    MessageBox.Show("Data gagal Ditambahkan", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal ditambahkan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

    }
}
