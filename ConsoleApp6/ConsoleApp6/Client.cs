using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Client
    {
        private readonly IPublisher<int> IntPublisher;
        private readonly Subscriber<int> IntSublisher1;
        private readonly Subscriber<int> IntSublisher2;

        public Client()
        {
            IntPublisher = new Publisher<int>();  

            IntSublisher1 = new Subscriber<int>(IntPublisher);
            IntSublisher1.Publisher.DataPublisher += publisher_DataPublisher1; 
            WeakEventManager<Publisher,EventArgs>.AddHandler(IntPublisher, "Event", MyHandler);
            IntSublisher2 = new Subscriber<int>(IntPublisher);
            IntSublisher2.Publisher.DataPublisher += publisher_DataPublisher2;  

            IntPublisher.PublishData(10); 
        }

        void publisher_DataPublisher1(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("Subscriber 1 : " + e.Message);
        }

        void publisher_DataPublisher2(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("Subscriber 2 : " + e.Message);
        }
    }
}
