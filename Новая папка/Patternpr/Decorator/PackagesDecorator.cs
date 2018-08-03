using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   abstract class PackagesDecorator:ISubcriptionTelephoneUnite
    {
        private ISubcriptionTelephoneUnite _iSubscription;
      public  PackagesDecorator(ISubcriptionTelephoneUnite subcription)
        {
            this._iSubscription = subcription;
        }
        public virtual string GetDescription()
        {
            return this._iSubscription.GetDescription();
        }
        public virtual double GetCost()
        {
            return this._iSubscription.GetCost();
        }
    }
}
