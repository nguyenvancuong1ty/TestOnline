namespace TestOnline_Data.Models
{
    public class Notification
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<NotificationToClass> NotificationToClass { get; set; }
    }
}
