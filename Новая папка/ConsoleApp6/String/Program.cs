using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "Univer(Utm):grupa[TI-152],anul-3substr";
            int start1 = words.IndexOf("(");
            int final1 = words.IndexOf(")")-")".Length;
            string words1= words.Remove(start1+1, final1-start1);
            Console.WriteLine(words1);

            int start2 = words.IndexOf("[");
            int final2 = words.IndexOf("]") - "]".Length;
            string words2 = words.Remove(start2 + 1, final2 - start2);
            Console.WriteLine(words2);

            int final3 = words.IndexOf(":") - ":".Length+1;
            string words3 = words.Remove(0, final3 - 0);
            Console.WriteLine(words3);

            int start4 = words.IndexOf(":")+1;
            int final4 = words.Length;
            string words4 = words.Remove(start4,final4-start4);
            Console.WriteLine(words4);


            string str = "this is a #string";
            string ext = str.Substring(0, str.LastIndexOf("#") + 1);
            Console.WriteLine(ext);
          

            string message = "Limbajul C#!";
            const string substring = "C#";
            int indexstart = message.IndexOf(substring);
            int indexfinal = substring.Length;
            Console.WriteLine(message.Substring(indexstart,indexfinal));
           

            string[] country = { "India", "England", "Anapa" };
            var sorted = from w in country orderby w select w;
            foreach(var w in sorted)
            {
                Console.WriteLine(w);
            }
            Console.ReadKey();
        }
    }
}
