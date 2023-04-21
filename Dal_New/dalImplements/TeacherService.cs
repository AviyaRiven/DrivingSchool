using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.dalapi;
using Dal.dataObjects;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Dal.dalImplements
{
    public class TeacherService : ITeacherService
    {
        public DataContext dataContext { get; }
        public IMongoCollection<Teacher> collection { get; }

        public TeacherService()
        {
            dataContext = DataContext.Instance;
            collection = dataContext.Database.GetCollection<Teacher>("Teachers");
        }

        public Task CreateAsync(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Teacher entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Teacher>> ReadAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> ReadByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}