using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstraction.Interfaces;
using SchoolProject.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services) 
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
