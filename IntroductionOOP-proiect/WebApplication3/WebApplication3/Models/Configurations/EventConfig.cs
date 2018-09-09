using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class EventConfig : EntityTypeConfiguration<Event>
    {
        public EventConfig()
        {
            Property(x => x.EventName)
                .IsRequired()
                .HasMaxLength(200);
            HasMany(x => x.EventsStudents)
                   .WithRequired(x => x.Event)
                   .HasForeignKey(x => x.EventId)
                   .WillCascadeOnDelete(true);          
        }
    }
}
