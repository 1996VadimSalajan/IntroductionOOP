using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  

    class Ticket
    {
        private static Ticket instance;

        public int Number { get; private set; }
        private static object locobj = new Object();

        protected Ticket(int number)
        {
            Number = number;
        }

        public static Ticket getInstance(int number)
        {
            if (instance == null)
            {
                lock (locobj)
                {
                    if (instance == null)
                        instance = new Ticket(number);
                }
            }
            return instance;
        }
    }
}
