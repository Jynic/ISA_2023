using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace rawatJalan_LIB
{
    public class Akun
    {
        #region DATA MEMBER
        int id;
        string nama;
        string nik;
        string alamat;
        DateTime tempat_tanggal_lahir;
        Posisi posisi_id;
        string username;
        string password;
        #endregion
        #region CONSTRUCTOR
        public Akun(int id, string nama, string nik, string alamat, DateTime tempat_tanggal_lahir, Posisi posisi_id, string username, string password)
        {
            Id = id;
            Nama = nama;
            Nik = nik;
            Alamat = alamat;
            Tempat_tanggal_lahir = tempat_tanggal_lahir;
            Posisi_id = posisi_id;
            Username = username;
            Password = password;
        }
        public Akun()
        {
            Id = 0;
            Nama = "";
            Nik = "";
            Alamat = "";
            Tempat_tanggal_lahir = DateTime.Now;
            Posisi_id = new Posisi();
            Username = "";
            Password = "";

        }
        public Akun(int id)
        {
            Id = id;
        }
        public Akun(string nama)
        {
            Nama = nama;
        }
        #endregion
        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tempat_tanggal_lahir { get => tempat_tanggal_lahir; set => tempat_tanggal_lahir = value; }
        public Posisi Posisi_id { get => posisi_id; set => posisi_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; private set => password = value; }
        #endregion

        #region METHOD

        public static Boolean TambahData(Akun akun)
        {
            string sql = "INSERT INTO akun(id, nama, nik, alamat, ttl, posisi_id, username, password) VALUES ('"
                + akun.Id + "','" +
                akun.Nama.Replace("'", "\\'") + "','" + akun.Nik + "','"
                + akun.Alamat + "','" + akun.Tempat_tanggal_lahir.ToString("yyyy-MM-dd HH:mm:ss") + "','" + akun.Posisi_id.Id + "','" + akun.Username + "','" + akun.Password + "')";
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0)
            {
                return false;
            }
            else { return true; }
        }
        public static List<Akun> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select a.id, a.nama, a.nik, a.alamat, a.ttl, a.posisi_id,a.username,a.password"
                   + " from akun a inner join posisi p on a.posisi_id = p.id";
            }
            else
            {
                sql = "select a.id, a.nama, a.nik, a.alamat, a.ttl, a.posisi_id,a.username,a.password"
                   + " from akun a inner join posisi p on a.posisi_id = p.id" + " where " + kriteria + " like '%" +
                   nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Akun> listAkun = new List<Akun>();

            while (hasil.Read() == true)
            {
                Posisi position = new Posisi();
                Akun akun = new Akun();
                akun.Id = int.Parse(hasil.GetString(0));
                listAkun.Add(akun);
            }
            return listAkun;
        }
        public static List<Akun> BacaDataPasien(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select a.id, a.nama, a.nik, a.alamat, a.ttl, a.posisi_id,a.username,a.password"
                   + " from akun a inner join posisi p on a.posisi_id = p.id where p.nama = 'Pasien'";
            }
            else
            {
                sql = "select a.id, a.nama, a.nik, a.alamat, a.ttl, a.posisi_id,a.username,a.password"
                   + " from akun a inner join posisi p on a.posisi_id = p.id" + " where " + kriteria + " like '%" +
                   nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Akun> listAkun = new List<Akun>();

            while (hasil.Read() == true)
            {
                Posisi position = new Posisi();
                Akun akun = new Akun();
                akun.Nama = hasil.GetString(1);
                listAkun.Add(akun);
            }
            return listAkun;
        }

        public static string CekPosisi(Akun akun)
        {
            string sql = "select p.nama " +
                "from akun a inner join posisi p on a.posisi_id = p.id " +
                "where a.nik = '" + akun.Nik + "'";
            string temp = "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                Posisi p = new Posisi();
                p.Nama = hasil.GetString(0);
                temp = p.Nama;
                return temp;
            }
            return temp;
        }

        public static string CekNIK(string username)
        {
            string sql = "select nik " +
                "from akun " +
                "where username = '" + username + "'";
            string temp = "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                temp = hasil.GetString(0);
                return temp;
            }
            return temp;
        }
        public static Akun CekLogin(string username, string password)
        {
            string sql = "select * from akun " +
                "where username ='" + username + "' and password = '" + password + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                Akun akun = new Akun();
                akun.Id = hasil.GetInt32(0);
                akun.Nama = hasil.GetString(1);
                akun.Nik = hasil.GetString(2);
                akun.Alamat = hasil.GetString(3);
                akun.Tempat_tanggal_lahir = hasil.GetDateTime(4);
                Posisi posisi = new Posisi();
                posisi.Id = hasil.GetInt32(5);
                akun.Posisi_id = posisi;
                akun.Username = hasil.GetString(6);
                akun.Password = hasil.GetString(7);
                return akun;
            }
            return null;
        }
        public override string ToString()
        {
            return Id.ToString();
        }

        #endregion
    }
}
