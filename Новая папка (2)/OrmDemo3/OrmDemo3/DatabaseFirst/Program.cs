using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Joan",
                LastName = "Doe",
                DOB = DateTime.Now
            };

            var address = new Address
            {
                PostCode = "NG2 6AJ",
                Street = "Fox Road"
            };

            using (var dbContext = new CodeFirstEntities())
            {
                dbContext.People.Add(person);
                dbContext.SaveChanges();
                Console.WriteLine($"person saved with Id {person.PersonId}");
                address.PostCode = "NG2 3EE";


                person.Addresses.Add(address);
                dbContext.SaveChanges();

                address.PostCode = "NG2 3AA";
                dbContext.SaveChanges();
                


            }

            Console.ReadLine();
        }
    }
}
