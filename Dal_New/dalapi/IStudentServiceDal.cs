using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.dataObjects;

namespace Dal.dalapi
{
    public interface IStudentServiceDal : ICrud<Student>
    {
        Task CreateAsync(Student student);
    }
}
