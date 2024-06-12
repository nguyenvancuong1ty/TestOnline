using AutoMapper;
using TestOnline_Data.EF;
using TestOnline_Data.Models;
using TestOnline_Data.ViewModels;
using TestOnline_Data.ViewModels.Class;

namespace Application.Class
{
    public class ClassService : IClassService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public ClassService(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<T> CreateClass<T>(CreateClassRequest CreateClassRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClass(DeleteClassRequest DeleteClassRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<ClassVM> GetClassById(string id)
        {
            var query = await _context.Classes.FindAsync(id);
            var result = _mapper.Map<ClassVM>(query);
            return result;
        }

        public Task<T> UpdateClass<T>(UpdateClassRequest UpdateClassRequest)
        {
            throw new NotImplementedException();
        }
    }
}
