using TestOnline_Data.Models;

namespace TestOnline_Data.ViewModels
{
    public class ClassVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string JoinCode { get; set; }
        public string Note { get; set; }
        public int TotalStudent { get; set; }
        public DateTime SchoolYear { get; set; }
    }
}
