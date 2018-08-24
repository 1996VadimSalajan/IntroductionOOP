using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Database;

namespace TestGroup
{
    class GroupFactory
    {
        public static Group CreateGroup(NewMoodleEntities1 newMoodlecontext)
        {
            var group = new Group()
            {
                AcademicYear = "182",
                Name = "Fire"
            };
            newMoodlecontext.Groups.Add(group);

        }
    }
}
