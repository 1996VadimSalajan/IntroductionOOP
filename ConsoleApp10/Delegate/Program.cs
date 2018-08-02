using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{ class People
    {
       public delegate bool FilterDelegate(Person a);
       public  static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Vadim", Age = 17 };
            List<Person> people = new List<Person> { p1 };
            DisplayPeople("Childen", people, IsChild);
            Console.ReadKey();
        }
        public static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                    Console.WriteLine("{0}  {1} years", p.Name, p.Age);
            }
        }
        
        public static bool IsChild(this Person p)
        {
            return p.Age < 18;
        }
       public  static bool IsAdult(this Person p)
        {
            return p.Age >= 18;
        }
        public static bool IsSenior(this Person p)
        {
            return p.Age >= 65;
        }

    }
}

