using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    abstract class Mobile
    {
        public string ModelName { get; set; }
        public string Camera { get; set; }
        public string Memory { get; set; }
        public string Display { get; set; }
        public string Battery { get; set; }
        public string OperatingSystem { get; set; }

        public string CountryOrigin { get; set; }
    }
}
