using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ImpostVisitor:Visitor
    {   Product product =new Product();
        public override void MeatConcrete(Meat meat)
        {     
            product.CurentImpostprice= 29.10;
            product.NewImpostprice = product.CurentImpostprice * 1.20;
            Console.WriteLine("{0} {1}'s new impost price: {2:C}",
            product.GetType().Name, product.Name="Grendell",
            product.NewImpostprice);
        }

        public override void MilkConcrete(Milk milk)
        {
            product.CurentImpostprice = 9.10;
            product.NewImpostprice = product.CurentImpostprice * 1.10;
            Console.WriteLine("{0} {1}'s new impost price: {2:C}",
            product.GetType().Name, product.Name = "Dana",
            product.NewImpostprice);
        }
    }
}
