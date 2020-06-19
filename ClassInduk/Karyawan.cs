using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public abstract class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }

        public Karyawan(String nik = "No Nik", string nama = "No Name")
        {
            this.NIK = nik;
            this.Nama = nama;
        }

        public abstract int Gaji();
    }
}
