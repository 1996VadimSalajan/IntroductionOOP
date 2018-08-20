using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class GroupConfig : EntityTypeConfiguration<Group>
    {
        public GroupConfig()
        {
            Property(x => x.AcademicYear)
                .IsRequired();
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
