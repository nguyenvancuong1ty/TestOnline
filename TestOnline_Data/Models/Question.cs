namespace TestOnline_Data.Models
{
    public class Question
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string Difficulty { get; set; }
        public string ChapterId { get; set; }
        public string CreatedUserId { get; set; }
        public bool Deleted { get; set; }
        public Chapter Chapter { get; set; }
        public List<ExamDetail> ExamDetails { get; set; }
        public List<Answer> Answers { get; set; }
        public List<ResultDetail> ResultDetails { get; set; }
    }
}
