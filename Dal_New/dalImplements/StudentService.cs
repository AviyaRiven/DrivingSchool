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
    public class StudentService:IStudentService 
    {
        IDataContext dataContext;
        public IMongoCollection<Student> collection { get; }

        public FilterDefinitionBuilder<Student> filter;
        public StudentService(IDataContext data)
        {
            dataContext = data;
            collection = dataContext.Database.GetCollection<Student>("Students");
        }
        public async Task CreateAsync(Student entity) =>
            await collection.InsertOneAsync(entity);

        public Task UpdateAsync(string id, Student entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> ReadAsync()=>
       
        await collection.Find(_ => true).ToListAsync();

        public Task<Student> ReadByIdAsync(string id)
        {
            throw new NotImplementedException();
        }


        //public async Task<Student> ReadByIdAsync(string id)
        //{
        //    try
        //    {
        //        Student student = 
        //    }
        //}

        //    await collection.Find(x => x.Id == id).FirstOrDefaultAsync();



    }

}
