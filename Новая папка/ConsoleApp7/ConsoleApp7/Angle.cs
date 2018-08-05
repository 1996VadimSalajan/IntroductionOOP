using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Angle
    {
        //public int hour, minute, seconds, resultat;
        public static List<Angle> a;


       public int hour{get;set;}
        public int seconds { get; set; }
        public int minute { get; set; }

        public static bool operator>= (Angle a, Angle b)
        {
            Angle geo = new Angle();
            if (a.seconds > b.seconds)
                // geo.minute = a.minute + b.minute;
                // geo.hour = a.hour + b.hour;
                return true;
            else return false;
        }
        public static bool operator<=(Angle a, Angle b)
        {
           // Angle geo = new Angle();
           // geo.seconds = a.seconds - b.seconds;
            // geo.minute = a.minute - b.minute;
            // geo.hour = a.hour - b.hour;
            if (a.seconds > b.seconds)
                return true;
            else return false;
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
