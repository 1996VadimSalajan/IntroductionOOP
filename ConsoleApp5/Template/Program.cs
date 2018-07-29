using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            EmploymentProcces employment1 = new ComputersDepartament();
            employment1.AlghoritmEmployment();
            EmploymentProcces employment2 = new SalesDepartament();
            employment2.AlghoritmEmployment();
            Console.ReadKey();
        }
    }
}
