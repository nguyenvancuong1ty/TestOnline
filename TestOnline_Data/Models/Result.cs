namespace TestOnline_Data.Models
{
    public class Result
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ExamId { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
        public Exam Exam { get; set; }
        public List<ResultDetail> ResultDetails { get; set; }
    }
}
