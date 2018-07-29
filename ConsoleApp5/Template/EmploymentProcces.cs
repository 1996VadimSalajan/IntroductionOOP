using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class EmploymentProcces
    { 
        public void AlghoritmEmployment()
        {
            FirstRoundTest();
            GroupDisscusion();
            TehnicalInterview();
            HumanResourceManagerInterview();
        }
        public abstract void FirstRoundTest();
        private void GroupDisscusion()
        {
            Console.WriteLine("Conduct group discussion.");
        }
        public abstract void TehnicalInterview();
        public void HumanResourceManagerInterview()
        {
            Console.WriteLine("Conduct human resource manager discussion.");
        }
    }
}
