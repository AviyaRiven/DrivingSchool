//פונקציית Get

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
using Bl.dataObjects;

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
                Teacher dalEntity = mapper.Map<Teacher>(entity);
                return teacherServiceDal.CreateAsync(dalEntity);
        }

        public async Task<List<TeacherBl>> GetAsync()
        {
            //לא
            // יכול להמיר סוג באופן מרומז
            List<Teacher> teachers = await teacherServiceDal.GetAsync();
            return mapper.Map<List<TeacherBl>>(teachers);
        }

        public async Task<TeacherBl?> GetAsyncById(string id)
        {
            Teacher t = await teacherServiceDal.GetAsyncById(id);
            return mapper.Map<TeacherBl>(t);
        }

        public async Task RemoveAsync(string id)
        {
            await teacherServiceDal.RemoveAsync(id);
        }

        public async Task UpdateAsync(string id, TeacherBl entity)
        {
            Teacher dalEntity = mapper.Map<Teacher>(entity);
             await teacherServiceDal.UpdateAsync(id, dalEntity);
        }
    }
}
