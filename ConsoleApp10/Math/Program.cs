using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
namespace Math
{
    public static class TestClass
    {
        public static int IntegerExtension(this string s)
        {
            return int.Parse(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123456789";
            int number = str.IntegerExtension();
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
