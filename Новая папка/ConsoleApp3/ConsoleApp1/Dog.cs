using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
        public class Dog : Animal, IBarkableAnimals
        {
            public override void Bark()
            {
            Console.WriteLine("Dog HAM-HAM");
            }

            public override void Eat()
            {

            }
        }
    
}
