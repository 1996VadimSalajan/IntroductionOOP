using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory
{
    class Apple:IMobile
    {
        public string ModelName()
        {
            return "Apple X";
        }
        public string Camera()
        {
            return "Dual:23 Mp + 23 Mp, Front - 15 Mp,Video 4K";
        }
        public string Memory()
        {
            return "64 GB ROM, 3 GB RAM";
        }
        public string Display()
        {
            return "5.99 3840 × 2160p(4k)";
        }
        public string Battery()
        {
            return "Capacity 3600 mAh";
        }
        public string OperatingSystem()
        {
            return "IOS 11";
        }
    }
}
