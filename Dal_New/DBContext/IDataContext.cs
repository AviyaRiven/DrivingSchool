using Dal.dataObjects;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IDataContext
    {
        IMongoCollection<Student> StudentCollection { get; }
        IMongoCollection<Teacher> TeacherCollection { get; }
    }
}
