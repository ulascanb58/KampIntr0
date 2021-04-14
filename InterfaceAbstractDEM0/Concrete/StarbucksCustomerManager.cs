using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDEM0.Abstract;
using InterfaceAbstractDEM0.Entities;

namespace InterfaceAbstractDEM0.Concrete
{
    class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            throw new Exception("Not a valid person");
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
