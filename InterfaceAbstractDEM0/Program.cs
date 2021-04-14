using System;
using InterfaceAbstractDEM0.Abstract;
using InterfaceAbstractDEM0.Concrete;
using InterfaceAbstractDEM0.Entities;

namespace InterfaceAbstractDEM0
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager _customerManager = new NeroCustomerManager();
            Customer musteri1= new Customer();
            musteri1.ID = 1;
            musteri1.FirstName = "Ulaş";
            musteri1.LastName = "Bozkurt";
            musteri1.DateOfBirth=new DateTime(1997);
            musteri1.NationalityId = "42370943515";

            _customerManager.Save(musteri1);
            Console.ReadLine();

        }
    }
}
