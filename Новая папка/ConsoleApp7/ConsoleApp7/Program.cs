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
            geo1.setSeconds(173);
            geo1.setMinute(45);
            geo1.setHour(4);
            Angle geo2 = new Angle();
            geo2.setSeconds(23);
            geo2.setMinute(45);
            geo2.setHour(3);
            Angle geo3 = new Angle();
            geo3 = geo1 + geo2;
            secondsSum = geo3.ResultatSeconds();
            minuteSum = geo3.ResultatMinutes();
            hourSum = geo3.ResultatHour();

            CalculateDegrees();

            Console.WriteLine("Resultat final pentru Sum :"+hourfinal+"  degrees  "+minfinal+"'' "+secondfinal+"' ");
            geo3 = geo1 - geo2;
            secondsSum = geo3.ResultatSeconds();
            minuteSum = geo3.ResultatMinutes();
            hourSum = geo3.ResultatHour();

            CalculateDegrees();

            Console.WriteLine("Resultat final pentru Difference :" + hourfinal + "  degrees  " + minfinal + "'' " + secondfinal + "' ");

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
