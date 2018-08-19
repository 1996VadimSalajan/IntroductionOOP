using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class TariffCalls
    {
       
      public int TariffCode { get; set; }
      public string TypeTariff { get; set; }
      public int Price { get; set; }
      public  ICollection<Calls> Calls { get; set; }
    }
}
