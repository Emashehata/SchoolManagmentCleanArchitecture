using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreeDependency(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
                return services;
        }

    }
}
