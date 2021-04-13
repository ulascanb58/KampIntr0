using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> musteri1 = new MyDictionary<int, string>();
            musteri1.Add(123, "Engin");

            Console.WriteLine(musteri1.Count);
            Console.Read();
        }
    }
}
