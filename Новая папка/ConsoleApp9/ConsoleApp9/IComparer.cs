using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    interface IComparer<T>
    {
        int Compare(T x, T y);
    }
}
