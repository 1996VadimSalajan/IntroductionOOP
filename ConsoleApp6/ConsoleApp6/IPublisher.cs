using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    interface IPublisher<T>
    {
        event EventHandler<MessageArgument<T>> DataPublisher;
        void OnDataPublisher(MessageArgument<T> args);
        void PublishData(T data);
    }
}
