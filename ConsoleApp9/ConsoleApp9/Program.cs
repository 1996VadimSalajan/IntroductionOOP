using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        { DateTime data = new DateTime(2000, 02, 01);
            var subscribe1 = new Subscribes
            {
             
                FirstName = "Cebotari",
                Lastname = "Ion",
                IDNP = 32123212321232,
                BirthDate = data,
                Age = 18,
                IdCall=440           
            };
             using(var dbcontext=new SuscribesContext())
            {
                dbcontext.Subscribes.Add(subscribe1);
                dbcontext.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
