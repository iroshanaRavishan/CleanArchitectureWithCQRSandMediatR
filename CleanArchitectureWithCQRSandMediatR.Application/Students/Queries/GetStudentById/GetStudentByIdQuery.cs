using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentById
{
    public class GetStudentByIdQuery : IRequest<StudentViweModel>
    {
        public int StudentId { get; set; }
    }
}
