namespace TestOnline_Data.Models
{
    public class Answer
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string IsCorrect { get; set; }
        public string QuestionId { get; set; }
        public Question Question { get; set; }
        public List<ResultDetail> ResultDetails { get; set; }
    }
}
