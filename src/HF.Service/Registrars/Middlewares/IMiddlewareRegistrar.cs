using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Registrars.Middlewares
{
    internal interface IMiddlewareRegistrar : IRegistrar
    {
        IApplicationBuilder RegisterMiddlewares(IApplicationBuilder app);
    }
}
