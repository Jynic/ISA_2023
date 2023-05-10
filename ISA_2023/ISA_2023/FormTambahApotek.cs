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
    public partial class FormTambahApotek : Form
    {
        public FormTambahApotek()
        {
            InitializeComponent();
        }

        private void dataGridViewApotek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi();
                DialogResult result = MessageBox.Show("Apakah data yang ada masukkan sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = Apotek.GenerateID();
                    Apotek a = new Apotek(id, textBoxNamaObat.Text, int.Parse(textBoxQuantity.Text));
                    Apotek.TambahData(a);
                    MessageBox.Show("Data position telah tersimpan.", "Info");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data position gagal disimpan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
