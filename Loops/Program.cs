using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Java", "C#", "ASP" };

            //for (int i = 0; i <= kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
                
            }

            

            

            Console.Read();
        }
    }
}
