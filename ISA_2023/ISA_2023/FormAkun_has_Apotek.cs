using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using rawatJalan_LIB;

namespace ISA_2023
{
    public partial class FormAkun_has_Apotek : Form
    {
        public FormAkun_has_Apotek()
        {
            InitializeComponent();
        }
        public Akun akun;
        MainForm main;
        List<Akun_has_Apotek> listofAkunhasApotek = new List<Akun_has_Apotek>();
        private void FormAkun_has_Apotek_Load(object sender, EventArgs e)
        {
            try
            {
                main = (MainForm)this.Owner;
                Akun akun = main.akun;
                listofAkunhasApotek = Akun_has_Apotek.BacaData("", "");
                if (listofAkunhasApotek.Count >= 1 && listofAkunhasApotek!= null)
                {
                    dataGridViewAkun_has_Apotek.DataSource = listofAkunhasApotek ;
                    if (dataGridViewAkun_has_Apotek.ColumnCount > 1)
                    {

                        DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                        bcol.HeaderText = "Aksi";
                        bcol.Text = "Terima";
                        bcol.Name = "btnUbah";
                        bcol.UseColumnTextForButtonValue = true;
                        dataGridViewAkun_has_Apotek.Columns.Add(bcol);
                    }
                }
                else
                {
                    dataGridViewAkun_has_Apotek.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal, pesan kesalahan : " + ex);
            }
        }

        private void dataGridViewAkun_has_Apotek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAkun_has_Apotek.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                string akun_id = dataGridViewAkun_has_Apotek.CurrentRow.Cells["Akun"].Value.ToString();
                string id_obat = dataGridViewAkun_has_Apotek.CurrentRow.Cells["Obat"].Value.ToString();
                string status = dataGridViewAkun_has_Apotek.CurrentRow.Cells["Status"].Value.ToString();
                string id = dataGridViewAkun_has_Apotek.CurrentRow.Cells["Id"].Value.ToString();
                DialogResult konfirmasi = MessageBox.Show(this,
                                                          "Data yang ingin diubah adalah : " +
                                                          "\nId Akun: " + akun_id +
                                                          "\nId Obat : " + id_obat+
                                                          "\nStatus : " + status +
                                                          "\n\nApakah anda yakin merubah data diatas?", "KONFIRMASI",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    string sql = "select akun_id, id_obat from akun_has_apotek where akun_id='" + akun_id + "' and id_obat='"+id_obat+"'";
                    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                    Apotek b = new Apotek(int.Parse(id_obat));
                    Akun_has_Apotek aha = new Akun_has_Apotek(int.Parse(id), akun, b);
                    Akun_has_Apotek.UbahData(aha);
                    //Apotek.UpdateQuantity()
                    MessageBox.Show("Berhasil dirubah.");

                    FormAkun_has_Apotek_Load(buttonKeluar, e);
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxkriteria_TextChanged(object sender, EventArgs e)
        {
            //if (comboBoxAkun_has_Apotek.Text == "Akun")
            //{
            //    listofAkunhasApotek = Akun_has_Apotek.BacaData("akun_id", textBoxkriteria.Text);
            //}
            //else if (comboBoxAkun_has_Apotek.Text == "Obat")
            //{
            //    listofAkunhasApotek = Akun_has_Apotek.BacaData("id_obat", textBoxkriteria.Text);
            //}
            //else if (comboBoxAkun_has_Apotek.Text == "Status")
            //{
            //    listofAkunhasApotek = Akun_has_Apotek.BacaData("status", textBoxkriteria.Text);
            //}
            //if (listofAkunhasApotek.Count > 0)
            //{
            //    dataGridViewAkun_has_Apotek.DataSource = listofAkunhasApotek;
            //}
            //else
            //{
            //    dataGridViewAkun_has_Apotek.DataSource = null;
            //}
        }
    }
}
