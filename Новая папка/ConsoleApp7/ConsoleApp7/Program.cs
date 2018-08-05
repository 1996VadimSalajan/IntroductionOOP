using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        private static int secmin;
        private static int secondfinal;
        private static int minhour;
        private static int minfinal;
        private static int hourfinal;
        private static int secondsSum, minuteSum, hourSum;
        static void Main(string[] args)
        {      
            Angle geo1 = new Angle();
            geo1.seconds=173;
            geo1.minute=45;
            geo1.hour=(4);
            Angle geo2 = new Angle();
            geo2.seconds=(23);
            geo2.minute=(45);
            geo2.hour=(3);
            Angle geo3 = new Angle();
            if (geo1 >= geo2) Console.WriteLine("ok");
            secondsSum = geo3.seconds;
            minuteSum = geo3.minute;
            hourSum = geo3.hour;

            CalculateDegrees();

            Console.WriteLine("Resultat final pentru Sum :"+hourfinal+"  degrees  "+minfinal+"'' "+secondfinal+"' ");
          
            Angle obiect = new Angle();

            for (int i = 1; i <= 25; i++)
            {   
                obiect[i] = "Angle of "+i+" degrees";
            }

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(obiect[i]);
            }
            Console.ReadKey();
        }

      public  static void CalculateDegrees()
        {
            secmin = secondsSum / 60;
            secondfinal = secondsSum - 60 * secmin;
            minuteSum = secmin + minuteSum;
            minhour = minuteSum / 60;
            minfinal = minuteSum - 60 * minhour;
            hourfinal = hourSum + minhour;
        }
    }
}
