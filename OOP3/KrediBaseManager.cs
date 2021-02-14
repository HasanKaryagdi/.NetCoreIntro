using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // 3 classta hesaplayı farklı alır
    // tek basına anlam ıfade etmıyor
    //Imzanın aynı olduğu ama,içerisinimn farklı olduğu durumlarda biz
    // Base oluşturduğumuz classı Interface olarak değiştiriyoruz


    //Interfaces = > şablon görevii görüyor ve Genelde Operasyonel metotlarda kullanılır 
    //Okunurluğu arttırmak için Interfaceler "I" Harfi ile başlatırız.
    //alttaki şablona uymak zorundasınız
    //Manager classlar Implament edildi.
    //IKrediBaseManager BİR INTERFACES
    interface IKrediBaseManager
    {

        void Hesapla();

        void BiseyYap();
    }
}
