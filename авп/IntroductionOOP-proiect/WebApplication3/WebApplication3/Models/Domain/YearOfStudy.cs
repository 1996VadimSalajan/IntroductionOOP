using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class YearOfStudy
    {
        public int  Id { get; set; }
        public DateTime BegginingYear { get; set; }
        public DateTime EndYear { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}