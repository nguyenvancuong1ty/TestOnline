using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ResultConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(u => u.Id).HasMaxLength(256);
            builder.HasOne(e => e.User).WithMany(e => e.Results).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(e => e.Exam).WithMany(e => e.Results).HasForeignKey(e => e.ExamId).OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
