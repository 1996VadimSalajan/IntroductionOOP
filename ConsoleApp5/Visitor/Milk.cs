using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Milk:Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.MilkConcrete(this);
        }
    }
}
