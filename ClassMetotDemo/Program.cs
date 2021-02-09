using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 001;
            musteri1.Adı = "Ahmet";
            musteri1.Soyadı = "Balyoz";
            musteri1.Yası = 10;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 002;
            musteri2.Adı = "Mehmet";
            musteri2.Soyadı = "Tank";
            musteri2.Yası = 20;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 003;
            musteri3.Adı = "Taner";
            musteri3.Soyadı = "Tarak";
            musteri3.Yası = 30;


            Musteri[] musteris = new Musteri[]
            {
                musteri1,musteri2,musteri3
            };
            Console.WriteLine("-------------------EKLE-------------------------");
            MusteriManager musteriManager = new MusteriManager();
            {
                musteriManager.Ekle(musteri1);
                musteriManager.Ekle(musteri2);
                musteriManager.Ekle(musteri3);
            }
            Console.WriteLine("--------------------LİSTELE-----------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("--------------------SİL-----------------------");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            foreach (var musteri in musteris)
            {
               musteriManager.Listele(musteri);
            }


        }
    }
}
