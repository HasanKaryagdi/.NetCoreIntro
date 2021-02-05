using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
    class ArabaManager
    {
        public void Ekle(Araba araba)
        {
            Console.WriteLine("Seçilen araç bilgileri : " + araba.Marka);
            Console.WriteLine("Seçilen araç bilgileri : " + araba.Renk);
            Console.WriteLine("Seçilen araç bilgileri : " + araba.Fiyat);
        }
    }
}
