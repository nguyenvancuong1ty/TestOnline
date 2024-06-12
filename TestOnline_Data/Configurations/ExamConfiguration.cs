using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Id).HasMaxLength(256);
            builder.HasOne(sj => sj.Subject).WithMany(ex => ex.Exams).HasForeignKey(sj => sj.SubjectId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(us => us.User).WithMany(ex => ex.Exams).HasForeignKey(sj => sj.CreatedUserId).OnDelete(DeleteBehavior.Restrict); ;

        }
    }
}
