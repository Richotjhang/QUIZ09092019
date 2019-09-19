using System;

namespace QUIZ090902019
{
    class BangunDatar
    {
        public string tampil()
        {
            return "X TKJ 1";
        }

        public void luas_segitiga()
        {
            int luas, alas, tinggi;

            Console.WriteLine("------------------------");
            Console.WriteLine("Menghitung Luas Segitiga");

            Console.Write("Masukkan Nilai Alas : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai Tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi * 1/2;

            Console.WriteLine("Luas Segitiga Adalah "+luas+"\n");
        }
        public void luas_kubus()
        {
            int sisi, luas;

            Console.WriteLine("---------------------");
            Console.WriteLine("Menghitung Luas Kubus");

            Console.Write("Masukkan Nilai Sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = 6 * sisi * sisi;

            Console.WriteLine("Luas Kubus Adalah "+luas+"\n");
        }

        public void luas_lingkaran()
        {
            int jari, luas;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Menghitung Luas Lingkaran");

            Console.Write("Masukkan Jari-Jari :");
            jari = Convert.ToInt32(Console.ReadLine());

            luas = jari * jari * 22/7;

            Console.WriteLine("Luas Lingkaran Adalah "+luas+"\n");
        } 
    }
}