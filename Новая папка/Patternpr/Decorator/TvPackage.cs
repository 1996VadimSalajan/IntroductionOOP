using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TvPackage : PackagesDecorator
    {
        public TvPackage(ISubcriptionTelephoneUnite subcription) : base(subcription) { }
        public override string GetDescription()
        {
            return base.GetDescription() + ",TV Package";

        }
        public override double GetCost()
        {
            return base.GetCost() + 240.0;
        }

    }
}
