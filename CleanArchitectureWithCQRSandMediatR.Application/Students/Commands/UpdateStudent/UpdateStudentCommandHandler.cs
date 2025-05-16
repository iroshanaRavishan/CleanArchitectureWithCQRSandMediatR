using CleanArchitectureWithCQRSandMediatR.Domain.Entities;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentEntity = new Student()
            {
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
                UpdatedAt = request.UpdatedAt,
            };
            return await _studentRepository.UpdateAsync(request.Id, studentEntity);
        }
    }
}
