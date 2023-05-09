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
    public partial class FormKartuKontrol : Form
    {
        public FormKartuKontrol()
        {
            InitializeComponent();
        }
        MainForm main;
        List<KartuKontrol> listKartuKontrol;
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKartuKontrol_Load(object sender, EventArgs e)
        {
            main = (MainForm)this.Owner;
            if (main.status == "Admin" || main.status == "Dokter")
            {
                listKartuKontrol = KartuKontrol.BacaData("", "");
                if (listKartuKontrol.Count > 0 && listKartuKontrol != null)
                {
                    dataGridView1.DataSource = listKartuKontrol;
                    if (dataGridView1.ColumnCount < 5)
                    {
                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Ubah";
                        bcol.Name = "btnUbahGrid";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(bcol);

                    }
                }
            }
            else if (main.status == "Pasien")
            {
                buttonTambah.Enabled = false;
                buttonTambah.Hide();
                listKartuKontrol = KartuKontrol.BacaData("", "");
                if (listKartuKontrol.Count > 0 && listKartuKontrol != null)
                {
                    dataGridView1.DataSource = listKartuKontrol;
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
            {
                FormTambahKartuKontrol tambah = new FormTambahKartuKontrol();
                tambah.Owner = this;
                tambah.comboBox1.SelectedItem = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();
                tambah.dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tanggal"].Value.ToString());
                tambah.textBox1.Text = dataGridView1.CurrentRow.Cells["Deskripsi"].Value.ToString();
                tambah.ShowDialog();
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKartuKontrol frm = new FormTambahKartuKontrol();
            frm.Owner = this;
            frm.Show();
        }
    }
}
