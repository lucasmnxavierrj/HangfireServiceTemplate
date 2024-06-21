using Hangfire;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Registrars.Services
{
    internal class ServicesRegistrar : IServiceRegistrar
    {
        public void RegisterService(IServiceCollection services)
        {
            services.AddHangfire(config =>
            {

            });

        }
    }
}
