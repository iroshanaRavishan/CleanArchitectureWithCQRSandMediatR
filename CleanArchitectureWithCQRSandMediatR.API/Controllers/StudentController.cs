using CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.CreateStudent;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.DeleteStudent;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.UpdateStudent;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentByEmail;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentById;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentbyName;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureWithCQRSandMediatR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await Mediator.Send(new GetAllStudentsQuery());
            return Ok(students);
        }

        [HttpGet("id/{id}", Name = "GetStudentById")]
        public async Task<IActionResult> GetStudentByIdAsync(int id)
        {
            var student = await Mediator.Send(new GetStudentByIdQuery() { Id = id });
            return student == null ? NotFound() : Ok(student);
        }

        [Route("name/{name}")]
        [HttpGet]
        public async Task<IActionResult> GetStudentsByName(string name)
        {
            var student = await Mediator.Send(new GetStudentByNameQuery() { Name = name });
            return student == null ? NotFound() : Ok(student);
        }

        [Route("email/{email}")]
        [HttpGet]
        public async Task<IActionResult> GetStudentByEmail(string email)
        {
            var student = await Mediator.Send(new GetStudentByEmailQuery() { Email = email });
            return student == null ? NotFound() : Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudentsAsync(AddStudentCommand command)
        {
            var addedStudent =  await Mediator.Send(command);
            return CreatedAtRoute("GetStudentById", new { id = addedStudent.Id }, addedStudent); // show the created content
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudentAsync(int id, UpdateStudentCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentAsync(int id)
        {
            await Mediator.Send(new DeleteStudentCommand() { Id = id });
            // TODO : need to handle the non exsiting scenario
            return NoContent();
        }
        
    }
}
