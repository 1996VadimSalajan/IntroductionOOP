using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        public static string path1=@"d:\string.txt";
        public static DateTime b;
    
        static void Main(string[] args)
        {
            StringCompare();
            //var time = DateTime.UtcNow;
            //File.WriteAllText(path1, Convert.ToString(time));      
            //var time = DateTime.Parse(File.ReadAllText(path1));
            //var newtime  = time.ToLocalTime();
            //Console.WriteLine(newtime);
            //int i = 1;
            //MyClass obj = new MyClass(i);
            //for (; i < 40000; i++)
            //{
            //    obj.ObjectGenerator(i);
            //}
           // Time();
            Console.ReadKey();
        }
        public  static void WriteFile()
        {        
            string lines = "Futbol maçı izliyorum!";
            byte[] array = Encoding.Unicode.GetBytes(lines);
            foreach (var item in array)
                Console.WriteLine(item);
            using (StreamWriter outputFile = new StreamWriter(path1,true,Encoding.UTF8))
            {
                outputFile.WriteLine(lines);
            }
            using (StreamReader outputFile = new StreamReader(path1))
            {
               Console.WriteLine(outputFile.ReadLine());
            }
        }
       public static void  Searching()
        {
            string searching = "Soccer is popular sport in world!";
            searching.StartsWith("is");
            searching.Contains("sport");
            searching.EndsWith("in");
            Console.WriteLine(searching.StartsWith("Soccer"));
            Console.WriteLine(searching.Contains("sport"));
            Console.WriteLine(searching.EndsWith("world"));
        }
        public static void FormatingString()
        {
            string composite1 = "My number telephone is {0:(###) ###-###-###}";
            Console.WriteLine(string.Format(composite1, 373068987789));
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int val1 = 1;
            decimal val2 = 12;
            decimal val3 = 1234.12m;
            Console.WriteLine($"Number 1 {val1:C}");
            Console.WriteLine($"Number 2 {val2:C}");
            Console.WriteLine($"Number 3 {val3:c}");
        

        }
        public static void StringCompare()
        {
            Console.WriteLine("go".EndsWith("Go", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("æ".EndsWith("cc", StringComparison.CurrentCulture));
            Console.WriteLine("ß".EndsWith("ss", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("ß".EndsWith("ss"));
        }
        public static void Time()
        {
            TimeSpan span1 = TimeSpan.FromDays(1);
            TimeSpan span2 = TimeSpan.FromHours(1);
            TimeSpan span3 = TimeSpan.FromMinutes(1);
            TimeSpan span4 = TimeSpan.FromSeconds(1);
            TimeSpan span5 = TimeSpan.FromMilliseconds(1);
            Console.WriteLine(span1);
            Console.WriteLine(span2);
            Console.WriteLine(span3);
            Console.WriteLine(span4);
            Console.WriteLine(span5);          
            DateTime localVersion = DateTime.UtcNow.ToLocalTime();
            localVersion = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            Console.WriteLine(localVersion);
            DateTime date1 = new DateTime(2015, 12, 25, 2, 9, 0);
           var a=date1.TimeOfDay;
            Console.WriteLine(date1.ToString());
            DateTime date2 = new DateTime(2015, 12, 24, 1, 7, 0);
            Console.WriteLine(date2.ToString());
            TimeSpan interval = date1.Subtract(date2);     
            Console.WriteLine("Days:"+interval.Days);
            Console.WriteLine("Total of Days:"+interval.TotalDays);
            Console.WriteLine("Hours:"+interval.Hours);
            Console.WriteLine("Total Hours:"+interval.TotalHours);
            Console.WriteLine("Minutes:"+interval.Minutes);
            Console.WriteLine("Tota of Minutes:"+interval.TotalMinutes);
            Console.WriteLine("Seconds:"+interval.Seconds);
            Console.WriteLine("Total Seconds:"+interval.TotalSeconds);
            Console.WriteLine("Milliseconds:"+interval.Milliseconds);
            Console.WriteLine("Total Milliseconds:"+interval.TotalMilliseconds);          
            string currentCulture = Thread.CurrentThread.CurrentCulture.DisplayName;
            DateTime currentTime = DateTime.Now;  
            string dateInUSA = currentTime.ToString("D", new CultureInfo("en-US"));
            string dateInHindi = currentTime.ToString("D", new CultureInfo("hi-IN")); 
            string dateInJapan = currentTime.ToString("D", new CultureInfo("ja-JP")); 
            string dateInFrench = currentTime.ToString("D", new CultureInfo("ro-Ro"));
            Console.WriteLine(dateInUSA);
            Console.WriteLine(dateInHindi);
            Console.WriteLine(dateInJapan);
            Console.WriteLine(dateInFrench);
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.WriteLine(ci.Name + ", " + ci.EnglishName);
            }
        }     
    }
}
