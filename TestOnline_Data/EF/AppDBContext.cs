using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestOnline_Data.Configurations;
using TestOnline_Data.Models;

namespace TestOnline_Data.EF
{
    public class AppDBContext : IdentityDbContext<User, Role, string>
    {

        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUserClaim<string>>(b => b.ToTable("UserClaims"));
            builder.Entity<IdentityUserRole<string>>(b =>
            {
                b.ToTable("UserRoles").HasKey(x => new { x.UserId, x.RoleId });

            });
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens").HasKey(x => x.UserId);

            //Config Fluent API
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new UserClassesConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new ExamConfiguration());
            builder.ApplyConfiguration(new ExamDetailConfiguration());
            builder.ApplyConfiguration(new QuestionConfiguration());
            builder.ApplyConfiguration(new ChapterConfiguration());
            builder.ApplyConfiguration(new AnswerConfiguration());
            builder.ApplyConfiguration(new ResultConfiguration());
            builder.ApplyConfiguration(new ResultDetailConfiguration());
            builder.ApplyConfiguration(new NotificationConfiguration());
            builder.ApplyConfiguration(new NotificationToClassConfiguration());


            //



        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<UserClasses> UserClasses { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<ResultDetail> ResultDetails { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationToClass> NotificationToClass { get; set; }



    }
}
