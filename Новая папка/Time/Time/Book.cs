using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Book : IDisposable
    {
        List<string> theList = new List<string>();
        Dictionary<string, string> theDict = new Dictionary<string, string>();
        public void Dispose()
        {
            theList.Clear();
            theDict.Clear();

        }
    }
}
