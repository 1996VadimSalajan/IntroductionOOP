using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Futures
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name,_, address) = Discard("Vadim",24, "Viena");
            HistoryBook h1 = new HistoryBook();
            Book b1 = h1;

            Book b2 = new HistoryBook();
            h1=(HistoryBook)b2;

            Book b3 = new Book();
            HistoryBook h2 = b3 as HistoryBook;

            var b = name ?? "Default";
            Console.WriteLine(b);

            dynamic dynamicVariable = 100;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = "Hello World!!";
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = true;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());

            dynamicVariable = DateTime.Now;
            Console.WriteLine("Dynamic variable value: {0}, Type: {1}", dynamicVariable, dynamicVariable.GetType().ToString());
            Console.ReadKey();
        }


        public static void GetBook()
        {
            Book NAME = new Book();
            if (NAME == null)
                Console.WriteLine(nameof(NAME) + " is null");
        }
        public static void Calculate()
        {
            double Result, Value1 = 23, Value2 = 34;
            Result = Sqrt(Value1) + Sqrt(Value2);
        }
        public static void Dictionary()
        {
            var booksold = new Dictionary<string, string>()
            {
                { "Doctor House" ,"Hiu Lori" },
            };
            var booksnew = new Dictionary<string, string>()
            {
                ["Doctor House"] = "Hiu Lori",
            };
        }
        public static void Catch()
        {
            int l = 0;
            try
            {
                throw new ArgumentNullException(nameof(l));
            }
            catch (ArgumentNullException e)
            when (e.Me)
            {
                Console.WriteLine("Caught Argument Null Exception");
            } 
        }
        public static void Interpolation()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int val1 = 1;
            decimal val2 = 12;
            decimal val3 = 1234.12m;
            Console.WriteLine($"Number 1 {val1:C}");
            Console.WriteLine($"Number 2 {val2:C}");
            Console.WriteLine($"Number 3 {val3:c}");
        }
        public static void Number(out int result)
        {
            result = 56;
        }
        public (string,int,char) Tuples()
        {
            return ("First",1,'b');
        }
        public static (string,int,string) Discard(int age, string name = "Vadim",  string address = "Chisinau")
        {         
            void DisplayText()
            {
                Console.WriteLine("Information: ");
            }
            DisplayText();
                return (name, age, address);
          
        }
    }
}
