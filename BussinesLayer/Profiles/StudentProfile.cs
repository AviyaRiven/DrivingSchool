using AutoMapper;
using BussinesLayer.DTOs;
using Dal.dataObjects;

namespace BussinesLayer
{
    public class StudentProfile:Profile
    {
        public StudentProfile()
        {
            CreateMap<Student,StudentDTO>();
        }
    }
}