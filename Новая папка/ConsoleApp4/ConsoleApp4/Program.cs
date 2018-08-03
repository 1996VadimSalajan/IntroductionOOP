using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!");
           
            Book b1 = new Book();
            b1.nameBook1 = "Tom and Jery";
            b1.information = "Book is a story";
            Book b2 =b1;
            b2.nameBook1 = "Main Camp";
            Console.WriteLine(b1.nameBook1);
            Console.WriteLine(b1.information);
            Console.WriteLine(b2.nameBook1);
            Console.WriteLine();

            Country c1 = new Country();
            c1.nameCountry = "Germany";
            c1.information = "Country is in Europe";
            Country c2 = c1;
            c2.nameCountry = "Moldova";
            Console.WriteLine(c1.nameCountry);
            Console.WriteLine(c1.information);
            Console.WriteLine(c2.nameCountry);

            Console.ReadKey();
        }

        struct Book
        {
            public  string nameBook1;
             public string information;
        }

        class Country
        {
            public string nameCountry;
            public string information;
        }
    }
}
