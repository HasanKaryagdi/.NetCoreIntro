using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //BAnka kredi örneği
        // 3 tane kredi classı oluşturuldu
        //3 manager clasına inheritence uygulandı.
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();


            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();


            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            //Interface İle
            //İmplamente edilen referanslarıda tutabiliyor
            //IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //IKrediBaseManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //IKrediBaseManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();



            
            IKrediBaseManager ihtiyacKrediBaseManager = new IhtiyacKrediManager();
            IKrediBaseManager konutKrediBaseManager = new KonutKrediManager();
            IKrediBaseManager tasitKrediBaseManager = new TasitKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediBaseManager);

            //KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler) İçin
            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>()
            {
                ihtiyacKrediBaseManager,konutKrediBaseManager,tasitKrediBaseManager
            };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
