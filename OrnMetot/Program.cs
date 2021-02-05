using System;
using Metotlar;

namespace OrnMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Fiyat = 3000;
            araba1.Marka = "Fiat";
            araba1.Renk = "Mavi";
            Araba araba2 = new Araba();
            araba2.Fiyat = 1000;
            araba2.Marka = "Tofaş";
            araba2.Renk = "Sarı";

            //Araba[] arac = new Araba[]
            //{
            //    araba2,araba1
            //};

            //foreach (var a in arac)
            //{
            //    Console.WriteLine(araba1.Fiyat);
            //    Console.WriteLine(araba1.Marka);
            //    Console.WriteLine(araba1.Renk);
            //    Console.WriteLine("-----------");
            //    Console.WriteLine(araba2.Fiyat);
            //    Console.WriteLine(araba2.Marka);
            //    Console.WriteLine(araba2.Renk);
            //}

            Console.WriteLine("--------------------METOTLAR------------------");
            AracSatis aracSatis = new AracSatis();
            aracSatis.Ekle(araba1);
            aracSatis.Ekle(araba2);
        }
    }
}
