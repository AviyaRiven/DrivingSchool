using Dal.dalImplements;
using Dal.dataObjects;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
//using Bl;
//using MongoDB.Bson;
//using Dal_New.dataObjects;

namespace Ui.Controllers
{

    [ApiController]
    [Route("api/student")]

    public class StudentController : ControllerBase
    {
        [HttpGet]
        //public List<BsonDocument> GetAll()
        //{
        //    //StudentService s2 = new StudentService();
        //    //return s2.Readi();
        //}

        //[HttpGet("id")]
        // public string ReadById(string id)
        //{
        //    TeacherServiceBl c = new TeacherServiceBl(); 
        //    return c.ReadById(id);
        //}

        [HttpPost]
        public void Create(string id, string firstName, string lastName, string phone, string email, int status, DateTime dateOfBirth, string city, string street, string neighborhood, int buildingNumber)
        {
            StudentService s2 = new StudentService();
            Student s = new Student(id, firstName, lastName, phone, email, city, street, neighborhood, buildingNumber, dateOfBirth, status);
            s2.Create(s);

        }

        [HttpDelete]

        public void DeleteByID(string id)
        {
            StudentService s2 = new StudentService();
            s2.Delete(id);
        }
    }
}


