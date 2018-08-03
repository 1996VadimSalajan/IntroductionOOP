using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{

    public class People : IPerson
    {
        private IPerson _person;

        public People(IPerson person)
        {
            this._person = person;
        }

        public People()
        {
        }

        public string GetName(string firstName, string lastName)
        {
            return string.Concat(firstName, " ", lastName);
        }
        public string MakeCreditDecision(int creditScore)
        {
            if (creditScore < 550)
                return "Declined";
            else if (creditScore <= 675)
                return "Maybe";
            else
                return "We look forward to doing business with you!";
        }
        public string GetTimeOfDay(DateTime time)
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


