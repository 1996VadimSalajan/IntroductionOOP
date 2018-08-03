using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Person:Entity<int>
    {
       public string Name { get; set;}
       public DateTime date { get; set; }
    }
}
