using HF.Service.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)

    .ConfigureWebHostDefaults(builder => 
        builder.Configure(app => 
            app.RegisterMiddlewares(typeof(Program))))

    .ConfigureServices(services => 
        services.RegisterServices(typeof(Program)));

host.Build().Run();
