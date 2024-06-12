namespace TestOnline_Data.Models
{
    public class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberCredits { get; set; }
        public int NumberLapSessions { get; set; }
        public int NumberLectureSessions { get; set; }
        public bool Status { get; set; }

        public Classes? Classes { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
