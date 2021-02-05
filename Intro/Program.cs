using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler veri tutuculardır.
            //e-ticaretten bankalara kadar 
            //Type Safety -Tip Güvenliği
            //Do not repeat yourself - Kendini Tekrarlama

            //Değişkenler
            //Değer Tutucu,alias 
            string KategoriEtiketi = "Kategori"; //Karakter
            int ogrenciSayisi = 32000;  //Sayısal
            double faizoranı = 1.45;    //ondalıklık 
            bool SistemeGirisYapmisMi = true; //True-False
            double dolardun = 7.35;
            double dolarBugun = 7.45;




            //Şart Blokları
            if (dolardun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolardun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else 
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            ////////////////////////////////////////////////////
            
            if (SistemeGirisYapmisMi == true)  
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(KategoriEtiketi);


        }
        
    }
}
