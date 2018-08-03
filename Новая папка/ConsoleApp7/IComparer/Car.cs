using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparer
{
    class Car : IComparable
    {
        public int Speed
        {
            get;
            set;

        }
        public int CompareTo(object obj)
        {
            if(!(obj is Car))
            {
                throw new ArgumentException("Compared object not is Car.");
            }
            Car car = obj as Car;
            return Speed.CompareTo(car.Speed);
        }
    }
}
