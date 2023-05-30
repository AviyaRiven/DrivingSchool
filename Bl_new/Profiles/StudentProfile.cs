using AutoMapper;
using Bl.dataObjects;
using Dal.dataObjects;

namespace Bl
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentBl>().ReverseMap();
        }
    }
}