using Dal.dalapi;
using Dal.dalImplements;
using Dal.dataObjects;
using Microsoft.AspNetCore.Mvc;
//using Dal_New.dalImplements;
//using Dal_New.dataObjects;
//using Dal_New.dalapi;
//using Dal_New.dalImplements;

namespace Ui.Controllers
{
    [ApiController]
    [Route("api/teacher")]
    public class TeacherController : Controller
    {
        ITeacherService teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }
        //        //Iclass1 c = new Iclass1();
        //        //public IActionResult Index()
        //        //{
        //        //    return View();
        //        //}


        //        //public List<Teacher> Get()
        //        //{
        //        //    Bl.TeacherServiceBl(c);
        //        //}
        //        [HttpPost]
        //        public void Create()
        //        {
        //            TeacherService t = new TeacherService();
        //            Teacher teacher = new Teacher("323", "ginendel", "mhgh", "fjfj", "jfdj", 454, "gjd", "gjdfj", "hjfj", 4546, new DateTime(2015, 12, 25));
        //            t.Create(teacher);
        //        }

        [HttpGet]
        public Teacher GetById(string id)
        {
            return teacherService.ReadById(id);
        }
        //[HttpPut]
        //public void Put()
        //{
        //    TeacherService t = new TeacherService();
        //    t.Update("214587963");
        //}
        [HttpDelete]
        public void Delete(string id)
        {
            teacherService.Delete(id);
        }
    }

}
