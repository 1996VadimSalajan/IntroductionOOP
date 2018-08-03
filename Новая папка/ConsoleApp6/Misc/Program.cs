using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            Console.Write("Baza:  ");
            int baze = int.Parse(Console.ReadLine());
            Console.Write("Exponent: ");
            int ex = int.Parse(Console.ReadLine());
            Console.WriteLine("Rezultatul: "+Power(baze,ex));
            Console.ReadKey();
        }
        static int Power(int baze, int exponent)
        {
            if (exponent <= 0)
                return 1;
            else return baze * Power(baze, exponent - 1);
        }
    }
}
