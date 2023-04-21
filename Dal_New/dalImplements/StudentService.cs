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
        public DataContext dataContext { get; }
        public IMongoCollection<Student> collection { get; }
        public StudentService()
        {
            dataContext = DataContext.Instance;
            collection = dataContext.Database.GetCollection<Student>("Students");

        }

        public Task CreateAsync(Student entity)
        {
            throw new NotImplementedException();
        }

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
        

        public async Task<Student> ReadByIdAsync(string id)=>
        
            await collection.Find(x => x.Id == id).FirstOrDefaultAsync();
       


    }

}
