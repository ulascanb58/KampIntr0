using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int[] sayilar1=new int[]{1,2,3};
        //    int[]sayilar2=new int[]{10,20,30};
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            
            Employee employee = new Employee();
            employee.FirstName = "HAYDARKO";

           customer.FirstName = "Salih";
            customer.CreditCardNumber = "12";
            Person person3 = customer;

        //    Console.WriteLine(person3.FirstName);

        //    Console.WriteLine(((Customer)person3).CreditCardNumber);

           

            PersonManager personManager=new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);
            Console.ReadLine();



        }


        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }


        //base class : Person
        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
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

}
