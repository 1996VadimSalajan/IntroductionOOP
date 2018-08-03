#define x 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Catch
{

    class Program
    {


        static void Main(string[] args)
        {

            NewMethod();


        }
        private static void LogException(Exception exception, bool expected = true)
        {
            Console.WriteLine($"[{(expected ? "EXPECTED" : "UNEXPECTED")}] {exception.ToString()}: {exception.Message}");
        }

        private static void NewMethod()
        {
            try
            {
                var fileContents = new StreamReader(@"C:\tesst.docx").ReadToEnd();
                Console.WriteLine("File Exist!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Not is Acces");
            }
            catch (IOException ioex) when (ioex is FileNotFoundException || ioex is DirectoryNotFoundException)
            {
                var a = new Exception("DSADSA");

                throw new InvalidOperationException("File  does not exist! It may have been moved because has been moved ...", ioex);
                throw ioex;
                throw;
            }
            finally
            {
                Console.WriteLine("Finally!");
            }


#if (x)
            Console.WriteLine("x defined");
#else
            Console.WriteLine("x not defined");
#endif
            Debug.WriteLine("Tot ok!");
            Console.ReadKey();
        }
    }
}
