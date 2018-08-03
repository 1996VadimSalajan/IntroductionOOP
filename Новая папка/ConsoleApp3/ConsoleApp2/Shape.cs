using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Shape
    {
     public void CalculateArea(string shape,int Width,int Length )
      {
           int Aria;
            if (shape == "Rectangle")
            {
                Aria = Length * Width;
                Console.WriteLine(Aria);
            }
            else if (shape == "Square")
            {
                if (Width == Length)
                {
                    Aria = Length * Width;
                    Console.WriteLine(Aria);
                }
                else
                {
                    throw new Exception();
                }
                
            }


           
           
                
        }
    }
}
