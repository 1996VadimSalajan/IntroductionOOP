using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Subscriber<T>
    {
        public IPublisher<T> Publisher { get; private set; }
        public Subscriber(IPublisher<T> publisher)
        {
            Publisher = publisher;
        }
    }
}
