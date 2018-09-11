using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst
{
    class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            Ignore(x =>x.PageIndex);
            Ignore(x => x.RecordCount);
            Ignore(x => x.PageSize);
            HasRequired(x => x.Teacher)
                .WithRequiredPrincipal(x => x.User);
            HasMany(x => x.Students)
                  .WithRequired(x => x.User)
                  .HasForeignKey(x => x.UserId)
                  .WillCascadeOnDelete(false);
        }
    }
}
