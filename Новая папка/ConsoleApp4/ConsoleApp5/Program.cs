using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int x = 0;
        static object locker=new object ();
        static void Main(string[] args)
        {
           
            Thread test = Thread.CurrentThread;
            test.Name = "TestThread";
            Console.WriteLine("Numele firului de executie: " + test.Name);
            Console.WriteLine("Threadul lucreaza ?: " + test.IsAlive);
            Console.WriteLine("Prioritatea threadului: " + test.Priority);
            Console.WriteLine("Starea firului de executie: " + test.ThreadState);
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Firul Principal:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
            Console.WriteLine();
            for (int i = 1; i < 11; i++)
            {
                ThreadPool.QueueUserWorkItem(Work, i);
                Thread.Sleep(10);

            }
            Console.WriteLine();
            for (int i = 1; i < 11; i++)
            {
                Thread method = new Thread(Work, i);
                method.Start(i);
                Thread.Sleep(10);

            }
           
            Console.ReadKey();
        }
        private static void Work(object i)
        {
            Console.WriteLine("Identificatorul thread:{0},parameetru:{1}", Thread.CurrentThread.ManagedThreadId, i);
        }
        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Al doilea fir:");
                Console.WriteLine(i * i);
                Thread.Sleep(200);
            }
        }
        public static void Countlock()
        {
            lock (locker)
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }

    }
}
