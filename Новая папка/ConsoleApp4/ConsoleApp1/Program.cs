using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
          //  Number.metod1(ref a);
           // Console.WriteLine(a);
            Number.metod2(out a);
            Number.metod3(a);
            Console.WriteLine(a);
            Console.ReadKey();
            
        }

        class Number {

            public static void metod1(ref int a)
            {
                a = a + 4;
            }

            public static void metod2(out int a)
            {
                a = 4;
            }
            public static int metod3(int a)
            {
                return a+4;
            }

        }

    }
}
