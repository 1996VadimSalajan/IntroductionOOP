using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Companies
    {
        public int CompanyCode {get;set;}
        public string NameCompany { get; set; }
        public int IdSubscribe { get; set; }
        public Subscribes Subscribes { get; set; }
    }
}
