using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Publisher<T>:IPublisher<T>
    {
        public event EventHandler<MessageArgument<T>> DataPublisher;
        public void OnDataPublisher(MessageArgument<T> args)
        {
            DataPublisher?.Invoke(this, args);
        }
        public void PublishData(T data)
        {
            MessageArgument<T> message = (MessageArgument<T>)Activator.CreateInstance(typeof(MessageArgument<T>), new object[] { data });
            OnDataPublisher(message);
        }
    }
}
