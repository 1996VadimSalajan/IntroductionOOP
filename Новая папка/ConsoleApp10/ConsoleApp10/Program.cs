using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        public delegate bool FilterDelegate(Person a);
        static void Main(string[] args)
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

        static bool IsChild(this Person p)
        {
            return p.Age < 18;
        }
        static bool IsAdult(this Person p)
        {
            return p.Age >= 18;
        }
        static bool IsSenior(this Person p)
        {
            return p.Age >= 65;
        }


    }
}
