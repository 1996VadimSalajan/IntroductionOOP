using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class EconomySubscritionUnite:ISubcriptionTelephoneUnite
    {
        public string GetDescription()
        {
            return "Economy subscrition";
        }
        public double GetCost()
        {
            return 100;
        }
    }
}
