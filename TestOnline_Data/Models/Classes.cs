namespace TestOnline_Data.Models
{
    public class Classes
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TeacherId { get; set; }
        public string JoinCode { get; set; }
        public string Note { get; set; }
        public int TotalStudent { get; set; }
        public DateTime SchoolYear { get; set; }
        public List<Subject> Subjects { get; } = new List<Subject>();

    }
}
