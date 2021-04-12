using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
           MyList<string> isimler = new MyList<string>{};
           isimler.Add("Engin");
           isimler.Add("Hasan");

           foreach (var isim in isimler.Items )
           {
               Console.WriteLine(isim);

           }

           Console.ReadLine();
        }
    }
}
