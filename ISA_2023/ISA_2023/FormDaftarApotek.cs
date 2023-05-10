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
    public partial class FormDaftarApotek : Form
    {
        public Akun akun;
        MainForm main;
        List<Apotek> listofApotek = new List<Apotek>();
        public FormDaftarApotek()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahApotek frm = new FormTambahApotek();
            frm.Owner = this;
            frm.Show();
        }

        private void dataGridViewApotek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewApotek.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                string idApotek = dataGridViewApotek.CurrentRow.Cells["id"].Value.ToString();
                string namaObat = dataGridViewApotek.CurrentRow.Cells["nama_obat"].Value.ToString();
                DialogResult konfirmasi = MessageBox.Show(this,
                                                          "Obat yang ingin dihapus adalah : " +
                                                          "\nId Obat: " + idApotek +
                                                          "\nNama Obat : " + namaObat +
                                                          "\n\nAnda yakin ingin menghapus data di atas?", "HAPUS",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    Apotek apotek = new Apotek(int.Parse(idApotek));
                    akun = main.akun;
                    Apotek.HapusData(apotek);
                    MessageBox.Show("Penghapusan data telah berhasil.");

                    FormDaftarApotek_Load(buttonKeluar, e);
                }
            }
        }

        private void FormDaftarApotek_Load(object sender, EventArgs e)
        {
            try
            {
                main = (MainForm)this.Owner;
                Akun akun = main.akun;
                listofApotek = Apotek.BacaData("", "");
                if (listofApotek.Count >1 && listofApotek != null)
                {
                    dataGridViewApotek.DataSource = listofApotek;
                    if (dataGridViewApotek.ColumnCount > 1)
                    {

                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Hapus";
                        bcol.Name = "btnHapus";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridViewApotek.Columns.Add(bcol);
                    }
                }
                else
                {
                    dataGridViewApotek.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal, pesan kesalahan : " + ex);
            }
        }

        private void textBoxKategori_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "id")
            {
                listofApotek = Apotek.BacaData("id", textBoxKategori.Text);
            }
            else if (comboBoxCari.Text == "nama_obat")
            {
                listofApotek = Apotek.BacaData("nama_obat", textBoxKategori.Text);
            }
            if (listofApotek.Count > 0)
            {
                dataGridViewApotek.DataSource = listofApotek;
            }
            else
            {
                dataGridViewApotek.DataSource = null;
            }
        }
    }
}
