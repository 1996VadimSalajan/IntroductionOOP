using System;
using System.Collections.Generic;

namespace CodeFirst
{
    public class Cours
    {
        public int CoursId { get; set; }
        public string NameCourse { get; set; }
        public int GroupId { get; set; }
        public DateTime DateCreateCourse { get; set; }
        public int MainTeacher { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual Group Group { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}