using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            char character1 = 'a', character2 = 'b';
            ArrayGeneric<char> array = new ArrayGeneric<char>(26);
            array.Swap1(ref character1, ref character2);
            for (i = 1; i < 26; i++)
            {
                array.SetItem(i, (char)(i + 96));
                array.SetItem(1, character1);
                array.SetItem(2, character2);
            }

            for (i = 1; i < 26; i++)
            {
                Console.Write(array.GetItem(i) + "  ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
