using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Address
    { 
        public int IdAddress { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int IdSubscribe { get; set; }
        public Subscribes Subscribes { get; set; }
    }
}
