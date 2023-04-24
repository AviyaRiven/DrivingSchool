using Dal.dalapi;
using Dal.dalImplements;
using Dal.dataObjects;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Ui.Controllers
{

    [ApiController]
    [Route("api/student")]

    public class StudentController : ControllerBase
    {
        IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service; 
        }
        //[HttpGet]
        //    public async Task<List<Student>> Get() =>
        //        await service.ReadAsync();


        //[HttpGet("id")]
        //public string ReadById(string id)
        //{

        //    return "jfgf";
        //}


        //[HttpPost]
        //public async Task Post(Student newStudent)
        //{
        //    StudentService s = new StudentService();
        //    await s.CreateAsync(newStudent);

        //    return;
        //}

        //[HttpDelete]
        //public void DeleteByID(string id)
        //{ 
        //}
  

    }
}