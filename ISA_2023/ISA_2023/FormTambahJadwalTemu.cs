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
            FormJadwalTemu frmjt = (FormJadwalTemu)this.Owner;
            MainForm main = (MainForm)frmjt.Owner;
            string status = main.status;
            if (status == "Pasien")
            {
                listAkunPasien = Akun.BacaDataPasien(main.akun.Id);
                listAkunDokter = Akun.BacaDataDokter();
            }
            else if (status == "Dokter")
            {
                listAkunDokter = Akun.BacaDataDokter2(main.akun.Id);
                listAkunPasien = Akun.BacaDataPasien2();
            }
            else if (status == "Admin")
            {
                listAkunDokter = Akun.BacaDataDokter();
                listAkunPasien = Akun.BacaDataPasien2();
            }
            comboBoxPasien.DataSource = listAkunPasien;
            comboBoxPasien.DisplayMember = "Nama";
            comboBoxDokter.DataSource = listAkunDokter;
            comboBoxDokter.DisplayMember = "Nama";
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggal = dateTimePicker1.Value;
                string status = "";
                string id = JadwalTemu.GenerateId();
                Akun pasien = (Akun)comboBoxPasien.SelectedItem;
                Akun dokter = (Akun)comboBoxDokter.SelectedItem;
                JadwalTemu jdwl = new JadwalTemu(int.Parse(id), tanggal, status, textBoxKeluhan.Text, pasien, dokter);
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
