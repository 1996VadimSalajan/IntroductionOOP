using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 750000, 2010, 5);
            Truck Truck = new Truck("Ford", 4200000, 2005, 300);
            car.DisplayInfo();
            Truck.DisplayInfo();
            Console.ReadKey();
        }
    }
}
