using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
      static  int[] array = new int[3];

        static void Main(string[] args)
        {
            try
            {
                 array[7] = 3; 
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Array index is out of bounds!");
            }
            finally
            {
                Console.WriteLine("The array is of size " + array.Length);
            }

            try
            {
                TryCatcher.ThrowsMethod(3);
            }
            catch (Exception)
            {
                Console.WriteLine("main catch");
            }
            Console.ReadKey();
        }
    }
}
