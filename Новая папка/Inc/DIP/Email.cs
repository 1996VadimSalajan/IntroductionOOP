using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Email:IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Code send Email");
        }
    }
}
