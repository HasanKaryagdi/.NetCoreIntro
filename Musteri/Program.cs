using System;
using ClassMetotDemo;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMetotDemo.Musteri musteri1 = new ClassMetotDemo.Musteri();
            musteri1.Ad = "Hasan";
            musteri1.Soyad = "Kabba";
            musteri1.Unvan = "Bılgısayar prg";
            ClassMetotDemo.Musteri musteri2 = new ClassMetotDemo.Musteri();
            musteri2.Ad = "Hasan";
            musteri2.Soyad = "Kabba";
            musteri2.Unvan = "Bılgısayar prg";


            MusteriManager[] musteriManagers = new MusteriManager[]
            {
                musteri1, musteri2
            }
        }
    }
}
