using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Registrars.Services
{
    internal interface IServiceRegistrar : IRegistrar
    {
        void RegisterService(IServiceCollection services);
    }
}
