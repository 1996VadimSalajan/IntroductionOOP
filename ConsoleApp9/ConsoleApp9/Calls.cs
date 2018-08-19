using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Calls
    {
       public int IdCall {get;set;}
       public string DestinationCall { get; set; }
       public string TimeCall { get; set; }
       public int TariffCode { get; set; }
       public Subscribes Subscribes { get; set; }
       public TariffCalls TariffCalls { get; set; }
    }
}
