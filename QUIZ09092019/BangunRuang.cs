using System;

namespace QUIZ090902019
{
    class BangunRuang
    {
        public string tampil()
        {
            return "X TKJ 1";
        }

        public void volume_balok()
        {
            int panjang, lebar, tinggi, volume;

            Console.WriteLine("-----------------------");            
            Console.WriteLine("Menghitung Volume Balok");

            Console.Write("Masukkan Panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume Balok Adalah "+volume+"\n");
        }
        public void volume_kubus()
        {
            int sisi, volume;

            Console.WriteLine("-----------------------");            
            Console.WriteLine("Menghitung Volume Kubus");

            Console.Write("Masukkan Sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            volume = sisi * sisi * sisi;

            Console.WriteLine("Volume Kubus Adalah "+volume+"\n");
        }
    }
}
