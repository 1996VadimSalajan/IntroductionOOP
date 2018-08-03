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
            Car car = new Car("Toyota", 750000, 2010,"Green",340,"Gas",9,18.34,true,6);
            Truck Truck = new Truck("Ford", 4200000, 2005, "Black", 180, "Petrol",16,16.9,true,60);
            car.DisplayInfo();
            car.CalculateCostsCombustibil();
            car.Security();
            car.Quanotation();
            Truck.DisplayInfo();
            Truck.CalculateCostsCombustibil();
            Console.ReadKey();
        }
    }
}
