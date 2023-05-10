using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Apotek
    {
        int id, quantity;
        string nama_obat;

        public Apotek(int id, string nama_obat , int quantity)
        {
            Id = id;
            Quantity = quantity;
            Nama_obat = nama_obat;
        }
        public Apotek(int id)
        {
            Id = id;
        }
        public Apotek(string nama)
        {
            Nama_obat = nama;
        }

        public int Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Nama_obat { get => nama_obat; set => nama_obat = value; }

        public static List<Apotek> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from apotek";
            }
            else
            {
                sql = "select * from apotek where '"+kriteria+"' like '%"+nilaiKriteria+"%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Apotek> listApotek = new List<Apotek>();
            while (hasil.Read() == true)
            {
                Apotek apotek = new Apotek(int.Parse(hasil.GetString(0)), hasil.GetString(1), int.Parse(hasil.GetString(2)));
                listApotek.Add(apotek);
            }
            return listApotek;
        }
        public static int GenerateID()
        {
            string sql = "select max(id) from apotek";
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
        public static void TambahData(Apotek a)
        {
            string sql = "insert into apotek (id, nama_obat, quantity) values ("+a.Id+", '"+a.Nama_obat+"', "+a.Quantity+")";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Apotek a)
        {
            string sql = "delete from apotek where id="+a.Id+" ";
            Koneksi.JalankanPerintahDML(sql);
        }
        public override string ToString()
        {
            return Id.ToString();
        }
        public static void UpdateQuantity(Apotek a)
        {
            string sql = "uddate apotek set quantity = '"+a.Quantity+"'";
            Koneksi.JalankanPerintahDML(sql);
        }
        
    }
}
