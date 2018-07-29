using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Meat:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.MeatConcrete(this);
        }
    }
}
