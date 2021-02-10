using System;

namespace RecerenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean =>Value Types(Deger tipler)
            int sayi1 = 10; // 10
            int sayi2 = 20; // 20

            sayi1 = sayi2; // 20

            sayi2 = 100;

            //Ekran Çıktısı = Sayı 1: 20
            Console.WriteLine("Sayı 1 : " + sayi1);


            // STACK
            //Değer Tipler 
            //Sayi = 10;
            //Sayi2 = 20;
            //Sayi1 = Sayi2 ;20




            //arrays,class,İnterface... => reference types
            //int[] sayilar1 = new[] { 1, 2, 3 };
            //int[] sayilar2 = new[] { 10, 20, 30 };

            //sayilar1 = sayilar2; // sayılar1'in adresi eşittir sayılar2
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayılar 1[0] = " + sayilar1[0]);


            //Stack                   ||             //Heap

            //101 int[] sayilar1 Sayilar1      || AdresDeğeri101        //new[] { 1, 2, 3 }; 


            //102int[] sayilar2                || AdresDeğeri102       //new[] { 10, 20, 30 };




            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Hasan";  // HASAN

            person2 = person1;
            person1.FirstName = "Mehmet";
            //Console.WriteLine(person2.FirstName); // MEHMET




            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCarNumber = "1231231231";


            Employee employee = new Employee();
            employee.FirstName = "EmployeeVeli";

            Person person3 = customer;
            customer.FirstName = "CAN";

            //Console.WriteLine(((Customer)person3).CreditCarNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

            //employee.EmployeeNumber = 4;
            //customer = employee; farklı tipler olduğundan atama yapılamaz
            //Person person3 = customer;
            ////Person person4 = employee;
            //Console.WriteLine(person3.FirstName); //AHMET
            ////Console.WriteLine(employee.EmployeeNumber);  // 4
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Base Class :Person =>Temel Sınıf
    class Customer : Person
    {
        public string CreditCarNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
