using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
   public class MoodleContext:DbContext
    {
        public MoodleContext():base("Moodle")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new YearOfStudyConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new TeacherConfig());
            modelBuilder.Configurations.Add(new StudentConfig());
            modelBuilder.Configurations.Add(new MarkConfig());
            modelBuilder.Configurations.Add(new GroupConfig());
            modelBuilder.Configurations.Add(new EventConfig());
            modelBuilder.Configurations.Add(new CoursConfig());
        }
        public virtual DbSet<Address> Adresses { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<YearOfStudy> YearOfStudies { get; set; }
    }
}
