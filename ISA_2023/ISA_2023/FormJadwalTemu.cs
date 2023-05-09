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
            listJadwalTemu = JadwalTemu.BacaData("");
            if (listJadwalTemu.Count > 0 && listJadwalTemu != null)
            {
                dataGridViewInbox.DataSource = listJadwalTemu;
                if (dataGridViewInbox.ColumnCount == 4)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Hapus";
                    bcol.Name = "btnHapus";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewInbox.Columns.Add(bcol);

                }
            }
            else
            {
                dataGridViewInbox.DataSource = null;
            }
            //if (main.status == "Admin")
            //{
            //    listJadwalTemu = JadwalTemu.BacaData("", "");
            //}
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJadwalTemu frm = new FormTambahJadwalTemu();
            frm.Owner = this;
            frm.Show();
        }
    }
}
