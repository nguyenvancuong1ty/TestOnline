using Microsoft.EntityFrameworkCore;
using TestOnline_Data.Models;

namespace TestOnline_Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>().HasData(
               new Classes()
               {
                   Id = new Guid().ToString() + "1",
                   Name = "Toán cao cấp",
                   TeacherId = null,
                   JoinCode = "TCC01",
                   Note = "ssds",
                   TotalStudent = 20,
                   SchoolYear = DateTime.Now,
                   SubjectId = null

               },
            new Classes()
            {
                Id = new Guid().ToString() + "2",
                Name = "Tư tưởng HCM",
                TeacherId = null,
                JoinCode = "TTHCM",
                Note = "aadsdsd",
                TotalStudent = 12,
                SchoolYear = DateTime.Now,
                SubjectId = null

            });
        }
    }
}