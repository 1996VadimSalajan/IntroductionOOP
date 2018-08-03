using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Angle : IEnumerable
    {
       private int hour, minute, seconds,resultat;
        public static List<Angle> a;


        static Angle()
        {
            a = new List<Angle>();
        }

        public int ResultatSeconds()
        {   
            return seconds;
        }
        public int ResultatMinutes()
        {
            return minute;
        }
        public int ResultatHour()
        {
            return hour;
        }
        public void setSeconds(int sec)
        {
            seconds = sec;
        }
        public void setMinute(int min)
        {
            minute = min;
        }
        public void setHour(int h)
        {
            hour= h;
        }

        public static Angle operator +(Angle a, Angle b)
        {
            Angle geo = new Angle();
            geo.seconds = a.seconds + b.seconds;
            geo.minute = a.minute + b.minute;
            geo.hour = a.hour + b.hour;
            return geo;
        }
        public static Angle operator -(Angle a, Angle b)
        {
            Angle geo = new Angle();
            geo.seconds = a.seconds - b.seconds;
            geo.minute = a.minute - b.minute;
            geo.hour = a.hour - b.hour;
            return geo;
        }

        private string[] tablouPrivat = new string[30];
        public string this[int index]
        {
            get
            {
                if (index < 30)
                    return tablouPrivat[index];
                else return " ";
            }
            set
            {
                if (index < 30 && index > 0)
                    tablouPrivat[index] = value;

            }
        }

    }
}
