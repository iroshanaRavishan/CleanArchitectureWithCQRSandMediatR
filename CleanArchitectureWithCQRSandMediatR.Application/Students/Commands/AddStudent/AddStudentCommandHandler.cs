using AutoMapper;
using CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.CreateStudent;
using CleanArchitectureWithCQRSandMediatR.Domain.Entities;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.AddStudent
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public AddStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public async Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var studentEntity = new Student()
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                City = request.City,
                State = request.State,
                PostalCode = request.PostalCode,
                Country = request.Country,
                GuardianName = request.GuardianName,
                GuardianPhone = request.GuardianPhone,
                GuardianEmail = request.GuardianEmail,
                RelationshipToStudent = request.RelationshipToStudent,
                IsActive = request.IsActive,
                CreatedAt = request.CreatedAt,
                UpdatedAt = request.UpdatedAt,
            };

            var result = await _studentRepository.CreateAsync(studentEntity);
            return _mapper.Map<Student>(result);
        }
    }
}
