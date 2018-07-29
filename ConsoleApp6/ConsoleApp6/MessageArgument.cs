using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
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
