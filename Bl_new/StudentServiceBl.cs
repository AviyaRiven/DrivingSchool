using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bl.dataObjectBL;
using Dal.dalapi;
using AutoMapper;
using Dal.dataObjects;

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
            throw new NotImplementedException();
        }

        public async Task<List<StudentBl>> GetAsync()
        {
            List<Student> students = await studentServiceDal.GetAsync();
            return mapper.Map<List<StudentBl>>(students);
        }

        public Task<StudentBl?> GetAsyncById(string id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, StudentBl entity)
        {
            throw new NotImplementedException();
        }
        //

    }
}
