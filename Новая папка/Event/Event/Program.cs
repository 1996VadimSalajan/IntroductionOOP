using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            account.Adeed += ShowMessage;
            account.Withdrawn += ShowMessage;
            account.Withdraw(20);
            account.Withdrawn -= ShowMessage;
            account.Withdraw(20);
            account.Put(1000);
            Console.ReadKey();
        }
        private static void ShowMessage (string message)
        {
            Console.WriteLine(message);
        }
    }
}
