using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ExamDetailConfiguration : IEntityTypeConfiguration<ExamDetail>
    {
        public void Configure(EntityTypeBuilder<ExamDetail> builder)
        {
            builder.HasKey(x => new { x.ExamId, x.QuestionId });
            builder.HasOne(s => s.Exam).WithMany(s => s.ExamDetails).HasForeignKey(s => s.ExamId);
            builder.HasOne(s => s.Question).WithMany(s => s.ExamDetails).HasForeignKey(s => s.QuestionId);
        }
    }
}
