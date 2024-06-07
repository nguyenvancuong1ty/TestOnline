using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Classes>
    {
        public void Configure(EntityTypeBuilder<Classes> builder)
        {
            builder.HasKey(cl => cl.Id);
            builder.Property(cl => cl.SchoolYear)
                    .IsRequired()
                    .HasColumnType("Date");
            builder.Property(cl => cl.TeacherId).IsRequired();
        }
    }
}
