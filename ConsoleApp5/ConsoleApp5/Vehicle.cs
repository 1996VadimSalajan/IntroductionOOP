using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Vehicle
    {
        public string name;
        public int price;
        public int model;
        protected Vehicle(string vname, int vprice, int vmodel)
        {
            vname = name;
            vprice = price;
            vmodel = model;
        }
        public abstract void DisplayInfo();
        
       
    }
}
