using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Simple_Factory.Program;

namespace Simple_Factory
{
    class FactoryClass
    {
        public static Mobile CreateMobileObject(MobileType mobileType)
        {
          

            Mobile objIMobile = null;
            switch (mobileType)
            {
                case MobileType.Samsung:
                    objIMobile = new Samsung();
                    break;
                case MobileType.Xiaomi:
                    objIMobile = new Xiaomi();
                    break;
                case MobileType.Apple:
                    objIMobile = new Apple();
                    break;
                default:
                    return null;
            }

            return objIMobile;
        }


        public static Samsung CreateJ5Samsung(string countryOrigin)
        {
            var samsungJ5 = new Samsung()
            {
                Battery = "3000 mAh",
                Camera = "13px",
                Display = "fewfew",
                OperatingSystem = "Android",
                CountryOrigin = countryOrigin
            };

            return samsungJ5;
        }



    }
}
