using Dal.dalapi;
using Dal.dalImplements;
using Dal.dataObjects;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Bl;
using Bl.dataObjectBL;

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

            [HttpGet("{id:length(24)}")]
            public async Task<ActionResult<StudentBl>> Get(string id)
            {
                var book = await studentBl.GetAsyncById(id);

                if (book is null)
                {
                    return NotFound();
                }

                return book;
            }

            [HttpPost]
            public async Task<IActionResult> Post(StudentBl newStudent)
            {
                await studentBl.CreateAsync(newStudent);

                return CreatedAtAction(nameof(Get), new { id = newStudent.Id }, newStudent);
            }

            [HttpPut("{id:length(24)}")]
            public async Task<IActionResult> Update(string id, StudentBl updatedStudent)
            {
                var book = await studentBl.GetAsyncById(id);

                if (book is null)
                {
                    return NotFound();
                }

            updatedStudent.Id = book.Id;

                await studentBl.UpdateAsync(id, updatedStudent);

                return NoContent();
            }

            [HttpDelete("{id:length(24)}")]
            public async Task<IActionResult> Delete(string id)
            {
                var book = await studentBl.GetAsyncById(id);

                if (book is null)
                {
                    return NotFound();
                }

                await studentBl.RemoveAsync(id);

                return NoContent();
            }

    }
}