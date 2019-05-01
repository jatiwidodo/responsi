using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2279
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek Karyawan baru
            Karyawan karyawan1 = new Karyawan("18.11.2279", "jaty", 4000000);
            Karyawan karyawan2 = new Karyawan("22.79.1118", "paijo", 3000000);

            //Nampilkan Gaji
            Console.WriteLine("No NIK/Nama            Gaji Bulanan");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. {0} {1}        {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} {1}         {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine();

            //naik Gaji
            karyawan1.NaikGaji();
            karyawan2.NaikGaji();

            //Nampilkan Gaji
            Console.WriteLine("No NIK/Nama            Gaji Bulanan");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. {0} {1}        {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} {1}         {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);


        }
    }
}