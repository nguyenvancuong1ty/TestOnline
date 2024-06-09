using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOnline_Data.Models;

namespace TestOnline_Data.Configurations
{
    public class NotificationToClassConfiguration : IEntityTypeConfiguration<NotificationToClass>
    {
        public void Configure(EntityTypeBuilder<NotificationToClass> builder)
        {
            builder.HasKey(x => new { x.NotifyId, x.ClassId });
            builder.HasOne(x => x.Notification).WithMany(x => x.NotificationToClass).HasForeignKey(x => x.NotifyId);
            builder.HasOne(x => x.Class).WithMany(x => x.NotificationToClass).HasForeignKey(x => x.ClassId);
        }
    }
}
