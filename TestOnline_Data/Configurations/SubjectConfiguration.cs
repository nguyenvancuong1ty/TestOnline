using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(sb => sb.Id);
            builder.Property(sb => sb.Name).IsRequired().HasMaxLength(256);
            builder.Property(sb => sb.Id).HasMaxLength(256);

            builder.HasOne(cl => cl.Classes).WithOne(sj => sj.Subject).HasForeignKey<Classes>(cl => cl.SubjectId);
        }
    }
}
