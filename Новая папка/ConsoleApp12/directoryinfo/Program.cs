using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directoryinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            String path1 = @"D:\MyTestFile1";
            String path2 = @"D:\MyTest";
            DirectoryInfo fl = new DirectoryInfo(path1);
            fl.Create();
            {
              Console.WriteLine("Directory has been created");
            }
            //fl.MoveTo(path2);
           // fl.Delete();
            {
                Console.WriteLine("Directory has been deleted.");
            }
            DirectoryInfo[] info = fl.GetDirectories();
            Console.WriteLine(info.Length);
            DirectoryInfo subdir = fl.CreateSubdirectory("Hello");
            Console.WriteLine("Create a subdirectory!"+fl);
           
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
