using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDEM0.Entities;

namespace InterfaceAbstractDEM0.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void Save(Customer customer)
        {
           Console.WriteLine("Saved to DB : " +customer.FirstName);
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Updated to DB : " + customer.FirstName);
        }

        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Deleted from DB : " + customer.FirstName);
        }
    }
}
