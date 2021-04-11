using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(NCustomer customer)
        {
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerSurname);
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine("Eklendi");
            Console.WriteLine("----------------");
        }

        public void DeleteCustomer(NCustomer customer)
        {
            
            Console.WriteLine(customer.CustomerId + " ' ID li kayıt Silindi");
            Console.WriteLine("----------------");
        }
    }
}
