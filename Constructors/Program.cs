using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="Meryem",LastName="Ceylan", City="İstanbul"};
            Customer customer2 = new Customer(2, "Mustafa", "Çelik", "Sivas");

            Console.WriteLine(customer2.FirstName);

            
            Console.ReadLine();
        }
        //static void Method(int id, string firstName, string lastName, string city)
        //{

        //}
    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı");
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
