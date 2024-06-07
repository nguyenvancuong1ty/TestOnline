namespace TestOnline_Data.Models
{
    public class Subject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberCredits { get; set; }
        public int numberLapSessions { get; set; }
        public int numberLectureSessions { get; set; }
        public bool Status { get; set; }
        public Classes Class { get; set; }
    }
}
