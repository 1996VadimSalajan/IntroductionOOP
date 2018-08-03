using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futures
{
    class Book
    {
        public string NameOld { get; }
        public string AuthorOld { get; }
        public string NameNew { get; }
        public string AuthorNew { get; }
        public string FullNameBookOld
        {
            get { return NameOld + AuthorOld; }
        }
        public string FullNameBook2() => NameNew + AuthorNew;
       
    }
    class HistoryBook : Book { }
}
