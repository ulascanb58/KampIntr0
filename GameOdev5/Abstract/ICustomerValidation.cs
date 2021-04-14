using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Entity;

namespace GameOdev5.Abstract
{
    public interface ICustomerValidation
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
