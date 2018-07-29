using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class OvenBaking:CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }
}
