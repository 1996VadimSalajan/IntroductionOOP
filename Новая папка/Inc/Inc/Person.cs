using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc
{
    class Person 
    {
        string NamePerson { get; set; }
        string AgePerson { get; set; }
        string Address { get; set; }
        public string GetTimeOfDayWork (DateTime time)
        {
            if (time.Hour >= 0 && time.Hour < 6)
            {
                return "Night";
            }
            if (time.Hour >= 6 && time.Hour < 12)
            {
                return "Morning";
            }
            if (time.Hour >= 12 && time.Hour < 18)
            {
                return "Afternoon";
            }
            return "Evening";
        }

    }
}
