using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Posisi
    {
        int id;
        string nama;

        public Posisi(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public Posisi()
        {
            Id = 0;
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        #region Methods
        public static List<Posisi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from posisi";
            }
            else
            {
                sql = "select * from posisi where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Posisi> listPosition = new List<Posisi>();
            while (hasil.Read() == true)
            {
                Posisi po = new Posisi(hasil.GetInt32(0), hasil.GetValue(1).ToString());
                listPosition.Add(po);
            }
            return listPosition;
        }
        #endregion
    }
}
