using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        
        public static IServiceCollection AddCoreDependency(this IServiceCollection services)
        {
            #region configration of mediator
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            
            #endregion
            #region configration of automapper
            services.AddAutoMapper(
                cfg => { },
                Assembly.GetExecutingAssembly());
            return services;
            #endregion

        }


    }
}
