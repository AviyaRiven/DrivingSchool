using AutoMapper;
using Bl.dataObjectBL;
using Dal.dataObjects;

namespace Bl
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentBl>();
        }
    }
}