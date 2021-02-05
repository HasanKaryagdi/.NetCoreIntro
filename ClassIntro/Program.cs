using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classlar Bu Şekilde Tanımlanır
            //Değişken
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hasan";
            kurs1.IzlenmeOrani = 68;

            //Değişken
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mehmet";
            kurs2.IzlenmeOrani = 44;

            //Değişken
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Raşit";
            kurs3.IzlenmeOrani = 80;

            //Değişken
            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Caner";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs2.Egitmen);
            Kurs[] kurs = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3,
                kurs4
            };
            foreach (var Egitim in kurs)
            {
                Console.WriteLine(Egitim.Egitmen + " : " + Egitim.KursAdi+" : "+Egitim.IzlenmeOrani);
            }
        }
    }


    //Kendi veri tipimizi yazıyoruz
    //Tip tanımı yapıldı
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
