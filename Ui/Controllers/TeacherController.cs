using Dal.dalapi;
using Dal.dalImplements;
using Dal.dataObjects;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Bl;
using Bl.dataObjects;

namespace Ui.Controllers
{

    [ApiController]
    [Route("api/teacher")]

    public class TeacherController : ControllerBase
    {
        private readonly ITeacherBl teacher;
        public TeacherController(ITeacherBl teacher)
        {
            this.teacher = teacher;
        }

        [HttpGet]
        public async Task<List<TeacherBl>> Get() =>
            await teacher.GetAsync();

        [HttpGet("{id}")]
        public async Task<TeacherBl> Get(string id)
        {
            var tempTeacher = await teacher.GetAsyncById(id);
            
            if (tempTeacher is null)
            {
                return null;
            }

            return tempTeacher;
        }


        [HttpPost]
        public async Task<IActionResult> Post(TeacherBl newTeacher)
        {
            await teacher.CreateAsync(newTeacher);

            return CreatedAtAction(nameof(Get), new { id = newTeacher.Id }, newTeacher);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, TeacherBl updatedTeacher)
        {
            var tempTeacher = await teacher.GetAsyncById(id);

            if (tempTeacher is null)
            {
                return NotFound();
            }

            updatedTeacher.Id = tempTeacher.Id;

            await teacher.UpdateAsync(id, updatedTeacher);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var tempTeacher = await teacher.GetAsyncById(id);

            if (tempTeacher is null)
            {
                return NotFound();
            }

            await teacher.RemoveAsync(id);

            return NoContent();
        }

    }
}



