using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //MEthod İnjection
        //Çoğul loglama yollama List ile gönderme
        public void BasvuruYap(IKrediBaseManager krediBaseManager,List<ILoggerService> loggerServices)
        {
            //Başvuran Bilgilerini Değerlendirme
            //

            krediBaseManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //Hangi Loglayıcı seçilmişse sistemde onu logla diyorum


            //Tüm başvuruları  Konut Kredisi üzerinden Hesaplanır durumuna getirdin.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); 
        }



        //Belirsiz bir kredimanager seçimi yapılacak
        //Aynı veri türünde Bir veri grubu oluşturmak için (List<>)
        //Bİrden fazla kredi hesabı
        //Gönderilen her bir krediyi tek tek dolaşması gerek
        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
