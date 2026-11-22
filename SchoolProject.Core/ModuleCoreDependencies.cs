using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Core.Behaviors;
using System.Reflection;
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

            #endregion

            // Get Validators

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;

        }


    }
}
