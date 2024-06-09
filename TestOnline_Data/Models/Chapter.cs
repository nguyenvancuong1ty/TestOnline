namespace TestOnline_Data.Models
{
    public class Chapter
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SubjectId { get; set; }
        public bool Deleted { get; set; }
        public Subject Subject { get; set; }
        public List<Question> Questions { get; set; }
    }
}
