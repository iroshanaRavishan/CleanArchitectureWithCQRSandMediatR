using CleanArchitectureWithCQRSandMediatR.Domain.Entities;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using CleanArchitectureWithCQRSandMediatR.Infrastucture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Infrastucture.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }
        public async Task<Student> AddAsync(Student student)
        {
            await _studentDbContext.Students.AddAsync(student);
            await _studentDbContext.SaveChangesAsync();
            return student;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _studentDbContext.Students.Where(model => model.Id == id).ExecuteDeleteAsync();
            
        }

        public async Task<List<Student>> GetAllStudentAsync()
        {
            return await _studentDbContext.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByEmailAsync(string email)
        {
            return await _studentDbContext.Students.AsNoTracking().FirstAsync(model => model.Email == email);
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _studentDbContext.Students.AsNoTracking().FirstOrDefaultAsync(model => model.Id == id);
        }

        public async Task<Student> GetStudentByNameAsync(string name)
        {
            return await _studentDbContext.Students.AsNoTracking().FirstAsync(model => ( model.FirstName == name || model.LastName == name));
        }

        public async Task<int> UpdateAsync(int id, Student student)
        {
            return await _studentDbContext.Students.Where(model => model.Id == id).ExecuteUpdateAsync(setters => setters
                .SetProperty(m => m.FirstName, student.FirstName)
                .SetProperty(m => m.LastName, student.LastName)
                .SetProperty(m => m.Gender, student.Gender)
                .SetProperty(m => m.DateOfBirth, student.DateOfBirth)
                .SetProperty(m => m.Email, student.Email)
                .SetProperty(m => m.PhoneNumber, student.PhoneNumber)
                .SetProperty(m => m.Address, student.Address)
                .SetProperty(m => m.City, student.City)
                .SetProperty(m => m.State, student.State)
                .SetProperty(m => m.PostalCode, student.PostalCode)
                .SetProperty(m => m.Country, student.Country)
                .SetProperty(m => m.GuardianName, student.GuardianName)
                .SetProperty(m => m.GuardianPhone, student.GuardianPhone)
                .SetProperty(m => m.GuardianEmail, student.GuardianEmail)
                .SetProperty(m => m.RelationshipToStudent, student.RelationshipToStudent)
                .SetProperty(m => m.IsActive, student.IsActive)
                .SetProperty(m => m.UpdatedAt, student.UpdatedAt)
            );
        }
    }
}
