using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Notification
    {
        public void DoNotify (IMessenger pMessenger)
        {
            pMessenger.SendMessage();
        }
    }
}
