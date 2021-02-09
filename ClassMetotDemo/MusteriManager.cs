using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri EMusteri)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri Eklendi : " + EMusteri.ID);
            Console.WriteLine("Müşteri Eklendi : " + EMusteri.Adı);
            Console.WriteLine("Müşteri Eklendi : " + EMusteri.Soyadı);
            Console.WriteLine("Müşteri Eklendi : " + EMusteri.Yası);
            Console.WriteLine("---------------------------------");
        }

        public void Listele(Musteri LMusteri)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri Listelendi : " + LMusteri.ID);
            Console.WriteLine("Müşteri Listelendi : " + LMusteri.Adı);
            Console.WriteLine("Müşteri Listelendi : " + LMusteri.Soyadı);
            Console.WriteLine("Müşteri Listelendi : " + LMusteri.Yası);
            Console.WriteLine("---------------------------------");
        }

        public void Sil(Musteri SMusteri)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Müşteri Silindi :" + SMusteri.ID);
            Console.WriteLine("Müşteri Silindi :" + SMusteri.Adı);
            Console.WriteLine("Müşteri Silindi :" + SMusteri.Soyadı);
            Console.WriteLine("Müşteri Silindi :" + SMusteri.Yası);
            Console.WriteLine("---------------------------------");
        }
    }
}
