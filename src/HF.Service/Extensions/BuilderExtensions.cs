using HF.Service.Registrars;
using HF.Service.Registrars.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Extensions
{
    internal static class BuilderExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, Type scanningType)
        {
            var registrars = GetRegistrars<IServiceRegistrar>(scanningType);

            foreach (var registrar in registrars)
                registrar.RegisterService(services);

            return services;
        }

        public static IApplicationBuilder RegisterMiddlewares(this IApplicationBuilder app, Type scanningType)
        {
            return app;
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T : IRegistrar
            => scanningType.Assembly
                .GetTypes()
                .Where(type => type.IsAssignableTo(typeof(T)) && 
                    type.IsInterface is false &&
                    type.IsAbstract is false)
                .Select(Activator.CreateInstance)
                .Cast<T>();


    }
}
