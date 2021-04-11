using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NCustomer musteri1=new NCustomer();

            musteri1.CustomerId = 1;
            musteri1.CustomerName = "Ulaş";
            musteri1.CustomerSurname = "Bozkurt";

            NCustomer musteri2 = new NCustomer();

            musteri2.CustomerId = 2;
            musteri2.CustomerName = "Nihat";
            musteri2.CustomerSurname = "Bozkurt";



            CustomerManager _customerManager = new CustomerManager();
           NCustomer[] musteriler = new NCustomer[]{musteri1,musteri2};

           foreach (var items in musteriler)
           {    
               _customerManager.AddCustomer(items);
           }

           _customerManager.DeleteCustomer(musteri2);
            
            
            Console.ReadLine();


        }
    }
}
