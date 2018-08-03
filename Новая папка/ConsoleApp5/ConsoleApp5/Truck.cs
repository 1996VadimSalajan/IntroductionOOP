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
        private bool truck_bathroom; // characteristic for Truck
        public Truck(string vmarca, int vprice, int vmodel, string vcolor, int vspeed, string vcombustibil,int vgearbox,double pricecombustibil,bool bathroom, int load) : base(vmarca, vprice, vmodel, vcolor, vspeed, vcombustibil,vgearbox,pricecombustibil)
        {
            load_capacity = load;
            truck_bathroom = bathroom;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the Truck is:" + marca);
            Console.WriteLine("The price of the Truck is:" + price);
            Console.WriteLine("The model of the Truck is:" + model);
            Console.WriteLine("The color of the Truck is:" + color);
            Console.WriteLine("The speed of the Truck is:" + speed);
            Console.WriteLine("The bathroom of the Truck is:" + truck_bathroom);
            Console.WriteLine("The combustibil of the Truck is:" + combustibil);
            Console.WriteLine("The gearbox of the Truck is:" + gearbox+" l");
            Console.WriteLine("The price combustibil in this country of the Truck is:" + pricecombustibil);
            Console.WriteLine("The load capacity of Truck is:" + load_capacity + " tons.");
        }
        public override void CalculateCostsCombustibil()
        {
            double resultcost = gearbox * pricecombustibil;
            Console.WriteLine("Costs a combustibil at 100 km is:" + resultcost);
        }
    }
}
