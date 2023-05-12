using Dal.dalapi;
using Dal.dataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Dal.dalImplements
{
    public class StudentServiceDal:IStudentServiceDal 
    {

        private readonly IMongoCollection<Student> collection;

        //public FilterDefinitionBuilder<Student> filter;
        public StudentServiceDal(IDataContext dataContext)
        {
            collection = dataContext.StudentCollection;
          //  collection = dataContext.Database.GetCollection<Student>("Students");
        }
        public async Task<List<Student>> GetAsync() =>
         await collection.Find(_ => true).ToListAsync();

        public async Task<Student?> GetAsyncById(string id) =>
            await collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Student newStudent) =>
            await collection.InsertOneAsync(newStudent);

        public async Task UpdateAsync(string id, Student updatedStudent) =>
            await collection.ReplaceOneAsync(x => x.Id == id, updatedStudent);

        public async Task RemoveAsync(string id) =>
            await collection.DeleteOneAsync(x => x.Id == id);

    }

}
