using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Classes>
    {
        public void Configure(EntityTypeBuilder<Classes> builder)
        {
            builder.HasKey(cl => cl.Id);
            builder.Property(u => u.Id).HasMaxLength(256);
            builder.Property(cl => cl.SchoolYear)
                    .IsRequired()
                    .HasColumnType("Date");
            builder.Property(cl => cl.TeacherId);
            builder.Property(cl => cl.Name).HasMaxLength(256);
            builder.Property(cl => cl.Id).HasMaxLength(256);

        }
    }
}
