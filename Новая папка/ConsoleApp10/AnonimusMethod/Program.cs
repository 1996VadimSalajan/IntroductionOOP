using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimusMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Ion", Age = 12 };
            Person p2 = new Person { Name = "Vadim", Age = 18 };
            Person p3 = new Person { Name = "Constantin", Age = 68 };
            List<Person> people = new List<Person> { p1,p2,p3 };
            Person emp1 = people.Find(
            delegate (Person p)
            {
                return p.Age < 18;
            });
            Person emp2 = people.Find(
            delegate (Person p)
            {
                return p.Age >= 18;
            });
            Person emp3 = people.Find(
            delegate (Person p)
            {
              return p.Age >= 65;
            });
            if (emp1!=null)
            {
                Console.WriteLine("Children");
                Console.WriteLine("{0}  {1} years", emp1.Name, emp1.Age);
            }
            if (emp2 != null)
            {
                Console.WriteLine("IsAdult");
                Console.WriteLine("{0}  {1} years", emp2.Name, emp2.Age);
            }
            if (emp2 != null)
            {
                Console.WriteLine("Senior");
                Console.WriteLine("{0}  {1} years", emp3.Name, emp3.Age);
            }
            Console.ReadKey();
        }
        
    }

}
