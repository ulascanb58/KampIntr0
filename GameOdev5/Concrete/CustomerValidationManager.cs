using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Abstract;
using GameOdev5.Entity;

namespace GameOdev5.Concrete
{
   class CustomerValidationManager:ICustomerValidation
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
