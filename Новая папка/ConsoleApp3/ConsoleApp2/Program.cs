using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape r = new Shape();
            r.CalculateArea("Triangle", 2, 3);
            Console.ReadKey();
        }
    }
}
