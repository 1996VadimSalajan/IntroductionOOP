using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock p = new Stock();
            p.Attach(new Meat());
            p.Attach(new Milk());
            ImpostVisitor impost = new ImpostVisitor();
            AccountantVisitor accountant = new AccountantVisitor();
            Product product = new Product();
            
            p.Accept(impost);
            p.Accept(accountant);  Console.WriteLine(product.GetType());    
            Console.ReadKey();
        }
    }
}
