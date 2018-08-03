using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Penguin : IEatMeet
    {
        public void AddFish()
        {
            Console.WriteLine("I'm Penguin and prefer Fish!");
        }
    }
}
