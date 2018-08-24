using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            Property(x => x.Active)
                .IsRequired()
                .HasMaxLength(3);      
            HasMany(x => x.Marks)
                    .WithRequired(x => x.Student)
                    .HasForeignKey(x => x.StudentId)
                    .WillCascadeOnDelete(false);
            HasMany(x => x.EventsStudents)
                   .WithRequired(x => x.Student)
                   .HasForeignKey(x => x.StudentId)
                   .WillCascadeOnDelete(true);
        }
    }
}
