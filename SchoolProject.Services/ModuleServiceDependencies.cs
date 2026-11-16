using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstraction.Interfaces;
using SchoolProject.Infrastructure.Repositories;
using SchoolProject.Service.Abstraction;
using SchoolProject.Service.Implemeentaions;

namespace SchoolProject.Services
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IStudentService ,StudentService>();
            return services;
        }

    }
}
