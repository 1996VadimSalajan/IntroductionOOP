using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
       public abstract void Bark();
        public abstract void Eat();
    }
    
    interface IBarkableAnimals
    {
        void Bark();
    }
    
}
