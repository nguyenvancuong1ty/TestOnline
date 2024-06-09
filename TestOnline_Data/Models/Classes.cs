namespace TestOnline_Data.Models
{
    public class Classes
    {
        public string Id { get; set; }
        public string? SubjectId { get; set; }
        public string Name { get; set; }
        public string TeacherId { get; set; }
        public string JoinCode { get; set; }
        public string Note { get; set; }
        public int TotalStudent { get; set; }
        public DateTime SchoolYear { get; set; }


        public ICollection<UserClasses> UserClasses { get; set; }
        public Subject? Subject { get; set; }
        public List<NotificationToClass> NotificationToClass { get; set; }
    }
}
