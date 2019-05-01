using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2279
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gaji)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gaji;
        }

        //method
        public void NaikGaji()
        {
            GajiBulanan = GajiBulanan + GajiBulanan / 10;
        }

    }
}