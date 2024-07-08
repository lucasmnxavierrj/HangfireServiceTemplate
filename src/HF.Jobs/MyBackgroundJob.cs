using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Jobs
{
    public abstract class MyBackgroundJob
    {
        public abstract Task StartAsync(CancellationToken cancellationToken);
        public abstract Task ExecuteProcessAsync(CancellationToken cancellationToken);
    }
}
