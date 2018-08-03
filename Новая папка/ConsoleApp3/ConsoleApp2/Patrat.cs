using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Patrat: Shape, ICalculateArea
    {
     
        public int Latura { get; set; }

        public double CalculateArea()
        {
            return Latura * 4;
        }
    }
}
