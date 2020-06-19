using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; set; }

        public KaryawanTetap(String nik = "No Nik", string nama = "No Name", int gajibulanan = 0)
        {
            this.NIK = nik;
            this.Nama = nama;
            this.GajiBulanan = gajibulanan;
        }

        public override int Gaji()
        {
            int Gaji;
            Gaji = GajiBulanan;
            //Console.WriteLine("NIK : {0} Nama : {1} Gaji Bulanan : {2}", NIK, Nama, GajiBulanan);
            return Gaji;
        }
    }
}
