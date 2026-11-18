using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstraction.Interfaces;
using SchoolProject.Infrastructure.InfrastructureBases;
using SchoolProject.Infrastructure.Repositories;
 

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services) 
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            
            return services;
        }
    }
}
