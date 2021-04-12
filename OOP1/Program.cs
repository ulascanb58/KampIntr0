using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2,CategoryId = 5,ProductName = "Kalem",
                UnitsInStock = 5,UnitPrice = 35};


            ProductManager _productManager=new ProductManager();
            _productManager.Add(product1);
            
           _productManager.Update(product2);


            Console.ReadLine();
        }
    }
}
