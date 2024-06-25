using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Registrars.Services
{
    internal class HostServiceRegistrar : IServiceRegistrar
    {
        public IWebHostBuilder RegisterService(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddHostedService<Worker>();
            });

            return builder;
        }
    }
}
