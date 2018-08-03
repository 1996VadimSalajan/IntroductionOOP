using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class InternetPackage:PackagesDecorator
    {
        public InternetPackage(ISubcriptionTelephoneUnite subcription) : base(subcription) { }
        public override string GetDescription()
        {
            return base.GetDescription() + ",Internet Package";

        }
        public override double GetCost()
        {
            return base.GetCost() + 200.0;
        }
    }
}
