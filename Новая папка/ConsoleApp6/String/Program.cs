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
            //string words = "Univer(Utm):grupa[TI-152],anul-3substr";
            //int start1 = words.IndexOf("(");
            //int final1 = words.IndexOf(")")-")".Length;
            //string words1= words.Remove(start1+1, final1-start1);
            //Console.WriteLine(words1);

            //int start2 = words.IndexOf("[");
            //int final2 = words.IndexOf("]") - "]".Length;
            //string words2 = words.Remove(start2 + 1, final2 - start2);
            //Console.WriteLine(words2);

            //int final3 = words.IndexOf(":") - ":".Length+1;
            //string words3 = words.Remove(0, final3 - 0);
            //Console.WriteLine(words3);

            //int start4 = words.IndexOf(":")+1;
            //int final4 = words.Length;
            //string words4 = words.Remove(start4,final4-start4);
            //Console.WriteLine(words4);


            //string str = "this is a #string";
            //string ext = str.Substring(0, str.LastIndexOf("#") + 1);
            //Console.WriteLine(ext);


            //string message = "Limbajul C#!";
            //const string substring = "C#";
            //int indexstart = message.IndexOf(substring);
            //int indexfinal = substring.Length;
            //Console.WriteLine(message.Substring(indexstart,indexfinal));


            string[] country = { "India", "England", "Anapa" };
            //var sorted = from w in country orderby w select w;
           
            
            string[] test1 = { "test1","test2" };
            string[] test2 = new string[2];
            Array.Sort(country);
            Array.Reverse(country);
            Array.Clear(country, 1, 2);
            foreach (var w in country)
            {
                Console.WriteLine(w);
            }
            // test1=string.Copy(test2);
            test1.CopyTo(test2, 0);
            foreach(var item in test2)
            Console.WriteLine(item);
            Array a1 = Array.CreateInstance(typeof(int),5,5);
            a1.SetValue(2, 2,2);

            string a = "\'hjkl        wewe";
            string b = "sds";
            a.Remove(1,2);
            b.Replace('w', 'w');
           Console.WriteLine( a.Insert(0, b));
           Console.WriteLine( string.Equals(a, b));
           Console.WriteLine( a.ToUpper());
            string s = "there is a cat";
            // Split string on spaces.
            // ... This will separate all the words.
            string[] words = s.Split('e');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(a.TrimStart());

            string[] arr = { "one", "two", "three" };

            // "string" can be lowercase.
            Console.WriteLine(string.Join(",", arr));

            // ... "String" can be uppercase.
            Console.WriteLine(string.Join("\',", arr));
            StringBuilder MyOtherName = new StringBuilder("Hello");
            MyOtherName.Remove(2, 3); // produces "He"
            MyOtherName.Insert(2, "lp"); // produces "Help"
            MyOtherName.Replace('l', 'a'); // produces "Heap"
           
            var MyName = MyOtherName.ToString();
            Console.ReadKey();
        }
    }
}
