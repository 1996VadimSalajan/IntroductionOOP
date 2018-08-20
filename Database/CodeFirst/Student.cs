using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class Student
    {
        public int StudentId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string Active { get; set; }
        public string Class { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int YearId { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual User User { get; set; }
        public virtual YearOfStudy YearOfStudy { get; set; }       
        public virtual ICollection<Event> Events { get; set; }
    }
}