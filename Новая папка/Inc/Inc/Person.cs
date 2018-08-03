using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Person : IPerson
    {
       
        string NamePerson { get; set; }
        string AgePerson { get; set; }
        string Address { get; set; }
        public Person()
        {
           
    }
}
