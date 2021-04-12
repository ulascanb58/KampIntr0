using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {ID=1,FirstName = "Engin",LastName = "Demiroğ",City = "Ankara"};

            Customer customer3 = new Customer();
            customer3.ID = 5;

            Customer customer2=new Customer(2,"Derin","Demiroğ","Ankara");
            
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

        }

        
    }

    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            City = city;

        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
