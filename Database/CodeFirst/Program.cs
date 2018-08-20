using System;
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
            var user1 = new User
            {   UserId=1,
                FirstName = "Salajan",
                LastName = "Vadim",
                PasswordUser = "afdsfdsfsdfsf",
                Email = "salajan97@mail.ru",
                IDNP = 3123123212232,
                Gender = "m"
            };
            var rep = new Repository<User>();
                user1.Age = 40;
                rep.Update(user1);
             
           
            Console.ReadKey();
        }
    }
}
