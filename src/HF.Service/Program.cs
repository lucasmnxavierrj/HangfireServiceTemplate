using HF.Service;
using HF.Service.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(builder =>
    {
        builder.RegisterServices(typeof(Program));

        builder.Configure(app =>
            app.RegisterMiddlewares(typeof(Program)));

        //builder.ConfigureServices(services =>
        //{
        //    services.AddHostedService<Worker>();
        //});
    });

host.Build().Run();
