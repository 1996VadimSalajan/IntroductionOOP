using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobile samsung = FactoryClass.CreateMobileObject(MobileType.Samsung);
            Console.WriteLine(samsung.ModelName());
            Console.ReadKey();
        }
        public enum MobileType
        {
            Samsung,
            Xiaomi,
            Apple
        }
    }
}
