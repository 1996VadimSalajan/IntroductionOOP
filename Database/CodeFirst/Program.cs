using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep1 = new Repository<User>();

            Address address = new Address()
            {
                Village = "Copace",
                City = "Singerei",
                Country = "Moldova",

            };
            List<Address> adress = new List<Address>() { address };
            User user1 = new User()
            {
                FirstName = "Rusu",
                LastName = "Ana",
                PasswordUser = "afdsfdsfsdfsf",
                Email = "rusu98@mail.ru",
                IDNP = 374318292232,
                DateCreated = DateTime.Now,
                BirthDate = new DateTime(1965, 12, 12),
                Age = 52,
                Gender = "f",
                Address = adress,
            };

            Group group = new Group()
            {
                AcademicYear = "163",
                Name = "Logan"
            };
            YearOfStudy year1 = (new YearOfStudy()
            {
                BegginingYear = new DateTime(2018, 09, 09),
                EndYear = new DateTime(2018, 09, 09),
            });

            Student student = (new Student()
            {
                User = user1,
                EntryTime = new DateTime(2018, 09, 09, 20, 09, 09),
                ExitTime = new DateTime(2018, 09, 09, 20, 19, 19),
                Active = "Off",
                Class = "12-A",
                Group = group,
                YearOfStudys = year1,
            });

            rep1.Add(user1);
            /////Query();
            Console.ReadKey();
        }
        //public static void Query()
        //{
        //    using (var dbcontext = new MoodleContext())
        //    {
        //        Console.WriteLine("\n Query1");
        //        var query1 = from user in dbcontext.Users where user.Age < 19 select new { user.FirstName, user.LastName, user.Age };
        //        query1.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query2");
        //        var query2 = dbcontext.Users.Take(10);
        //        query2.ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

        //        Console.WriteLine("\n Query3");
        //        var query3 = dbcontext.Users.ToList().Skip(2);
        //        query3.ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + "   " + x.BirthDate));
        //        Console.WriteLine("\n Query4");

        //        var query4 = dbcontext.Users.ToList().TakeWhile(x => x.Age < 50);
        //        query4.ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " " + x.Age));

        //        Console.WriteLine("\n Query5");
        //        var query5 = from user in dbcontext.Users
        //                     select new
        //                     {
        //                         CountUsers = dbcontext.Users.Count(),
        //                         MinAge = dbcontext.Users.Min(x => x.Age),
        //                         MaxAge = dbcontext.Users.Max(x => x.Age),
        //                         AverrageAge = dbcontext.Users.Average(x => x.Age),
        //                         SumAge = dbcontext.Users.Sum(x => x.Age)
        //                     };
        //        var query5distinct = query5.ToList().Distinct();
        //        query5distinct.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query6");
        //        var query6 = from user in dbcontext.Users
        //                     join address in dbcontext.Adresses on user.Id equals address.UserId
        //                     select new
        //                     {
        //                         user.FirstName,
        //                         user.LastName,
        //                         address.Village,
        //                         address.City,
        //                         address.Country
        //                     };
        //        query6.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query7");
        //        var query7 = dbcontext.Users.GroupJoin(dbcontext.Adresses,
        //            user => user.Id,
        //            address => address.UserId,
        //            (user, address) => new { user.FirstName, user.LastName, Address = address });
        //        foreach (var item1 in query7)
        //        {
        //            Console.WriteLine(item1.FirstName + " " + item1.LastName);
        //            foreach (var item2 in item1.Address)
        //                Console.WriteLine(item2.Village + "  " + item2.City + " " + item2.Country);
        //        }

        //        Console.WriteLine("\n Query8");
        //        var query8 = from user in dbcontext.Users
        //                     orderby user.FirstName, user.LastName descending
        //                     select user;
        //        query8.ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

        //        Console.WriteLine("\n Query9");
        //        var query9 =from user in dbcontext.Users.ToArray().Reverse() select new { user.FirstName, user.LastName };
        //        query9.ToList().ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));

        //        Console.WriteLine("\n Query10");
        //        var query10 = from user in dbcontext.Users
        //                      from student in dbcontext.Students
        //                      from groups in dbcontext.Groups
        //                      from cours in dbcontext.Courses
        //                      where user.Id == student.UserId && student.GroupId == groups.GroupId && groups.GroupId == cours.GroupId
        //                      select new { user.LastName, user.FirstName, cours.NameCourse };
        //        query10.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query11");
        //        var query11 = from user in dbcontext.Users
        //                      from student in dbcontext.Students
        //                      from eventsstudent in dbcontext.EventsStudents
        //                      from events in dbcontext.Events
        //                      where user.Id == student.UserId && student.StudentId == eventsstudent.StudentId
        //                      && eventsstudent.EventId==events.EventId 
        //                      select new { user.FirstName, user.LastName,events.EventName };
        //        query11.ToList().ForEach(x => Console.WriteLine(x));
        //        Console.WriteLine("\n Query12");
        //        var query12 = from user in dbcontext.Users
        //                      from teacher in dbcontext.Teachers
        //                      where user.Id == teacher.TeacherId 
        //                      select new { user.FirstName, user.LastName };
        //        query12.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query13:");
        //        var query13 = from user in dbcontext.Users
        //                      where user.Age<21
        //                      group user by user.Age into g
        //                      where g.Count()==4
        //                      select new
        //                      {
        //                          Age = g.Key,
        //                          Name = g.Select(m => m.FirstName).ToList()
        //                      };
        //        foreach (var item in query13)
        //        {
        //            Console.WriteLine("Student have " + item.Age + " years");
        //            foreach (string name in item.Name)
        //            {
        //                Console.WriteLine(name);
        //            }
        //        }
        //        Console.WriteLine("\n Query14:");
        //        var query14 = from user in dbcontext.Users
        //                      where user.Address.Any(a => a.Country=="USA")
        //                      select new { user.FirstName, user.LastName};
        //        query14.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query15:");
        //        var query15 = from user in dbcontext.Users
        //                      where user.Students.Any(a => a.Class == "12-A")
        //                      select new { user.FirstName, user.LastName };
        //        query15.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query16:");
        //        var query16 = from user in dbcontext.Users
        //                      where user.Age<17 && user.Address.All(a => a.Country == "Moldova")
        //                      select new { user.FirstName, user.LastName };
        //        query16.ToList().ForEach(x => Console.WriteLine(x));

        //        Console.WriteLine("\n Query17:");
        //        var query17 = from user in dbcontext.Users
        //                      where dbcontext.Teachers
        //                      .Where(t => t.Degree == "1")
        //                      .Select(t => t.TeacherId)
        //                      .Contains(user.Id)
        //                      select user;
        //        query17.ToList().ForEach(x => Console.WriteLine(x.FirstName+" "+x.LastName));

        //        Console.WriteLine("\n Query18:");
        //        var query18 = from user in dbcontext.Users
        //                      from address in dbcontext.Adresses.Where(x => x.UserId == user.Id).DefaultIfEmpty()
        //                      select new
        //                      {  Us=user.Id,
        //                         User=user.FirstName,
        //                         Name = user.LastName,
        //                         Address=address.UserId!=null ? "Present Address":"No Address"
        //                      };
        //        query18.ToList().ForEach(x => Console.WriteLine(x));
        //        var query19=(LinqPginationExtension.Page(query10.OrderBy(x=>x.FirstName), 1, 10));
        //        query19.ToList().ForEach(x => Console.WriteLine(x));
        //    }
    
       // }
    }
}
