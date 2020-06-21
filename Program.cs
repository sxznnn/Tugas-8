using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "2598";
            karyawanTetap.Nama = "Ramadhan";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "2879";
            karyawanHarian.Nama = "Bima";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 120000;

            Sales sales = new Sales();
            sales.NIK = "2673";
            sales.Nama = "Saputra";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 35000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int nomerUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", nomerUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());
                nomerUrut++;
            }

            Console.ReadKey();
        }
    }
}
