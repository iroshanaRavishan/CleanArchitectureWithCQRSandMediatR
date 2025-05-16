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

        [Route("id/{id}")]
        [HttpGet]
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
    }
}
