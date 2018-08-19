using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
   public class SuscribesContext : DbContext
    {
        public SuscribesContext():base("Subscribes")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public  DbSet<Address> Adresse { get; set; }
        public  DbSet<Subscribes> Subscribes { get; set; } 
    }
}
