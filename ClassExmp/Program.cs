using System;

namespace ClassExmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product category1 = new Product();
            category1.ProductName = "Telefon";
            category1.Piece = 3000;
            category1.Stock = 800;
            Product category2 = new Product();
            category2.ProductName = "Telefon";
            category2.Piece = 3000;
            category2.Stock = 800;
            Product category3 = new Product();
            category3.ProductName = "Telefon";
            category3.Piece = 3000;
            category3.Stock = 800;

            Product[] p = new Product[]
            {
                category1,category2,category3
            };
            Console.WriteLine("FOR DÖNGÜSÜ İLE");
            Console.WriteLine("-----------------");

            for (int i = 0; i < p.Length; i++)
            {

                Console.WriteLine("Ürünün Adı : "+category1.ProductName + "| Ürünün Fiyatı : " + category2.Piece + "| Ürünün Stoğu : " + category3.Stock);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("FOREACH DÖNGÜSÜ İLE");
            Console.WriteLine("-----------------");
            foreach (var Prd in p)
            {
                Console.WriteLine("Ürünün Adı : " + Prd.ProductName + " | Ürünün Fiyatı : " + Prd.Piece + "| Ürünün Stoğu : " + Prd.Stock);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("WHİLE DÖNGÜSÜ İLE");
            Console.WriteLine("-----------------");
            int k = 0;
            while (k < p.Length)
            {
                Console.WriteLine("Ürünün Adı : " + p[k].ProductName + "| Ürünün Fiyatı : " + p[k].Piece + "| Ürünün Stoğu : " + p[k].Stock);
                k++;
            }

        }

        class Product
        {
            public string ProductName { get; set; }
            public int Stock { get; set; }
            public double Piece { get; set; }
        }
    }
}
