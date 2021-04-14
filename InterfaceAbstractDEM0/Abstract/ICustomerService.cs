using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDEM0.Entities;

namespace InterfaceAbstractDEM0.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
