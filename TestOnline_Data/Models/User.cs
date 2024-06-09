using Microsoft.AspNetCore.Identity;

namespace TestOnline_Data.Models
{
    public class User : IdentityUser<string>
    {
        public string Id { get; set; }
        public ICollection<UserClasses> UserClasses { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Result> Results { get; set; }
    }
}

