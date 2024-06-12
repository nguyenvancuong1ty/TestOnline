using TestOnline_Data.Models;
using TestOnline_Data.ViewModels;
using TestOnline_Data.ViewModels.Class;

namespace Application.Class
{
    public interface IClassService
    {
        public Task<ClassVM> GetClassById(string id);
        public Task<T> CreateClass<T>(CreateClassRequest CreateClassRequest);
        public Task<T> UpdateClass<T>(UpdateClassRequest UpdateClassRequest);
        public Task<bool> DeleteClass(DeleteClassRequest DeleteClassRequest);
    }
}
