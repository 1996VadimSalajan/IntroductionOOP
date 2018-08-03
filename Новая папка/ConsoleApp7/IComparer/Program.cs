using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
            { new Car()
              {
                Speed=232
              },
              new Car()
              {
                  Speed=345
              },
              new Car()
              {
                  Speed=123
              },
              new Car()
              {
                  Speed=100
              }
            };
            Array.Sort(cars);
            Array.ForEach(cars, x => Console.WriteLine(x.Speed));
            Console.ReadKey();

            var v1 = new Car();
            var v2 = new Car();

            v1.CompareTo(v2);
        }       
     }
   
}
