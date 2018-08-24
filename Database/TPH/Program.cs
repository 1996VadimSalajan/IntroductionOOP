using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPH
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.HireDate = new DateTime(2018, 01,01);
            t1.Degree = "Superior";
            Student st1 = new Student();
            st1.EnrollmentDate = new DateTime(2018, 01, 10);

            using(var db=new TPHMappingContext())
            {
                db.people.Add(t1);
                db.people.Add(st1);
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
