using CleanArchitectureWithCQRSandMediatR.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Infrastucture.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        
        public DbSet<Student> Students { get; set; }

    }
}
