using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Manage
    {
        
        Bear b = new Bear();
        Penguin p = new Penguin();
       
        public void manage()
        {
            b.AddFish();
            b.AddApples();
            p.AddFish();
        }
        
    }
}
