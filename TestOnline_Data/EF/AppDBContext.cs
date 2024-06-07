using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestOnline_Data.Configurations;
using TestOnline_Data.Models;

namespace TestOnline_Data.EF
{
    public class AppDBContext : IdentityDbContext<User, Role, Guid>
    {

        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Config Fluent API
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());


            //
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens").HasKey(x => x.UserId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
