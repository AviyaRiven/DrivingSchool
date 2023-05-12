//פונקציית Get

using Bl.dataObjectBL;
using Dal.dalapi;
using Dal.dalImplements;
using Dal.dataObjects;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace Bl
{
        public class TeacherServiceBl : ITeacherBl
        {
            ITeacherServiceDal teacherServiceDal;
            IMapper mapper;
            public TeacherServiceBl(ITeacherServiceDal teacherServiceDal,IMapper mapper)
            {
                this.teacherServiceDal = teacherServiceDal;
                this.mapper = mapper;
            }

        public Task CreateAsync(TeacherBl entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TeacherBl>> GetAsync()
        {
            //לא
            // יכול להמיר סוג באופן מרומז
            List<Teacher> teachers = await teacherServiceDal.GetAsync();
            return mapper.Map<List<TeacherBl>>(teachers);
        }

        public Task<TeacherBl?> GetAsyncById(string id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, TeacherBl entity)
        {
            throw new NotImplementedException();
        }
    }
}
