using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Vehicle
    {
        public string marca;
        public int price;
        public int model;
        public string color;
        public int speed;
        public string combustibil;
        public int gearbox;
        public double pricecombustibil;
        protected Vehicle(string vmarca, int vprice, int vmodel, string vcolor, int vspeed, string vcombustibil,int vgearbox,double vpricecombustibil)
        {
            this.marca = vmarca;
            this.price = vprice;
            this.model = vmodel;
            this.color = vcolor;
            this.speed = vspeed;
            this.combustibil = vcombustibil;
            this.gearbox = vgearbox;
            this.pricecombustibil = vpricecombustibil;

        }
        public abstract void DisplayInfo();
        public void AddRaiting()
        {
            Console.WriteLine("Your Raiting:"); int n = int.Parse(Console.ReadLine());
        }
        public virtual void Quanotation()
        {
            Console.WriteLine("Vehicle Quanotation: The road will never be the same. True definition of Luxury.Yours Precision crafted performance");
        }
        public abstract void CalculateCostsCombustibil();       
    }
}
