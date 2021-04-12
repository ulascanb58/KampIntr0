using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            MyList<string>sehirler2 = new MyList<string>();

            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);

            Console.ReadLine();


        }
    }

    class MyList<T> // Generic class
    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array = new T[0];
        }

        public void Add(T items)
        {
            
            tempArray = array;
            array = new T[array.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];

            }

            array[array.Length - 1] = items;
        }

        

        public int Count
        {
            get { return array.Length; }
        }

    }
}
