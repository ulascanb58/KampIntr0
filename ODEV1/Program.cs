using System;

namespace ODEV1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            NProduct _nProductproduct = new NProduct();
            _nProductproduct.ProductName = "Elma";
            _nProductproduct.ProductCount = 30;
            _nProductproduct.ProductPrice = 0.5;

            NProduct _nProductproduct2 = new NProduct();
            _nProductproduct2.ProductName = "Elma2";
            _nProductproduct2.ProductCount = 30;
            _nProductproduct2.ProductPrice = 0.5;

            NProduct[] urunler = new NProduct[]{_nProductproduct,_nProductproduct2};

            //foreach (var items in urunler)

            //{
            //    Console.WriteLine(items.ProductName);
            //    Console.WriteLine(items.ProductCount);
            //    Console.WriteLine(items.ProductPrice);
            //}

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ProductName);
                Console.WriteLine(urunler[i].ProductCount);
                Console.WriteLine(urunler[i].ProductPrice);

            }

            Console.ReadLine();
        }

       

        class NProduct
        {
            public string ProductName { get; set; }
            public int ProductCount { get; set; }
            public double ProductPrice { get; set; }
        }
    }

}
