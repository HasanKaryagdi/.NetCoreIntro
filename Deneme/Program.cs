using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Renk = "Mavi";
            araba1.Fiyat = 35000;
            araba1.Marka = "Fiat";
            Araba araba2 = new Araba();
            araba2.Renk = "pembe";
            araba2.Fiyat = 450000;
            araba2.Marka = "BMW";


            ArabaManager arabaManager = new ArabaManager();
            arabaManager.Ekle(araba1);
            arabaManager.Ekle(araba2);
        }
    }
}
