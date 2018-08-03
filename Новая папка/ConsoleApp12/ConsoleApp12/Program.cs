using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"d:\Test1\test2.txt";
            string path2 = @"d:\Test2\test.txt";
            FileInfo a = new FileInfo(path1);
            FileInfo b = new FileInfo(path2);
            File.Create(path1);
            {
                Console.WriteLine("Has been created!");
            }

            //FileInfo b = new FileInfo(path2);
            //a.MoveTo(path2);
            // a.Delete();
            //StreamWriter str = a.CreateText();
            //str.WriteLine("das4747474rutra");
            //Console.WriteLine(a.Length);
            //str.Close();
            // b.CopyTo(path1);
            Console.WriteLine(b.Directory.FullName);
            StreamWriter sw = b.AppendText();
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
            Console.WriteLine("File has been appended");

            sw.Close();
            StreamReader sr = b.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
