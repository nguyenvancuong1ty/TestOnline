using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Id).HasMaxLength(256);
        }
    }
}
