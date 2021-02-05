using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming Convention
        //Syntax
        //() =>Metot Çalışıyor
        // Urun =>Tipi
        //urun =>Kullanılacak
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi!  : " + urun.Adi);
        }


    }
}
