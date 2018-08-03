using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class MyClass
    {
        int k;
        public MyClass(int i)
        {
            k = i;
        }
        ~MyClass()
        {
            Console.WriteLine("Obiectul {0} distrus!", k);
        }
        public void ObjectGenerator(int i)
        {
            MyClass ob = new MyClass(i);
        }
    }
}
