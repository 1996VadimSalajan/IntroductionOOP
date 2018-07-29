using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class AccountantVisitor:Visitor
    {
        Product product = new Product();
        public override void MeatConcrete(Meat meat)
        {
            product.CurentAccountantprice = 69.10;
            product.NewAccountantprice = product.CurentAccountantprice * 1.30;
            Console.WriteLine("{0} {1}'s new accoutant price: {2:C}",
            product.GetType().Name, product.Name = "Greendell",
            product.NewAccountantprice);
        }

        public override void MilkConcrete(Milk milk)
        {
            product.CurentAccountantprice = 19.40;
            product.NewAccountantprice = product.CurentAccountantprice * 1.20;
            Console.WriteLine("{0} {1}'s new accoutant price: {2:C}",
            product.GetType().Name, product.Name = "Dana",
            product.NewAccountantprice);
        }
    }
}
