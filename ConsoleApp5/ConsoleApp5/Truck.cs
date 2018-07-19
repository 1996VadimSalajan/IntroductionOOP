using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Truck:Vehicle
    {
        private int load_capacity;
        public Truck(string vname, int vprice, int vmodel, int load) : base(vname, vprice, vmodel)
        {
            load_capacity = load;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the Truck is:" + name);
            Console.WriteLine("The price of the Truck is:" + price);
            Console.WriteLine("The model of the Truck is:" + model);
            Console.WriteLine("The load capacity of Truck is:" + load_capacity + " tons.");
        }
    }
}
