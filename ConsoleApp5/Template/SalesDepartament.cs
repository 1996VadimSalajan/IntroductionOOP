using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class SalesDepartament:EmploymentProcces
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Write a test at SD.");
        }
        public override void TehnicalInterview()
        {
            Console.WriteLine("Conduct a tehnical interview at SD.");
        }
    }
}
