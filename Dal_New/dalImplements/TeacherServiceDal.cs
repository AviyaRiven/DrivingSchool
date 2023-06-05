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
    public class TeacherServiceDal : ITeacherServiceDal
    {
        private readonly IMongoCollection<Teacher> collection;

        public TeacherServiceDal(IDataContext dataContext)
        {
            collection = dataContext.TeacherCollection;
        }

        public async Task<List<Teacher>> GetAsync() =>
         await collection.Find(_ => true).ToListAsync();

        public async Task<Teacher?> GetAsyncById(string id) =>
            await collection.Find(x => x.TZ == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Teacher newTeacher) =>
            await collection.InsertOneAsync(newTeacher);

        public async Task UpdateAsync(string id, Teacher updatedTeacher) =>
            await collection.ReplaceOneAsync(x => x.TZ == id, updatedTeacher);

        public async Task RemoveAsync(string id) =>
            await collection.DeleteOneAsync(x => x.TZ == id);
    }
}