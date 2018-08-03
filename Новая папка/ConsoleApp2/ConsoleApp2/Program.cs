using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
       public static int Main(string[] args)
        {
            Department d = new Department();
            d.Departname = "Communication";
            Console.WriteLine("The Department is :{0}", d.Departname);
Console.ReadKey();
            return 0;

            
        }
    }
}
