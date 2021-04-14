using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.DateOfBirth = new DateTime(1985,1,6);
            customer.NationalityId = "11111111111";
            baseCustomerManager.Save(customer);

        }
    }
}
