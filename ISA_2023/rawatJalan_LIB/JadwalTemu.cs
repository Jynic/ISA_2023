using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
namespace rawatJalan_LIB
{
    public class JadwalTemu
    {
        #region DATA MEMBER
        int id;
        DateTime tanggal;
        string status;
        string keluhan;
        Akun akun_pasien;
        Akun akun_dokter;
        #endregion
        #region CONSTRUCTOR
        public JadwalTemu(int id, DateTime tanggal, string status, string keluhan, Akun akun_pasien, Akun akun_dokter)
        {
            Id = id;
            Tanggal = tanggal;
            Status = status;
            Keluhan = keluhan;
            Akun_pasien = akun_pasien;
            Akun_dokter = akun_dokter;
        }
        public JadwalTemu()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            Status = "";
            Keluhan = "";
            Akun_pasien = new Akun();
            Akun_dokter = new Akun();
        }
        public JadwalTemu(int id)
        {
            Id = id;
        }
        #endregion
        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Status { get => status; set => status = value; }
        public string Keluhan { get => keluhan; set => keluhan = value; }
        public Akun Akun_pasien { get => akun_pasien; set => akun_pasien = value; }
        public Akun Akun_dokter { get => akun_dokter; set => akun_dokter = value; }
        #endregion
        #region METHOD
        public static List<JadwalTemu> BacaData()
        {

            string sql = "select * from jadwal_janji_temu";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<JadwalTemu> listJadwalTemu = new List<JadwalTemu>();

            while (hasil.Read() == true)
            {
                JadwalTemu jadwal = new JadwalTemu();
                jadwal.Id = int.Parse(hasil.GetString(0));
                jadwal.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                jadwal.Status = hasil.GetString(2);
                jadwal.Keluhan = hasil.GetString(3);
                Akun akunPasien = new Akun();
                akunPasien.Id = hasil.GetInt32(4);
                jadwal.Akun_pasien = akunPasien;
                Akun akunDokter = new Akun();
                akunDokter.Id = hasil.GetInt32(5);
                jadwal.Akun_dokter = akunDokter;
                listJadwalTemu.Add(jadwal);
            }
            return listJadwalTemu;
        }
        public static List<JadwalTemu> BacaDataPasien(int id)
        {

            string sql = "select * from jadwal_janji_temu where akun_pasien = " + id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<JadwalTemu> listJadwalTemu = new List<JadwalTemu>();

            while (hasil.Read() == true)
            {
                JadwalTemu jadwal = new JadwalTemu();
                jadwal.Id = int.Parse(hasil.GetString(0));
                jadwal.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                jadwal.Status = hasil.GetString(2);
                jadwal.Keluhan = hasil.GetString(3);
                Akun akunPasien = new Akun();
                akunPasien.Id = hasil.GetInt32(4);
                jadwal.Akun_pasien = akunPasien;
                Akun akunDokter = new Akun();
                akunDokter.Id = hasil.GetInt32(5);
                jadwal.Akun_dokter = akunDokter;
                listJadwalTemu.Add(jadwal);
            }
            return listJadwalTemu;
        }
        public static List<JadwalTemu> BacaDataDokter(int id)
        {

            string sql = "select * from jadwal_janji_temu where akun_dokter = " + id;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<JadwalTemu> listJadwalTemu = new List<JadwalTemu>();

            while (hasil.Read() == true)
            {
                JadwalTemu jadwal = new JadwalTemu();
                jadwal.Id = int.Parse(hasil.GetString(0));
                jadwal.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                jadwal.Status = hasil.GetString(2);
                jadwal.Keluhan = hasil.GetString(3);
                Akun akunPasien = new Akun();
                akunPasien.Id = hasil.GetInt32(4);
                jadwal.Akun_pasien = akunPasien;
                Akun akunDokter = new Akun();
                akunDokter.Id = hasil.GetInt32(5);
                jadwal.Akun_dokter = akunDokter;
                listJadwalTemu.Add(jadwal);
            }
            return listJadwalTemu;
        }
        public static Boolean TambahData(JadwalTemu j)
        {
            string sql = "insert into jadwal_janji_temu(id, tanggal, status, keluhan, akun_pasien, akun_dokter) values (" + j.id + ",'" + j.Tanggal.ToString("yyyy-MM-dd HH:mm:ss") + "','" + "Belum Bertemu" + "','" + j.Keluhan + "','" + j.Akun_pasien + "','" + j.Akun_dokter + "')";


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
        public static Boolean HapusData(JadwalTemu j)
        {
            string sql = "delete from jadwal_janji_temu where id = '" + j.Id + "'";
            int jumlahDiubah = Convert.ToInt32(Koneksi.JalankanPerintahDML(sql));
            if (jumlahDiubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Boolean UbahStatusJadwal(int id)
        {
            string sql = "update jadwal_janji_temu set status = '" + "Bertemu" + "' where id = " + id;
            int ubahData = Koneksi.JalankanPerintahDML(sql);
            if (ubahData == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string GenerateId()
        {
            string sql = "select max(id) from jadwal_janji_temu";

            string hasilCode = "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int codeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilCode = codeTerbaru.ToString();
                }
                else
                {
                    hasilCode = "1";
                }

            }

            return hasilCode;
        }
        public override string ToString()
        {
            return Id.ToString();
        }

        #endregion
    }
}
