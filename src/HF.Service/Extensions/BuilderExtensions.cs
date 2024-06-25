using HF.Service.Registrars;
using HF.Service.Registrars.Middlewares;
using HF.Service.Registrars.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
        public static IWebHostBuilder RegisterServices(this IWebHostBuilder builder, Type scanningType)
        {
            var registrars = GetRegistrars<IServiceRegistrar>(scanningType);

            foreach (var registrar in registrars)
                registrar.RegisterService(builder);

            return builder;
        }

        public static IApplicationBuilder RegisterMiddlewares(this IApplicationBuilder app, Type scanningType)
        {
            var registrars = GetRegistrars<IMiddlewareRegistrar>(scanningType);

            foreach (var registrar in registrars)
                registrar.RegisterMiddlewares(app);

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
