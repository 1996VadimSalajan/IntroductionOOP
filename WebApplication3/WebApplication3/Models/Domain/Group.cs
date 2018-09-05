using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirst
{
    public class Group
    {
        public int Id { get; set; }
        [Required]
        public string AcademicYear { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}