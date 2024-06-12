using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(u => u.Id);
            builder.Property(u => u.Id).HasMaxLength(256);
        }
    }
}
