using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Akun_has_Apotek
    {
        int id;
        Akun akun;
        Apotek obat;
        string status;

        public Akun_has_Apotek(int id, Akun akun, Apotek obat, string status)
        {
            Id = id;
            Akun = akun;
            Obat = obat;
            Status = status;
        }
        public Akun_has_Apotek(int id, Akun akun, Apotek obat)
        {
            Id = id;
            Akun = akun;
            Obat = obat;
        }
        public Akun_has_Apotek(Akun a, Apotek b, string status)
        {
            Akun = a;
            Obat = b;
            Status = status;
        }

        public Akun Akun { get => akun; set => akun = value; }
        public Apotek Obat { get => obat; set => obat = value; }
        public string Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }

        public static void TambahData(Akun_has_Apotek aha)
        {
            string sql = "insert into akun_has_apotek (id, akun_id, id_obat, status) values ('"+aha.Id+"','" + aha.Akun + "', '" + aha.Obat + "', 'Tolak')";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static List<Akun_has_Apotek> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select id, akun_id, id_obat, status from akun_has_apotek";
            }
            else
            {
                sql = "select * from akun_has_apotek where '"+kriteria+"' like '%"+nilaiKriteria+"%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Akun_has_Apotek> listAkunhasApotek = new List<Akun_has_Apotek>();
            while (hasil.Read() == true)
            {
                Apotek apotek = new Apotek(int.Parse(hasil.GetValue(2).ToString()));
                Akun akun = new Akun(int.Parse(hasil.GetValue(1).ToString()));
                Akun_has_Apotek akunhasapotek = new Akun_has_Apotek(int.Parse(hasil.GetString(0)) ,akun, apotek, hasil.GetString(3));
                listAkunhasApotek.Add(akunhasapotek);
            }
            return listAkunhasApotek;
        }
        public static List<Akun_has_Apotek> BacaDataPasien()
        {
            string sql = "";
            sql = "select a.id, ap.id, aha.status from akun a inner join akun_has_apotek aha on a.id=aha.akun_id inner join apotek ap on aha.id_obat=ap.id" ;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Akun_has_Apotek> listaha = new List<Akun_has_Apotek>();
            while (hasil.Read() == true)
            {
                Akun a = new Akun(int.Parse(hasil.GetString(0)));
                Apotek b = new Apotek(int.Parse(hasil.GetString(1)));
                Akun_has_Apotek aha = new Akun_has_Apotek(a, b, hasil.GetString(2));
                listaha.Add(aha);
            }
            return listaha;
        }
        public static void UbahData(Akun_has_Apotek a)
        {
            string sql = "update akun_has_apotek set status='Terima' where id = '"+a.Id+"'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static int GenerateID()
        {
            string sql = "select max(id) from akun_has_apotek";
            int idbaru = 0;
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                string bantu = hasil.GetString(0);
                if (bantu != "")
                {
                    idbaru = int.Parse(hasil.GetString(0)) + 1;
                }
                else
                {
                    idbaru = 0;
                }

            }
            return idbaru;
        }
    }
}
