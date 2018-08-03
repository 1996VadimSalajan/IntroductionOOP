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
            string test = "Buterfly_1111";
            try
            {
                if (test.Length < 10)
                    throw new Exception("Not ten characters!");
                if (test.Contains("_"))
                    throw new Exception("Not allowed character _ !");
                Console.WriteLine(test);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }
}
