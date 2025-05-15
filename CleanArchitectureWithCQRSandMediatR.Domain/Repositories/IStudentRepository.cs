using CleanArchitectureWithCQRSandMediatR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Domain.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task<Student> GetStudentByNameAsync(string name);
        Task<Student> GetStudentByEmailAsync(string email);
        Task<Student> CreateAsync(Student student);
        Task<int> UpdateAsync(int id, Student student);
        Task<int> DeleteAsync(int id);
    }
}

