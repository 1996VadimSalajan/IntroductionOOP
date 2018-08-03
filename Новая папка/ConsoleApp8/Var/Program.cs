using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var p = new { FirstName = "Rafael", Age = 25 };
            Console.WriteLine(p.FirstName);
            Console.ReadKey();
        }
    
    }
}
