using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class TeacherConfig : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfig()
        {
            Property(x => x.EntryTime)
                .IsRequired();
            Property(x => x.ExitTime)
                .IsRequired();
            Property(x => x.Active)
                .IsRequired()
                .HasMaxLength(3);
        }
    }
}
