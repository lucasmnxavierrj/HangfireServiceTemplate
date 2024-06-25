using Hangfire;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Registrars.Middlewares
{
    internal class MiddlewareRegistrar : IMiddlewareRegistrar
    {
        public IApplicationBuilder RegisterMiddlewares(IApplicationBuilder app)
        {
            app.UseHangfireDashboard(options: new()
            {
                DashboardTitle = "Hangfire Service Template",
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHangfireDashboard();
            });

            return app;
        }
    }
}
