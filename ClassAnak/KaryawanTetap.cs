using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }

        public override double Gaji()
        {
            double gaji;
            gaji = GajiBulanan;
            return gaji;
        }
    }
}
