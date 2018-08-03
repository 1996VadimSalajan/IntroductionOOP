using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle: ICalculateArea
    {
        public int Radius { get; set; }

        public double Calculate()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
