using AutoMapper;
using TestOnline_Data.Models;
using TestOnline_Data.ViewModels;

namespace Application
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Classes, ClassVM>();

        }

    }
}
