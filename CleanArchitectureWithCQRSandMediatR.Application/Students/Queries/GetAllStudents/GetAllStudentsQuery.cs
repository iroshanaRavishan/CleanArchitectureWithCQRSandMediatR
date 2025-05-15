using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentById
{
    public class GetAllStudentsQuery : IRequest<List<StudentViweModel>> {}

    // public record GetBlogQuery : IRequest<List<StudentViweModel>>; ->  this is another way to do this
}
