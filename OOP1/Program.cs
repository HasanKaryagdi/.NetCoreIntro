using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.YOL
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrıce = 500;
            product1.UnıtsInStock = 3;


            //2. YOL
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnıtsInStock = 5,
                ProductName = "Kalem",
                UnıtPrıce = 35
            };

            //Case sensitive
            //PascalCase   //camelCase  
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



        }
    }
}
