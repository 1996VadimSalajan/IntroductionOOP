using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class Xiaomi:IMobile
    {
        public string ModelName()
        {
            return "Xiaomi MI10";
        }
        public string Camera()
        {
            return "Dual:23 Mp + 5 Mp, Front - 15 Mp,Video 4K";
        }
        public string Memory()
        {
            return "256 GB ROM, 12 GB RAM";
        }
        public string Display()
        {
            return "6.99 3840 × 2160p(4k)";
        }
        public string Battery()
        {
            return "Capacity 5600 mAh";
        }
        public string OperatingSystem()
        {
            return "Android";
        }
    }
}
