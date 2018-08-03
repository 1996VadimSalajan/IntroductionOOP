using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRICE
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int i = 0, j = 0, n = 0;
            int[] a = new int[2];
            int[,] matrice1 = new int[5, 5];
            Console.Write("Numarul de linii: ");
            int numlinii = int.Parse(Console.ReadLine());
            Console.Write("Numarul de coloane: ");
            int numcoloane = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 0; i < numlinii; i++)
                for (j = 0; j < numcoloane; j++)
                {
                    Console.Write("Matrice1[" + i + "][" + j + "]=");
                    matrice1[i, j] = int.Parse(Console.ReadLine());
                }
           int  minimum = matrice1[0,0];

            for (i = 0; i < numlinii; i++)
            {
                for (j = 0; j < numcoloane; j++)
                {
                    if (matrice1[i, j] < minimum)
                    {
                        minimum = matrice1[i, j];
                    }
                }
            }
            for (i = 0; i < numlinii; i++)
            {
                for (j = 0; j < numcoloane; j++)
                {
                    if (matrice1[i, j]== minimum)
                    {
                        a[n] = i;
                        n=1;
                    }
                }
            }
            int linienoua = a[0]+1;
            for (i = numlinii; i >= linienoua; i--)
            
                for (j = 0; j < numcoloane; j++)
                {
                    matrice1[i,j] = matrice1[i-1, j];
                }
            
            Console.WriteLine("Noua linie: ");

            for (i=linienoua; i < linienoua+1; i++)
            {
                for (j = 0; j < numcoloane; j++)
                {
                    Console.Write("Matrice1[" + i + "][" + j + "]=");
                    matrice1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i <=numlinii; i++)
            {
                for (j = 0; j < numcoloane; j++)
                {
                    Console.Write(matrice1[i,j]+" ");
                }
                Console.WriteLine();
            }
             Console.ReadKey();
        }
    }
}
