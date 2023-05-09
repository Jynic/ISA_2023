using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class KartuKontrol
    {
        #region Data Members
        int id;
        DateTime tanggal;
        Akun id_dokter;
        string nama_dokter;
        Akun id_pasien;

        #endregion
        #region Constructors
        public KartuKontrol(int id, DateTime tanggal, Akun id_pasien,Akun id_dokter, string nama_dokter)
        {
            Id = id;
            Tanggal = tanggal;
            Id_dokter = id_dokter;
            Nama_dokter = nama_dokter;
            Id_pasien = id_pasien;
        }
        public KartuKontrol()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            Id_dokter = new Akun();
            Nama_dokter = "";
            Id_pasien = new Akun();
        }


        #endregion
        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Akun Id_dokter { get => id_dokter; set => id_dokter = value; }
        public string Nama_dokter { get => nama_dokter; set => nama_dokter = value; }
        public Akun Id_pasien { get => id_pasien; set => id_pasien = value; }

        #endregion
        #region Methods

        public static List<KartuKontrol> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                //sql = "select * from kartu_kontrol kk inner join akun a inner join posisi p where a.id = kk.id_dokter";
                sql = "select kk.id, kk.tanggal, kk.id_dokter, a.nama, kk.id_pasien from kartu_kontrol kk inner join akun a where a.id = kk.id_dokter";
            }
            else
            {
                sql = $"select kk.id, kk.tanggal, kk.id_dokter, a.nama, kk.id_pasien from kartu_kontrol kk inner join akun a where a.id = kk.id_dokter where {kriteria} like '%{nilaiKriteria}%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<KartuKontrol> listKartuKontrol = new List<KartuKontrol>();
            while(hasil.Read() == true)
            {
                KartuKontrol kk = new KartuKontrol();
                kk.Id = hasil.GetInt32(0);
                kk.Tanggal = hasil.GetDateTime(1);
                Akun a = new Akun();
                a.Id = hasil.GetInt32(2);
                a.Nama = hasil.GetString(3);
                kk.Id_dokter = a;
                kk.Nama_dokter = a.Nama;
                Akun a2 = new Akun();
                a2.Id = hasil.GetInt32(4);
                kk.Id_pasien = a2;

                listKartuKontrol.Add(kk);
            }
            return listKartuKontrol;
        }
        public static Boolean HapusData(KartuKontrol KartuKontrol)
        {
            string perintah = "DELETE FROM kartu_kontrol WHERE id='" + KartuKontrol.Id + "'";
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

        public static int GenerateIdKartuKontrol()
        {
            string sql = "select max(id) from kartu_kontrol";
            int hasilNo = 0;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int id = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilNo = id;
                }
                else
                {
                    hasilNo = 0;
                }
            }

            return hasilNo;
        }

        #endregion
    }
}
