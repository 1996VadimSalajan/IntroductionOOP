using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            d.Bark();
            c.Bark();
            Console.ReadKey();
        }
       

    }
}
