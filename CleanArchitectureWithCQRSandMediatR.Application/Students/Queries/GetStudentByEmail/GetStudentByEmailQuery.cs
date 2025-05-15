using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentByEmail
{
    public class GetStudentByEmailQuery : IRequest<StudentViweModel>
    {
        public string Email { get; set; }
    }
}
