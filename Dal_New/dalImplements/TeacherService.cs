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
        public void Create(Teacher entity)
        {
            //var document = new BsonDocument
            //{
            //    { "id", entity.Id },
            //    { "first_name", entity.FirstName },
            //    { "last_name", entity.LastName },
            //    { "phone", entity.Phone },
            //    { "date_of_birth", entity.DateOfBirth },
            //    { "email", entity.Email },
            //    { "address", new BsonDocument{
            //        {"city", entity.Adress.BuildingNumber },
            //        {"neighborhood", entity.Adress.Neighborhood },
            //        {"street", entity.Adress.Street },
            //        {"building_number", entity.Adress.BuildingNumber }

            //    } }
            //};
            //collection.InsertOne(entity);
        }

        public void Delete(string id)
        {
            collection.DeleteOne(Builders<Teacher>.Filter.Eq("Id", id));
        }

        public Teacher ReadById(string id)
        {
            return collection.Find(Filter.Eq("Id", id)).FirstOrDefault();
        }
        //public string Read()
        //{

        //    //var dbList = dbClient.ListDatabases().ToList();

        //    //Console.WriteLine("The list of databases on this server is: ");
        //    //foreach (var db in dbList)
        //    //{
        //    //    Console.WriteLine(db);
        //    //}

        //    var collection = dataContext.Database.GetCollection<BsonDocument>("Teachers");

        //    var firstDocument = collection.Find(new BsonDocument()).ToList();
        //    return firstDocument.ToString();
        //}

        //public string ReadById(string id)
        //{
        //    var collection = dataContext.Database.GetCollection<BsonDocument>("Teachers");
        //    var filter = Builders<BsonDocument>.Filter.Eq("Id", id);
        //    var studentDocument = collection.Find(filter).FirstOrDefault();
        //    return studentDocument.ToString();
        //}

        //public void Update(string teacherId)
        //{
        //    collection.UpdateOne(Builders<Teacher>.Filter.Eq("Id", teacherId), Builders<Teacher>.Update.Set("First_name", "Avraam"));
        //}
    }
}