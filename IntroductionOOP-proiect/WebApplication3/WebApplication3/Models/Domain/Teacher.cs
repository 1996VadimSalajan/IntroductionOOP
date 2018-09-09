using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class Teacher
    {
        public string Id { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string Active { get; set; }
        public string Degree { get; set; }
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual User User { get; set; }
    }
}