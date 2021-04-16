using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Abstract;
using GameOdev5.Entity;

namespace GameOdev5.Concrete
{
    class CustomerManager:ICustomerService
    {
        
        CustomerValidationManager customerValidationManager;// = new CustomerValidationManager();

        public CustomerManager(CustomerValidationManager customerValidationManager)
        {
            this.customerValidationManager = customerValidationManager;
        }

        public void Register(Customer customer)
        {
            if(customerValidationManager.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Kayıt başarılı, Müşteri Adı : " + customer.FirstName);
            }
            else
            {
                Console.WriteLine("Kayıt başarısız ");
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Güncelleme başarılı, Müşteri ID : "+customer.CustomerID);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerID + " Id li kayıt silinmiştir.");
        }

        
    }
}
