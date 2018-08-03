using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ExpensiveSubscriptionUnite : ISubcriptionTelephoneUnite
    {
        public string GetDescription()
        {
            return "Expensive subscrition";
        }
        public double GetCost()
        {
            return 500;
        }
    }
}
