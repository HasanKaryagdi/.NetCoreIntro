using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri Emusteri)
        {
            Console.WriteLine("Müsteri Eklendi : " + Emusteri.Ad);
            Console.WriteLine("Müsteri Eklendi : " + Emusteri.Soyad);
            Console.WriteLine("Müsteri Eklendi : " + Emusteri.Unvan);
        }

        public void Listele(Musteri LMusteri)
        {
            Console.WriteLine("Müşteri Listelendi : "+LMusteri.Ad);
            Console.WriteLine("Müşteri Listelendi : "+LMusteri.Soyad);
            Console.WriteLine("Müşteri Listelendi : "+LMusteri.Unvan);
        }

        public void Sil(Musteri SMusteri)
        {
            Console.WriteLine("Müşteri Silindi : " +SMusteri.Ad);
            Console.WriteLine("Müşteri Silindi : " +SMusteri.Soyad);
            Console.WriteLine("Müşteri Silindi : " +SMusteri.Unvan);
        }
    }
}
