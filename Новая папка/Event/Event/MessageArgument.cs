using System;

namespace Event
{
     class MessageArgument<T>:EventArgs
    {
        public T Message { get; set; }
        public MessageArgument(T message)
        {
            Message = message;
        }
    }
}