using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Theater
    {
        public Ticket Ticket { get; set; }
        public void GetTicket(int number)
        {
            Ticket = Ticket.getInstance(number);
        }
    }
}
