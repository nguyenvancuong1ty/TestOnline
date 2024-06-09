namespace TestOnline_Data.Models
{
    public class ExamDetail
    {
        public string ExamId { get; set; }
        public string QuestionId { get; set; }
        public Exam Exam { get; set; }
        public Question Question { get; set; }
    }
}
