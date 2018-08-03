using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubcriptionTelephoneUnite obj = new EconomySubscritionUnite();
            var decorator = new TvPackage(obj);
            var decorator1 = new InternetPackage(decorator);
           decorator1.GetCost();
            //Console.WriteLine(decorator.GetDescription());
            //Console.WriteLine(decorator.GetCost());
            Console.ReadKey();
        }
    }
}
