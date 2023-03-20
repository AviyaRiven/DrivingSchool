using Dal.dalapi;
using Dal.dataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
//using Dal.dalapi;
namespace Dal.dalImplements
{
    public class StudentService:IStudentService 
    {
        public DataContext dataContext { get; }
        public IMongoCollection<BsonDocument> collection { get; }
        public StudentService()
        {
            dataContext = DataContext.Instance;
            collection = dataContext.Database.GetCollection<BsonDocument>("Students");

        }
        public void Create(Student entity)
        {
            var document = new BsonDocument
            {
                { "id", entity.Id },
                { "first_name", entity.FirstName },
                { "last_name", entity.LastName },
                { "phone", entity.Phone },
                { "date_of_birth", entity.DateOfBirth },
                { "email", entity.Email },
                { "address", new BsonDocument{
                    {"city", entity.Adress.BuildingNumber },
                    {"neighborhood", entity.Adress.Neighborhood },
                    {"street", entity.Adress.Street },
                    {"building_number", entity.Adress.BuildingNumber }
                
                } },
                { "status", entity.Status }
            };

            collection.InsertOne(document);
        }

        public void Delete(string id)
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("id", id);
            collection.DeleteOne(deleteFilter);
        }

        //public List<Student> Read()
        //{
        //    var documents = collection.Find(new BsonDocument()).ToList();
        //    return documents;
        //}


        // public void Update(Student entity)
        // {
        //     throw new NotImplementedException();
        // }





        //public  Student ReadById(string id)
        // {

        //     throw new NotImplementedException();
        // }

        public List<BsonDocument> Readi()
        {
            var documents = collection.Find(new BsonDocument()).ToList();
            return documents;
        }

        public Student ReadById(string id)
        {
            throw new NotImplementedException();
        }
    }

    


}
