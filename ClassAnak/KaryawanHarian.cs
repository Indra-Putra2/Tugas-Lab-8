using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        
        public override double Gaji()
        {
            double gaji;
            gaji = UpahPerJam * JumlahJamKerja;
            return gaji;
        }
    }
}
