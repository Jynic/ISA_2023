using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Posisi
    {
        private int id;
        private string nama;

        public Posisi(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public Posisi(string nama)
        {
            Nama = nama;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}
