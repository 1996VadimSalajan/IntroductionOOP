using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,10);
            object box = p1;
            p1.x = 20;
            Console.Write(p1.x);
            Console.WriteLine();
            //box = 23;
            Point p2 = (Point)box;
            Console.WriteLine(p2.x);

            Console.ReadKey();
        }
      public  class Point
        {
            public int x, y;
            public Point(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
