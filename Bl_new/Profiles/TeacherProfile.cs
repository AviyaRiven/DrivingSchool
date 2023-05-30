using Dal.dataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bl.dataObjects;

namespace Bl.Profiles
{
    internal class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<Teacher, TeacherBl>().ReverseMap();
        }
    }
}
