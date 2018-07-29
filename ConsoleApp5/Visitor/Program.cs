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
            p.Accept(impost);
            p.Accept(accountant);      
            Console.ReadKey();
        }
    }
}
