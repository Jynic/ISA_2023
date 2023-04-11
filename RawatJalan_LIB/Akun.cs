using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawatJalan_LIB
{
    public class Akun
    {
        int id;
        string nama;
        string nik;
        string alamat;
        DateTime tempat_tanggal_lahir;
        Posisi posisi_id;
        string username;
        string password;

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

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime Tempat_tanggal_lahir { get => tempat_tanggal_lahir; set => tempat_tanggal_lahir = value; }
        public Posisi Posisi_id { get => posisi_id; set => posisi_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; private set => password = value; }
    }
}
