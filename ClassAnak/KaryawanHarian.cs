using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPemrograman11.Employee
{
    public class KaryawanHarian : Karyawan
    {
        public int UpahPerJam { get; set; }
        public int JumlahJamKerja { get; set; }

        public KaryawanHarian(String nik = "No Nik", string nama = "No Name", int upahperjam = 0, int jumlahjamkerja = 0)
        {
            this.UpahPerJam = upahperjam;
            this.JumlahJamKerja = JumlahJamKerja;
        }

        public override int Gaji()
        {
            int Gaji;
            Gaji = UpahPerJam * JumlahJamKerja;
            return Gaji;
        }
    }
}
