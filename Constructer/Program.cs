using System;
using System.Threading.Channels;

namespace Constructer
{
    class Program
    {
        static void Main(string[] args)
        {
        

         Customer customer = new Customer(1, "HASAN", "KARYAPDI", "KARABÜK");
         Console.WriteLine(customer.Id);
         Console.WriteLine(customer.FirstName);
         Console.WriteLine(customer.LastName);
         Console.WriteLine(customer.City);
        //Classı newleyince çalışan bloktur.
        //    //Yapıcı Blok
        //    Customer customer1 = new Customer { Id = 1, FirstName = "Hasan", LastName = "Karyağdı", City = "Karabük" };


        //    Customer customer3 = new Customer();
        //    customer3.Id = 3;


        //    Customer customer2 = new Customer ( 2, "Betül", "Karyağdı", "Ankara" );
        //    Console.WriteLine(customer2.Id);
        //    Console.WriteLine(customer2.FirstName);
        //    Console.WriteLine(customer2.LastName);
        //    Console.WriteLine(customer2.City);
    }
}

    //class Customer
    //{
    //    public Customer()
    //    {

    //    }
    //    //Default constructor
    //    public Customer(int id, string firstName, string lastName, string city)
    //    {
    //        Id = id;
    //        FirstName = firstName;
    //        LastName = lastName;
    //        City = city;
    //    }
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string City { get; set; }
    //}
    class Customer
    {
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}