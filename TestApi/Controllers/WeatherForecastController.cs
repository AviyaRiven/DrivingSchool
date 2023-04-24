//using Microsoft.AspNetCore.Mvc;
//using Dal.dalImplements;
//using Dal.dataObjects;
//namespace TestApi.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class TestController : ControllerBase
//    {

//        [HttpGet]
//        //public static Bson Get(string id)
//        //{
//        //   
//        //    return s.ReadByIdAsync(id);
//        //}

//        public async Task<Student> Get(string id)
//        { StudentService s = new StudentService();
//            var book = await s.ReadByIdAsync(id);

//            //if (book is null)
//            //{
//            //    return NotFound();
//            //}

//            return book;
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post(Student entity)
//        {
//            StudentService s = new StudentService();

//            await s.CreateAsync(entity);


//            return CreatedAtAction(nameof(Get), new { id = entity.Id }, entity);

          

//        }

//    }

     

//    }
