using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }

        public Sales(String nik = "No Nik", string nama = "No Name", int komisi = 0, int jumlahpenjualan = 0)
        {
            this.Komisi = jumlahpenjualan;
            this.JumlahPenjualan = jumlahpenjualan;
        }

        public override int Gaji()
        {
            int Gaji;
            Gaji = JumlahPenjualan * Komisi;
            return Gaji;
        }
    }
}
