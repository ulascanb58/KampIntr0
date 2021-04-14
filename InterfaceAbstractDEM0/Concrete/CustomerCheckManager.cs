using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDEM0.Abstract;
using InterfaceAbstractDEM0.Entities;

namespace InterfaceAbstractDEM0.Concrete
{
    public class CustomerCheckManager :ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
