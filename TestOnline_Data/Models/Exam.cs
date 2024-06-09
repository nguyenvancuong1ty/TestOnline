namespace TestOnline_Data.Models
{
    public class Exam
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsSeePoint { get; set; }
        public bool IsWrapQuestion { get; set; }
        public int TotalNumberQuestion { get; set; }
        public int NumberQuestionEz { get; set; }
        public int NumberQuestionBasic { get; set; }
        public int NumberQuestionDifficult { get; set; }
        public string CreatedUserId { get; set; }
        public string? SubjectId { get; set; }
        public Subject Subject { get; set; }
        public User User { get; set; }
        public List<ExamDetail> ExamDetails { get; set; }
        public List<Result> Results { get; set; }
    }
}
