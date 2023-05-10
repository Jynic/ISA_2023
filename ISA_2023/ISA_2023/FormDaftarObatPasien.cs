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
    public partial class FormDaftarObatPasien : Form
    {
        public FormDaftarObatPasien()
        {
            InitializeComponent();
        }
        public Akun akun;
        MainForm main;
        List<Akun_has_Apotek> listofAkunhasApotek = new List<Akun_has_Apotek>();
        private void FormDaftarObatPasien_Load(object sender, EventArgs e)
        {
            try
            {
                main = (MainForm)this.Owner;
                Akun akun = main.akun;
                listofAkunhasApotek = Akun_has_Apotek.BacaDataPasien();
                if (listofAkunhasApotek.Count >= 1 && listofAkunhasApotek != null)
                {
                    dataGridViewDisplay.DataSource = listofAkunhasApotek;
                }
                else
                {
                    dataGridViewDisplay.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal, pesan kesalahan : " + ex);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
