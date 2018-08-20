using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
   public  class Address
    {
        public int AddressId { get; set; }
        public string Village { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
