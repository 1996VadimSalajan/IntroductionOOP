using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            Property(x => x.Village)
                .HasMaxLength(50);
            Property(x => x.City)
               .HasMaxLength(50);
            Property(x => x.Country)
               .HasMaxLength(50);
        }
    }
}
