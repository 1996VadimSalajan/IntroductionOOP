using System.Data.Entity;

namespace TPH
{
    partial class Program
    {
        public class TPHMappingContext : DbContext
        {
            public TPHMappingContext():base("School")
            {

            }

            public DbSet<Person> people { get; set; }
        }
    }
}
