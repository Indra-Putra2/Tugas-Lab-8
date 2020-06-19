using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TugasPemrograman11.Employee;

namespace LabExerciseWeek11
{
	class Program
	{
		static void Main(string[] args)
		{
			//making objects for all employees
			KaryawanTetap karyawanTetap = new KaryawanTetap();
			karyawanTetap.NIK = "20.11.324";
			karyawanTetap.Nama = "Tejo Yuono";
			karyawanTetap.GajiBulanan = 25000000;

			KaryawanHarian karyawanHarian = new KaryawanHarian();
			karyawanHarian.NIK = "20.06.663";
			karyawanHarian.Nama = "Ari Bagus Hidayat";
			karyawanHarian.JumlahJamKerja = 8;
			karyawanHarian.UpahPerJam = 15000;

			Sales sales = new Sales();
			sales.NIK = "20.05.663";
			sales.Nama = "Indra Putra Gemilang";
			sales.JumlahPenjualan = 25;
			sales.Komisi = 35000;

			//object class collection
			List<Karyawan> listKaryawan = new List<Karyawan>();

			listKaryawan.Add(karyawanTetap);
			listKaryawan.Add(karyawanHarian);
			listKaryawan.Add(sales);

			int numberSequence = 1;

			foreach (Karyawan emps in listKaryawan)
			{
				Console.WriteLine("{0}, NIK: {1}, Nama: {2}, Gaji: {3:N0}",
					numberSequence, emps.NIK, emps.Nama, emps.Gaji());

				numberSequence++;
			}

			Console.ReadKey();
		}
	}
}