using AutoMapper;
using CleanArchitectureWithCQRSandMediatR.Domain.Repositories;
using CleanArchitectureWithCQRSandMediatR.Infrastucture.Data;
using CleanArchitectureWithCQRSandMediatR.Infrastucture.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Infrastucture
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StudentDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("StudentDbConnection") ??
                    throw new InvalidOperationException("Connection string 'StudentDbContext' is null"));
            });

            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
