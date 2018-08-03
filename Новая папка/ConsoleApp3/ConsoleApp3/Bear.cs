using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Bear:IEatFruits,IEatMeet
    {
       public  void AddApples()
        {
            Console.WriteLine("I'm Bear and prefer Apple!");
        }
        public void AddFish()
        {
            Console.WriteLine("I'm Bear and prefer Fish!");
        }
    }
}
