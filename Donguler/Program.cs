using System;

namespace Donguler
{
    class Program
    {

        //Birbirine benzeyen işlemleri tekrar etmek için kullanırız
        static void Main(string[] args)
        {
            //string kurs1 = "C#";
            //string kurs2 = "Python";
            //string kurs3 = "SQL";
            //string kurs4 = "MONGODB";
            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);
            //Console.WriteLine(kurs4);

            string[] Meyveler = new string[]
            {
               "Elma",
               "Armut",
               "Muz",
               "Kiraz",
               "Kivi"
            };

            //FOR DÖNGÜSÜ
            ////for (int i = 0; i < Meyveler.Length; i++)
            ////{
            ////    Console.WriteLine(Meyveler[i]);
            ////}



            // FOREACH DÖNGÜSÜ
            //Dizi temelli yapıları tek tek dönmeyi sağlar
            //Dizilere uygulanır
            foreach (string meyve in Meyveler)
            {
                Console.WriteLine(meyve);
            }
            Console.WriteLine("Ürünler Eklendi");

        }

    }
}
