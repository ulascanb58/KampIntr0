using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           CustomerManager cstMngr = new CustomerManager();
           cstMngr.Update();


           Customer customer = new Customer();
           customer.City = "İzmir";
           customer.Id = 1;
           customer.FirstName = "Engin";
           customer.LastName = "Demiroğ";

           Customer customer2= new Customer
           {
               Id=2,City = "İstanbul",FirstName ="Derin",LastName = "Demiroğ"


           };

           Console.WriteLine(customer2.FirstName);

           Console.ReadLine();
        }

        
    }
}
