namespace TestOnline_Data.Models
{
    public class UserClasses
    {
        public string ClassesId { get; set; }
        public string UserId { get; set; }
        public Classes Class { get; set; }
        public User User { get; set; }
    }
}
