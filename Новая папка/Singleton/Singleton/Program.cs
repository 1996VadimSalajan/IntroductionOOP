using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            OS os = new OS();

            Computer comp = new Computer();
            comp.LaunchOS("Windows 8.1");
           // Console.WriteLine(comp.OS.Name);  
            //comp.OS = OS.getInstance("Windows 10");
            //Console.WriteLine(comp.OS.Name);
            Theater t1 = new Theater();
            t1.GetTicket(1);
            Console.WriteLine(t1.Ticket.Number);
            t1.Ticket =Ticket.getInstance(12);
            Console.WriteLine(t1.Ticket.Number);
            Console.ReadKey();
        }
      
    }
}
