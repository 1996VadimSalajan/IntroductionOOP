using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class TryCatcher
    {

        public static void ThrowsMethod(int value)
        {
           try
            {
                if (value == 2)
                {
                    throw new Exception("value is two");
                }
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                Console.WriteLine("finally block");
            }
            Console.WriteLine("after finally block");
        }
    }
}
