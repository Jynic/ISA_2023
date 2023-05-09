using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Dokter_KartuKontrol
    {
        #region Data 
        Akun id_akun_pasien;
        KartuKontrol id_kartuKontrol;
        string deskripsi;

        public Dokter_KartuKontrol(Akun id_akun_pasien, KartuKontrol id_kartuKontrol, string deskripsi)
        {
            Id_akun_pasien = id_akun_pasien;
            Id_kartuKontrol = id_kartuKontrol;
            Deskripsi = deskripsi;
        }

        public Dokter_KartuKontrol()
        {
            Id_akun_pasien = new Akun();
            Id_kartuKontrol = new KartuKontrol();
            Deskripsi = "";
        }

        public Akun Id_akun_pasien { get => id_akun_pasien; set => id_akun_pasien = value; }
        public KartuKontrol Id_kartuKontrol { get => id_kartuKontrol; set => id_kartuKontrol = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region Methods
        public static Boolean TambahData(Dokter_KartuKontrol dKartuKontrol)
        {
            string sql = "INSERT INTO dokter_has_kartu_kontrol(akun_dokter, id_kartuKontrol, deskripsi) VALUES('" + dKartuKontrol.Id_akun_pasien + "','" + dKartuKontrol.Id_kartuKontrol + "','" + dKartuKontrol.Deskripsi + "')";
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean HapusData(Dokter_KartuKontrol dKartuKontrol)
        {
            string perintah = "DELETE FROM dokter_has_kartu_kontrol WHERE kartu_kontrol_id='" + dKartuKontrol.Id_kartuKontrol + "'";
            int jumlahDiubah = Convert.ToInt32(Koneksi.JalankanPerintahDML(perintah));
            if (jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
