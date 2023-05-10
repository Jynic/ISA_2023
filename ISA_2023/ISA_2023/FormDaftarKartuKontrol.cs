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
    public partial class FormDaftarKartuKontrol : Form
    {
        public FormDaftarKartuKontrol()
        {
            InitializeComponent();
        }

        MainForm main;
        List<KartuKontrol> listKartuKontrol;
        private void FormDaftarKartuKontrol_Load(object sender, EventArgs e)
        {
            main = (MainForm)this.Owner;
            if (main.status == "Admin")
            {
                listKartuKontrol = KartuKontrol.BacaData("", "");
                if (listKartuKontrol.Count > 0 && listKartuKontrol != null)
                {
                    dataGridView1.DataSource = listKartuKontrol;
                }
            }
            else
            {
                buttonTambah.Enabled = false;
                dataGridView1.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKartuKontrol frm = new FormTambahKartuKontrol();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
