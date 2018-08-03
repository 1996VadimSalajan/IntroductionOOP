using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MiddleSubscriptionUnite:ISubcriptionTelephoneUnite
    {
        public string GetDescription()
        {
            return "Middle subscrition";
        }
        public double GetCost()
        {
            return 200;
        }
    }
}
