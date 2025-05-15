using CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentbyName
{
    public class GetStudentByNameQuery : IRequest<StudentViweModel>
    {
        public string Name { get; set; }
    }
}
