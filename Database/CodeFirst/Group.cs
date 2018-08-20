using System.Collections.Generic;

namespace CodeFirst
{
    public class Group
    {
        public int GroupId { get; set; }
        public string AcademicYear { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}