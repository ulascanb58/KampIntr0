using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDEM0.Entities;

namespace InterfaceAbstractDEM0.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
