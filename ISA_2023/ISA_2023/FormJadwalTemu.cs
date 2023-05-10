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
    public partial class FormJadwalTemu : Form
    {
        public List<JadwalTemu> listJadwalTemu = new List<JadwalTemu>();
        public FormJadwalTemu()
        {
            InitializeComponent();
        }

        private void FormJadwalTemu_Load(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.Owner;
            Akun akun = main.akun;
            if (main.status == "Pasien")
            {
                listJadwalTemu = JadwalTemu.BacaDataPasien(main.akun.Id);
                dataGridViewInbox.DataSource = listJadwalTemu;
            }
            else if (main.status == "Dokter")
            {
                listJadwalTemu = JadwalTemu.BacaDataDokter(main.akun.Id);
                dataGridViewInbox.DataSource = listJadwalTemu;
            }
            else if (main.status == "Admin")
            {
                listJadwalTemu = JadwalTemu.BacaData();
                dataGridViewInbox.DataSource = listJadwalTemu;
                try
                {
                    if (listJadwalTemu.Count > 0)
                    {
                        if (dataGridViewInbox.ColumnCount < 8)
                        {
                            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                            bcol.HeaderText = "Aksi";
                            bcol.Text = "Ubah";
                            bcol.Name = "btnUbahGrid";
                            bcol.UseColumnTextForButtonValue = true;
                            dataGridViewInbox.Columns.Add(bcol);

                            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                            bcol2.HeaderText = "Aksi";
                            bcol2.Text = "Hapus";
                            bcol2.Name = "btnHapusGrid";
                            bcol2.UseColumnTextForButtonValue = true;
                            dataGridViewInbox.Columns.Add(bcol2);
                        }
                        else
                        {
                            dataGridViewInbox.DataSource = null;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJadwalTemu frm = new FormTambahJadwalTemu();
            frm.Owner = this;
            frm.Show();
        }

        private void dataGridViewInbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MainForm main = (MainForm)this.Owner;
            if (main.status == "Admin")
            {
                if (e.ColumnIndex == dataGridViewInbox.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
                {
                    try
                    {
                        string id = dataGridViewInbox.CurrentRow.Cells["id"].Value.ToString();
                        JadwalTemu.UbahStatusJadwal(int.Parse(id));
                        MessageBox.Show("Status Berubah menjadi Bertemu", "Informasi");
                        FormJadwalTemu_Load(this, e);

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else if (e.ColumnIndex == dataGridViewInbox.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    int id = int.Parse(dataGridViewInbox.CurrentRow.Cells["id"].Value.ToString());
                    DateTime tanggal = DateTime.Parse(dataGridViewInbox.CurrentRow.Cells["tanggal"].Value.ToString());
                    string status = dataGridViewInbox.CurrentRow.Cells["status"].Value.ToString();
                    string keluhan = dataGridViewInbox.CurrentRow.Cells["keluhan"].Value.ToString();
                    int pasien = int.Parse(dataGridViewInbox.CurrentRow.Cells["akun_pasien"].Value.ToString());
                    int dokter = int.Parse(dataGridViewInbox.CurrentRow.Cells["akun_dokter"].Value.ToString());
                    //Tampilkan Informasi 
                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus " + id + "?", "HAPUS",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hasil == DialogResult.Yes)
                    {
                        try
                        {
                            Posisi p = new Posisi();
                            Akun a = new Akun(pasien, dokter.ToString(), pasien.ToString(), dokter.ToString(), tanggal, p, pasien.ToString(), pasien.ToString());
                            JadwalTemu j = new JadwalTemu(id, tanggal, status, keluhan, a, a);
                            Boolean hapus = JadwalTemu.HapusData(j);
                            if (hapus == true)
                            {

                                MessageBox.Show("Penghapusan data berhasil");

                            }
                            else
                            {
                                MessageBox.Show("Penghapusan data gagal");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hapus data gagal. Pesan Kesalahan: " + ex.Message);
                        }

                    }
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
