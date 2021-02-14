using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            //Soyutlama
            //Müşteri kredi şubeleri yönetmek
            //Müşteriler gerçek ve tüzel ( şirketler)
            //SOLID
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Karyağdı";
            musteri1.TcNo = "212414123";


            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "13124";
            musteri2.SirketAdi = "BLA BLA";
            musteri2.VergiNo = "12423423";



            //GercekMusteri(); =>referans Numarası
            //Musteri => hem Gercek hemde Tuzel Müşterinin referansını tutabiliyor
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //57.46
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);
        }
    }
}
