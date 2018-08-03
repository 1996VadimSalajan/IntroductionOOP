using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Test1
    {
        public Test4 test4 { get; set; }
        public Test2 test2 { get; set; }

        public Test1()
        {
            test4 = new Test4();
            test2 = new Test2();
        }

        public void Method1()
        {
            test2.test3.Test3Method();
            test4.test5.Test5Method();
        }
    }
    public class Test2
    {
        public Test3 test3 { get; set; }

        public Test2()
        {
            test3 = new Test3();
        }
    }

    public class Test3
    {
        public void Test3Method() { }
    }

    public class Test4
    {
        public Test5 test5 { get; set; }
        public Test4()
        {
            test5 = new Test5();
        }
    }

    public class Test5
    {
        public void Test5Method() { }
    }

}
