namespace TestOnline_Data.Models
{
    public class NotificationToClass
    {
        public string NotifyId { get; set; }
        public string ClassId { get; set; }
        public Notification Notification { get; set; }
        public Classes Class { get; set; }

    }
}
