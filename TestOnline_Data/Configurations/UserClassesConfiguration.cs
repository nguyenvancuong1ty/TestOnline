using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class UserClassesConfiguration : IEntityTypeConfiguration<UserClasses>
    {
        public void Configure(EntityTypeBuilder<UserClasses> builder)
        {
            builder.ToTable("UserClass").HasKey(ul => new { ul.UserId, ul.ClassesId });
            builder.HasOne(ul => ul.User).WithMany(u => u.UserClasses)
                .HasForeignKey(ul => ul.UserId);

            builder.HasOne(ul => ul.Class).WithMany(c => c.UserClasses)
                .HasForeignKey(ul => ul.ClassesId);
            builder.Property(ul => ul.ClassesId).HasMaxLength(256);
        }
    }
}
