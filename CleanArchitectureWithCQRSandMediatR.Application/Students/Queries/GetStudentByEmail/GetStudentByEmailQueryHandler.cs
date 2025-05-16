using AutoMapper;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentByEmail
{
    public class GetStudentByEmailQueryHandler : IRequestHandler<GetStudentByEmailQuery, StudentViweModel>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetStudentByEmailQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        { 
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<StudentViweModel> Handle(GetStudentByEmailQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByEmailAsync(request.Email);
            return _mapper.Map<StudentViweModel>(student);

        }
    }
}
