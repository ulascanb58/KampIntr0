using System;
using System.Collections.Generic;
using System.Text;
using GameOdev5.Entity;

namespace GameOdev5.Abstract
{
    public interface ICustomerService
    {
        void Register(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
