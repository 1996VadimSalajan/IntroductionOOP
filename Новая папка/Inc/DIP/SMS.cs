using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class SMS : IMessenger
    {
        public void SendMessage()
        {
            Console.WriteLine("Code to send SMS");
        }
    }
}
