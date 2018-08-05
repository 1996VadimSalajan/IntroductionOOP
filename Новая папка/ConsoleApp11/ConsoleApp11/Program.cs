using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = Outer();
           Console.WriteLine(add(3));
            Console.WriteLine(add(5));
            Person p1 = new Person { IdPerson = 1, Name = "Salajan", Surname = "Vadim", Age = 17 };
            Person p2 = new Person { IdPerson = 2, Name = "Iovu", Surname = "Adrian", Age = 23 };
            Person p3 = new Person { IdPerson = 4, Name = "Carcea", Surname = "Adriana", Age = 43 };
            Person p4 = new Person { IdPerson = 4, Name = "Cebotari", Surname = "Ana", Age = 33 };

            Library l1 = new Library { IdPerson = 1, NameBook = "History", Date = new DateTime(2018, 3, 4) };
            Library l2 = new Library { IdPerson = 1, NameBook = "Filosofy", Date = new DateTime(2018, 6, 4) };
            Library l3 = new Library { IdPerson = 2, NameBook = "Math", Date = new DateTime(2018, 3, 4) };
            Library l4 = new Library { IdPerson = 3, NameBook = "English Lesson", Date = new DateTime(2018, 6, 4) };

            List<Person> student = new List<Person> {p1,p2,p3,p4};
            List<Library> book = new List<Library> { l1, l2,l3,l4 };
            var query = student.Min(x=>x.Name);
            query.ToList().ForEach(m=>Console.WriteLine(m));
            
            Console.WriteLine("\n Query1:");
            var query1 = from s in student
                         where s.Age > 20 
                         select new { Name = s.Name, Surname = s.Surname, Age = s.Age };
            query1.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age + ""));
            Console.WriteLine();

            Console.WriteLine("\n Query2:");
            var query2 = student.Take(1);
            query2.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));

            Console.WriteLine("\n Query3:");
            var query3 = student.Skip(2);
            query3.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));

            Console.WriteLine("\n Query4:");
            var query4 = student.SkipWhile(x => x.Age < 30);
            query4.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));

            Console.WriteLine("\n Query5:");
            var query5 = student.TakeWhile(x => x.Age < 30);
            query5.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));

            Console.WriteLine("\n Query6:");
            var query6 = student.Distinct().ToList();
            query6.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));

            Console.WriteLine("\n Query7:");
            var query7 = from s in student
                         join n in book on s.IdPerson equals n.IdPerson
                         select new { Name = s.Name, Surname = s.Surname, Age = s.Age, n.NameBook };
            query7.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age + " " + s.NameBook));

            Console.WriteLine("\n Query8:");
            var query8 = student.GroupJoin(book,
                         c => c.IdPerson,
                         d => d.IdPerson,
                         (c, result) => new Result(c.Name, c.Surname, result));
            foreach (var result in query8)
            {
                Console.WriteLine(result.Name + " " + result.Surname);
                foreach (var resultfinal in result.NameBook)
                {
                    Console.WriteLine(resultfinal.NameBook);
                }

            }

            Console.WriteLine("\n Query9:");
            var query9 = student.Zip(book,
                          (s, z) => new
                          {
                              Name = s.Name,
                              NameBook = z.NameBook

                          });
            query9.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.NameBook));
            Console.WriteLine();

            Console.WriteLine("\n Query10:");
            var query10 = from s in student
                          orderby s.Name, s.Surname descending
                          select s;
            query10.ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Surname));

            Console.WriteLine("\n Query11:");

            string[] capitals = { "aSofi", "aParis", "London", "Moscow", "Helsinki" };
            var query111 = capitals.SequenceEqual(capitals);
            Console.WriteLine(query111);
            var query11 = capitals.OrderByDescending(s => s.Length).ThenByDescending(s => s);
            query11.ToList().ForEach(s => Console.WriteLine(s));

            Console.WriteLine("\n Query12:");
            var query12 = capitals.Reverse();
            query12.ToList().ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            Console.WriteLine("\n Query13:");
            var query13 = from n in student
                          group n by n.Age into g
                          select new
                          {
                              Age = g.Key,
                              Name = g.Select(m => m.Name).ToList()
                          };
            foreach (var item in query13)
            {
                Console.WriteLine("Student have " + item.Age + " years");
                foreach (string name in item.Name)
                {
                    Console.WriteLine(name);
                }
            }

            int[] a = { 1, 2, 3, 8 };
            int[] b = { 5, 4, 3, 2, 1 };

            var c1 = (a).Concat(b);
            var c2 = a.Except(b);
            var c3 = a.Intersect(b);

            Console.WriteLine("\n Concatenarea: ");
            c1.ToList().ForEach(s => Console.Write(s));


            Console.WriteLine("\n Except: ");
            c2.ToList().ForEach(s => Console.Write(s));

            Console.WriteLine("\n Intersect: ");
            c3.ToList().ForEach(s => Console.Write(s));
            var c4 = student.First();
            Console.WriteLine("\n");

            Console.WriteLine("\n First Student: ");
            Console.WriteLine(c4.Name + " " + c4.Surname);
            var c5 = student.Last();
            Console.WriteLine("\n");

            Console.WriteLine("\n Last student: ");
            Console.WriteLine(c5.Name + " " + c5.Surname);
            var c6 = student.Count(x => x.Age > 19);
            Console.WriteLine();

            Console.WriteLine("\n Number students: ");
            Console.WriteLine(c6);
            var c7 = a.Sum();
            var c8 = a.Average();
            var c9 = a.Min();
            var c10 = a.Aggregate((s, n) => s * n);
            Console.WriteLine("Sum: " + c7 + " Average: " + c8 + " Min: " + c9 + " Aggregate " + c10);

            var c11 = student.All(s => s.Age == 43);
            Console.WriteLine("\n Exist student who 43 years: " + c11);

            var c12 = Enumerable.Range(2, 9);
            foreach (var item in c12)
                Console.Write(item + "  ");

            Console.WriteLine();
            var c13 = Enumerable.Repeat(p1.Name, 9);
            foreach (var item in c13)
                Console.Write(item + "  ");

            Console.ReadKey();
        }
        public static Func<int, int>Outer()
        {
            int nonLocalVariable = 1;
            Func<int, int> add = delegate (int v)
            {
                nonLocalVariable = nonLocalVariable + v;
                return v + nonLocalVariable;
            };
            return add;
        }
    }
}
