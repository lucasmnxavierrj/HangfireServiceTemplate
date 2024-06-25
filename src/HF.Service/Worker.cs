using Hangfire.Server;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service
{
    internal class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {

        }
    }
}
