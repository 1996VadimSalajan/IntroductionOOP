using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class Student
    {
        public int Id { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string Active { get; set; }
        public string Class { get; set; }
        public string UserId { get; set; }
        public int GroupId { get; set; }
        public int YearOfStudyId { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual User User { get; set; }
        public virtual YearOfStudy YearOfStudys { get; set; }       
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<EventsStudent> EventsStudents { get; set; }
    }
}