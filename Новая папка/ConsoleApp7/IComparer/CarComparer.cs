using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparer
{
    class CarComparer:IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
           
            return x.Speed.CompareTo(y.Speed);
        }
    }
}
