using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Id).HasMaxLength(256);
            builder.HasOne(e => e.Question).WithMany(e => e.Answers).HasForeignKey(x => x.QuestionId);
        }
    }
}
