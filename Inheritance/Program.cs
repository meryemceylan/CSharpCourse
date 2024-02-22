using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] 
            { new Person{FirstName="Ahmet" } , new Customer{FirstName="Samet" }, new Student{FirstName="Meryem" }};

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
            
        }
    }
    class Person // inheritancelar tek başına bir anlam ifade eder ama interfaceler etmez
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson
    {

    }
    class Customer : Person // : IPerson --> önce inheritance sonra interface yazılır. !! Birden fazla inheritance almaz
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
