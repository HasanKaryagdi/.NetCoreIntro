using System;

namespace Metotlar
{
    class Program
    {    //METOTLAR
        //TEKRAR TEKRAR KULLANIRLIĞI SAĞLAYAN KOD BLOKLARI

        //Don't repeat yourself -DRY
        //Clean Code
        //Best Practice
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[]
            {
                urun2,urun1
            };

            //type-safe --Tip Güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("--------METOTLAR----------------");



            //İnstance -Örnek
            //Encapsulation =>Kapsulleme


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
