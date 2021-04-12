using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Id'si : "+product.Id);
            Console.WriteLine("Kategori Numarası : "+product.CategoryId);
            Console.WriteLine("Ürün Adı : "+product.ProductName);
            Console.WriteLine("Ürün Fiyatı : "+product.UnitPrice);
            Console.WriteLine("Stok Adedi : "+product.UnitsInStock);
            Console.WriteLine("BAŞARIYLA EKLENMİŞTİR !");
            Console.WriteLine("-------------------------");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Id+"ID'li kayıt güncellenmiştir");
        }

       

       
    }
}
