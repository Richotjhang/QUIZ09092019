using System;

namespace QUIZ090902019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar kelas = new BangunDatar();

            Console.WriteLine("Kelas saya adalah " +kelas.tampil()+"\n");
            kelas.luas_segitiga();
            kelas.luas_kubus();
            kelas.luas_lingkaran();

            BangunRuang kelasai= new BangunRuang();

            Console.WriteLine("Kelas saya adalah " +kelasai.tampil()+"\n");

            kelasai.volume_balok();
            kelasai.volume_kubus();
        }
    }
}
