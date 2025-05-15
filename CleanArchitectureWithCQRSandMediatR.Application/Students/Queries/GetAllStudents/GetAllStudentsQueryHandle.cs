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
    public class GetAllStudentQueryHandle : IRequestHandler<GetAllStudentsQuery, List<StudentViweModel>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public GetAllStudentQueryHandle(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<List<StudentViweModel>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllStudentAsync(); // here the type is Domain.Entites.Student but we need to convert it to student.

            // ***** this is a manual way to convert it *****
            //var StudentList = students.Select(x => new StudentViweModel
            //{
            //    Id = x.Id,
            //    FirstName = x.FirstName,
            //    LastName = x.LastName,
            //    Gender = x.Gender,
            //    DateOfBirth = x.DateOfBirth,
            //    Email = x.Email,
            //    PhoneNumber = x.PhoneNumber,
            //    Address = x.Address,
            //    City = x.City,
            //    State = x.State,
            //    PostalCode = x.PostalCode,
            //    Country = x.Country,
            //    IsActive = x.IsActive
            //}).ToList();

            // here the mapper is used to convert between the types
            var StudentList = _mapper.Map<List<StudentViweModel>>(students);

            return StudentList;

        }
    }
}
