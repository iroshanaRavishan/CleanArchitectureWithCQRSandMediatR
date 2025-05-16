using CleanArchitectureWithCQRSandMediatR.Application.Common.Exceptions;
using CleanArchitectureWithCQRSandMediatR.Domain.Entities;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var existingStudent = await _studentRepository.GetStudentByIdAsync(request.Id);
            if (existingStudent == null)
                throw new NotFoundException(nameof(Student), request.Id);

            return await _studentRepository.DeleteAsync(request.Id);
        }
    }
}
