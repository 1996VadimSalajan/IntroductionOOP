using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class MyClass
    {
        private class AnonymousClass
        {
            public int myVar;
            public int __AnonymousMethod1(int var1)
            {
                myVar = myVar + 1;
                return var1 + myVar;
            }
        }
       
        public static Func<int, int> GetAFunc()
        {
            var __anonymousClass = new AnonymousClass();
            __anonymousClass.myVar = 1;
            return __anonymousClass.__AnonymousMethod1;
        }
    }

}
