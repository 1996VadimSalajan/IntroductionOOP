using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
       

        static void Main(string[] args)
        {
            User a=new User("User1");
            Company c1 = new Company("BMV","X5",8999);
           
            c1.Attach(new User("User1"));
            c1.Attach(new User("User2"));  
            c1.Attach(new User("User3"));
           
            c1.Notify();
            Console.ReadKey();
        }
    }
}
