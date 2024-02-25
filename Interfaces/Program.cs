using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            // InterfacesDemo();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());




            ICustomerDal[] customerDals = new ICustomerDal[2] 
            { 
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void InterfacesDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            manager.Add(customer);

            Student student = new Student { Id = 1, FirstName = "Meryem", LastName = "Ceylan", Departmant = "Computer Sciences" };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        //implemented operation : içi doldurulmuş, tamamlanmış operasyon
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    
    
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();

    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        
    }

}
