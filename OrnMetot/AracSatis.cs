using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using Metotlar;

namespace OrnMetot
{
    class AracSatis
    {
        public void Ekle(Araba araba)
        {
            Console.WriteLine("Arabalar" + araba.Marka);
        }
    }
}
