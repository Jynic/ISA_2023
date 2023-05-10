using rawatJalan_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_2023
{
    public partial class FormTambahKartuKontrol : Form
    {
        public FormTambahKartuKontrol()
        {
            InitializeComponent();
        }
        List<Akun> listAkunPasien;
        MainForm main;
        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahKartuKontrol_Load(object sender, EventArgs e)
        {
            //main = (MainForm)this.Owner;
            listAkunPasien = Akun.BacaDataPasien("", "");
            comboBox1.DataSource = listAkunPasien;
            comboBox1.DisplayMember = "Nama";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                DesCrypto crypto = new DesCrypto();
                string nik = Akun.CekNIK(comboBox1.Text);
                string encrypt = crypto.Encrypt(nik, textBox1.Text);

                Dokter_KartuKontrol dk = new Dokter_KartuKontrol(;
                Boolean status = Dokter_KartuKontrol.TambahData()
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
