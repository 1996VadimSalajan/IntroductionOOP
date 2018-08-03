using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test();
            Console.ReadKey();
        }


      class Test
        {
            static Test()
            {
                Console.WriteLine("Constructor static");
            }
            public  Test()
            {
              
                Console.WriteLine("Constructor non-static");
            }
        }
      
    }
}
