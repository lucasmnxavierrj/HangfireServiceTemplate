using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Registrars.Services
{
    internal class HangfireRegistrar : IServiceRegistrar
    {

        public IWebHostBuilder RegisterService(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddHangfire(config =>
                {
                    var connectionString = context.Configuration.GetConnectionString("Default");

                    config.UseSqlServerStorage(connectionString, new SqlServerStorageOptions
                    {
                    });
            });

                services.AddHangfireServer();
            });

            return builder;
        }
    }
}
