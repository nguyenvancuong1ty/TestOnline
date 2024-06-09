namespace TestOnline_Data.Models
{
    public class ResultDetail
    {
        public string ResultId { get; set; }
        public string QuestionId { get; set; }
        public string AnswerId { get; set; }
        public bool IsCorrect { get; set; }
        public Result Result { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
    }
}
