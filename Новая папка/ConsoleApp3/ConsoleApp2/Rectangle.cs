using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle : ICalculateArea
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
