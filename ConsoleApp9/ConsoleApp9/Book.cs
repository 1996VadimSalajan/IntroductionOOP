using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
  
    class Book:Entity<int>
    {   
        public string Name { get; set; }
        public string Type { get; set; }
        
    }
   
}
