using AutoMapper;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentById;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentbyName;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentByName
{
    public class GetStudentByNameQueryHandler : IRequestHandler<GetStudentByNameQuery, StudentViweModel>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetStudentByNameQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<StudentViweModel> Handle(GetStudentByNameQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByNameAsync(request.Name);
            return _mapper.Map<StudentViweModel>(student);
        }
    }
}
