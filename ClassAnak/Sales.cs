using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji()
        {
            double gaji;
            gaji = JumlahPenjualan * Komisi;
            return gaji;
        }
    }
}
