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
    [Route("api/student")]

    public class StudentController : ControllerBase
    {
        private readonly IStudentBl studentBl;
        public StudentController(IStudentBl student)
        {
            studentBl = student;
        }

            [HttpGet]
            public async Task<List<StudentBl>> Get() =>
                await studentBl.GetAsync();

            [HttpGet("{id}")]
            public async Task<StudentBl> Get(string id)
            {
                var tempStudent = await studentBl.GetAsyncById(id);

            if (tempStudent is null)
            {
                return null;
            }

            return tempStudent;
            }

            [HttpPost]
            public async Task<IActionResult> Post(StudentBl newStudent)
            {
                await studentBl.CreateAsync(newStudent);

                return CreatedAtAction(nameof(Get), new { id = newStudent.Id }, newStudent);
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> Update(string id, StudentBl updatedStudent)
            {
                var tempStudent = await studentBl.GetAsyncById(id);

                if (tempStudent is null)
                {
                    return NotFound();
                }

            updatedStudent.Id = tempStudent.Id;

                await studentBl.UpdateAsync(id, updatedStudent);

                return NoContent();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(string id)
            {
                var tempStudent = await studentBl.GetAsyncById(id);

                if (tempStudent is null)
                {
                    return NotFound();
                }

                await studentBl.RemoveAsync(id);

                return NoContent();
            }

    }
}