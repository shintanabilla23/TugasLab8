using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";
            Console.WriteLine("SHINTA NAABILLA EMI HAYU SETYAWAN");
            Console.WriteLine("           19.11.2821            ");
            Console.WriteLine("");

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "2030088772232676";
            karyawanTetap.Nama = "Elena Gilbert";
            karyawanTetap.GajiBulanan = 4300000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "1040029827856642";
            karyawanHarian.Nama = "Damon Salvatore";
            karyawanHarian.JumlahJamKerja = 10;
            karyawanHarian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "3030028374654547";
            sales.Nama = "Niklaus Mikaelson";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}