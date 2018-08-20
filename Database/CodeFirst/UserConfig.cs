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
            Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.PasswordUser)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.IDNP)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_IDNP") { IsUnique = true }));
            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Email") { IsUnique = true })); 
            Property(x => x.Photo)
                .HasMaxLength(400);
            Property(x => x.Gender)
               .IsRequired()
               .HasMaxLength(1);
            HasRequired(x => x.Teacher)
                .WithRequiredPrincipal(x => x.User);
        }
    }
}
