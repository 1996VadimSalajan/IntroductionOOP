using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0,j=0,n=0;
            int[] number ={412,3434,2323,3434,3,3,41,3,410,78 };
             Console.Write("Numere Impare: ");
            for (  i = 0; i<number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    number[j] = number[i];
                    j +=1;
                    n=j;
                }
            }
            Array.Resize(ref number, number.Length - n);
            for (i = 0; i <n; i++)
            {
                    Console.Write(number[i] + " ");
            }
            Console.WriteLine();
           
                    Console.ReadKey();
        }
    }
}
