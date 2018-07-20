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
        private readonly bool chiber_security;//characteristic for car
        public Car(string vmarca, int vprice, int vmodel,string vcolor,int vspeed,string vcombustibil,int vgearbox,double vpricecombustibil,bool chibersecurity, int pasagers) : base(vmarca, vprice, vmodel,vcolor,vspeed,vcombustibil,vgearbox,vpricecombustibil)
        {
            seating_pasagers = pasagers;
            chiber_security = chibersecurity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\nThe name of the car is:" + marca);
            Console.WriteLine("The price of the car is:" + price);
            Console.WriteLine("The model of the car is:" + model);
            Console.WriteLine("The color of the car is:" + color);
            Console.WriteLine("The speed of the car is:" + speed);
            Console.WriteLine("The combustibil of the car is:" + combustibil);
            Console.WriteLine("The gearbox of the car is:" + gearbox+" l");
            Console.WriteLine("The price combustibil in this country of the car is:" +pricecombustibil);
            Console.WriteLine("Number pasagers in the car is:" + seating_pasagers+" passagers");
        }
        public override void CalculateCostsCombustibil()
        {
            double resultcost = gearbox *pricecombustibil ;
            Console.WriteLine("Costs a combustibil at 100 km is:"+resultcost);
        }
        public override void Quanotation() 
        {
            Console.WriteLine("Car Quanotation: Never FollowKeeping ahead through technologyEveryone dreams Vorsprung durch Technik.");
        }
        public void Security()
        {
            if (chiber_security == true) Console.WriteLine("Persist Chibersecurity.");
        }
    }
}
