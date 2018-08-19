using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
   public  class Subscribes
    {
       

        public int IdSubscribe { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public long IDNP { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public int IdCall { get; set; }
        public  ICollection<Address> Address { get; set; }
      

    }
}
