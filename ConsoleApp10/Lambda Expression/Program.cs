using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    public static  class Pers
    {
        public static List<Person> GetAge(this List<Person> res)
        {
            List<Person> emp3 = res.FindAll(
         delegate (Person p)
         {
             return p.Age == 25;
         });
            return emp3;
        }
    }

    public  class People
    {
        static void Main(string[] args)
        {
           
            Console.ReadKey();

        }
        public static void DisplayPeople()
        {
            Person p1 = new Person { Name = "Ion", Age = 12 };
            Person p2 = new Person { Name = "Vadim", Age = 14 };
            Person p3 = new Person { Name = "Constantin", Age = 68 };
            Person p4 = new Person { Name = "Ana", Age = 25 };

            List<Person> people = new List<Person> { p1, p2, p3, p4 };
            var age = people;
            var res1 = people.FindAll(n => n.Age < 18);
            var res2 = people.FindAll(n => n.Age >= 18 && n.Age < 65);
            var res3 = people.FindAll(n => n.Age >= 65);
            if (res1 != null)
            {
                Console.WriteLine("Children");
                for (int i = 0; i < res1.Count(); i++)
                { Console.WriteLine("{0}  {1} years", res1[i].Name, res1[i].Age); }
            }
            if (res2 != null)
            {
                Console.WriteLine("IsAdult");
                for (int i = 0; i < res2.Count(); i++)
                { Console.WriteLine("{0}  {1} years", res2[i].Name, res2[i].Age); }
            }
            if (res3 != null)
            {
                Console.WriteLine("Senior");
                for (int i = 0; i < res3.Count(); i++)
                { Console.WriteLine("{0}  {1} years", res3[i].Name, res3[i].Age); }
            }
            if (age.GetAge() != null)
            {
                Console.WriteLine();
                Console.WriteLine("Age 25");
                for (int i = 0; i < age.GetAge().Count(); i++)
                { Console.WriteLine("{0}  {1} years", age.GetAge()[i].Name, age.GetAge()[i].Age); }
            }
            Console.WriteLine();
            Console.WriteLine("LINQ");
            var a = from p in people
                    where (p.Age > 25)
                    select new { Name = p.Name, Age = p.Age };
            a.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Age));
        }
        public string MakeCreditDecision(int creditScore)
        {
            if (creditScore < 550)
                return "Declined";
            else if (creditScore <= 675)
                return "Maybe";
            else
                return "We look forward to doing business with you!";
        }
    }
}
