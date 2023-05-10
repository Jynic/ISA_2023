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
    public partial class FormApotek : Form
    {
        List<Apotek> listofApotek = new List<Apotek>();
        public FormApotek()
        {
            InitializeComponent();
        }
        MainForm main;
        public Akun akun;
        private void FormApotek_Load(object sender, EventArgs e)
        {
            main = (MainForm)this.Owner;
            Akun akun = main.akun;
            listofApotek = Apotek.BacaData("", "");
            if (listofApotek.Count > 0 && listofApotek != null)
            {
                dataGridViewApotek.DataSource = listofApotek;
                if (dataGridViewApotek.ColumnCount > 1)
                {
                    
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Beli";
                    bcol.Name = "btnBeli";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewApotek.Columns.Add(bcol);
                }
            }
            else
            {
                dataGridViewApotek.DataSource = null;
            }
        }

        private void dataGridViewApotek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewApotek.Columns["btnBeli"].Index && e.RowIndex >= 0)
            {
                string idApotek = dataGridViewApotek.CurrentRow.Cells["id"].Value.ToString();
                string namaObat = dataGridViewApotek.CurrentRow.Cells["nama_obat"].Value.ToString();
                DialogResult konfirmasi = MessageBox.Show(this,
                                                          "Obat yang ingin dibeli adalah : " +
                                                          "\nId Obat: " + idApotek +
                                                          "\nNama Obat : " + namaObat+
                                                          "\n\nAnda yakin ingin membeli obat di atas?", "BELI",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    Apotek apotek = new Apotek(int.Parse(idApotek));
                    akun = main.akun;
                    int idAHA = Akun_has_Apotek.GenerateID();
                    Akun_has_Apotek aha = new Akun_has_Apotek(idAHA, akun, apotek);
                    Akun_has_Apotek.TambahData(aha);
                    MessageBox.Show("Pengajuan obat telah berhasil. Silahkan ditunggu.");

                    FormApotek_Load(buttonKeluar, e);
                }
            }
        }

        private void textBoxKategori_TextChanged(object sender, EventArgs e)
        {
            //if (comboBoxCari.Text == "Id")
            //{
            //    listofApotek = Apotek.BacaData("id", textBoxKategori.Text);
            //}
            //else if (comboBoxCari.Text == "Nama_Obat")
            //{
            //    listofApotek = Apotek.BacaData("nama_obat", textBoxKategori.Text);
            //}
            //if (listofApotek.Count > 0)
            //{
            //    dataGridViewApotek.DataSource = listofApotek;
            //}
            //else
            //{
            //    dataGridViewApotek.DataSource = null;
            //}
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
