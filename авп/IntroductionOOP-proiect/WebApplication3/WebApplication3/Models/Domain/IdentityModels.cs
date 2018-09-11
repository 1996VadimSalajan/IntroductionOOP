using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using CodeFirst;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication3.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser :User
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Conection", throwIfV1Schema: false)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                  .Where(type => !String.IsNullOrEmpty(type.Namespace))
                  .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                                                       && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<IdentityUserRole>()
            .HasKey(r => new { r.UserId, r.RoleId })
            .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserLogin>()
                        .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
                        .ToTable("UserLogins");
        }
        public virtual DbSet<Address> Adresses { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<YearOfStudy> YearOfStudies { get; set; }
        public virtual DbSet<EventsStudent> EventsStudents { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}