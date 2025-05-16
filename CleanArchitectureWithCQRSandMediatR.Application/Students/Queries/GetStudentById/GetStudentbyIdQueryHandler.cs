using AutoMapper;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Queries.GetStudentById
{
    public class GetStudentbyIdQueryHandler : IRequestHandler<GetStudentByIdQuery, StudentViweModel>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public GetStudentbyIdQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<StudentViweModel> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByIdAsync(request.Id);
            return _mapper.Map<StudentViweModel>(student);
        }
    }
}
