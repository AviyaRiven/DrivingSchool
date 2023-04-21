using Microsoft.AspNetCore.Mvc;
using Dal.dalImplements;
using Dal.dataObjects;
namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        //public static Bson Get(string id)
        //{
        //   
        //    return s.ReadByIdAsync(id);
        //}

        public async Task<ActionResult<Student>> Get(string id)
        { StudentService s = new StudentService();
            var book = await s.ReadByIdAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }
    }
}