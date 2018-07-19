using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Car:Vehicle
    {
        private object seating_pasagers;
        public Car(string vname, int vprice, int vmodel, int pasagers) : base(vname, vprice, vmodel)
        {
            seating_pasagers = pasagers;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the car is:" + name);
            Console.WriteLine("The price of the car is:" + price);
            Console.WriteLine("The model of the car is:" + model);
            Console.WriteLine("Number pasagers in the car is:" + seating_pasagers+"passagers");
        }
    }
}
