using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class ResultDetailConfiguration : IEntityTypeConfiguration<ResultDetail>
    {
        public void Configure(EntityTypeBuilder<ResultDetail> builder)
        {
            builder.HasKey(e => new { e.ResultId, e.QuestionId, e.AnswerId });
            builder.HasOne(e => e.Result).WithMany(e => e.ResultDetails).HasForeignKey(e => e.ResultId);
            builder.HasOne(e => e.Question).WithMany(e => e.ResultDetails).HasForeignKey(e => e.QuestionId);
            builder.HasOne(e => e.Answer).WithMany(e => e.ResultDetails).HasForeignKey(e => e.AnswerId);
        }
    }
}
