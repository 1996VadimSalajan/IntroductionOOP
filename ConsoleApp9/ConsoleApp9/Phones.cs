using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Phones
    {
       
        public int IdPphone { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<SubscribePhones> SubscribePhones { get; set; }
    }
}
