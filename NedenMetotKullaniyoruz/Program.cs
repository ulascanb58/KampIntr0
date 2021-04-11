using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace NedenMetotKullaniyoruz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();

           // int x1 = 20;
           // int y1 = 100;
           /*  int x1;
           int y1;
            var result = add3(out x1,out y1);
            Console.WriteLine(result);
            Console.WriteLine(x1);
            */
           //  Add2(999999,999);

          /* Console.WriteLine(Multiply(4,5));

           Console.WriteLine(Multiply(4, 5,9));
*/

          Console.WriteLine(Add4(5,2,4,2,999));
            Console.ReadLine();
        }

        //static void Add()
        //{
        //    Console.WriteLine("Toplandi");
        //}

        static int Add2(int x=1000, int y=1000)
        {
            var c = x + y;
            Console.WriteLine(c); 

            return c;

           
        }

        static int add3(out int number1,out int number2)
        {
           number1 = 30;
           number2 = 100;
           
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

       /* static int Add4(int number1, int number2)
        {
            return number1 + number2;

        }

        static int Add4(int number1, int number2,int number3)
        {
            return number1 + number2 + number3;

        }

    */
       static int Add4(params int[] numbers)
       {
           return numbers.Sum();
       }

      
    }
}
