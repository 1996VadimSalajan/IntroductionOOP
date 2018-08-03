using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Computer
    {
        public OS RunableOS { get; private set; }
        public void LaunchOS(string osName)
        {
            RunableOS = OS.getInstance(osName);
        }
    }
}
