using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.dalapi;
using AutoMapper;
using Dal.dataObjects;
using Bl.dataObjects;

namespace Bl
{
    public class StudentServiceBl : IStudentBl
    {
        IStudentServiceDal studentServiceDal;
        IMapper mapper;
        public StudentServiceBl(IStudentServiceDal studentService,IMapper mapper)
        {
            this.studentServiceDal = studentService;
            this.mapper = mapper;
        }

        public Task CreateAsync(StudentBl entity)
        {
            entity.Id = null;
            //StudentBl st = new StudentBl() {  TZ=e};

            Student dalEntity = mapper.Map<Student>(entity);
            return studentServiceDal.CreateAsync(dalEntity);
        }

        public async Task<List<StudentBl>> GetAsync()
        {
            List<Student> students = await studentServiceDal.GetAsync();
            return mapper.Map<List<StudentBl>>(students);
        }

        public async Task<StudentBl?> GetAsyncById(string id)
        {
            Student? s = await studentServiceDal.GetAsyncById(id);
            return mapper.Map<StudentBl>(s);
        }

        public async Task RemoveAsync(string id)
        {
           await studentServiceDal.RemoveAsync(id);
        }

        public async Task UpdateAsync(string id, StudentBl entity)
        {
            Student dalEntity =  mapper.Map<Student>(entity);
             await studentServiceDal.UpdateAsync(id, dalEntity);
        }

    }
}
