using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Jobs.ImmediateJobs
{
    public class ImmediateJobExample : MyBackgroundJob
    {
        private readonly ILogger<ImmediateJobExample> _logger;
        public ImmediateJobExample(ILogger<ImmediateJobExample> logger)
        {
            _logger = logger;
        }

        public override async Task ExecuteProcessAsync(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Start execution of Immediate Job");

                await StartAsync(cancellationToken);

                _logger.LogInformation("End execution of Immediate Job");

            }
            catch (Exception ex)
            {
                _logger.LogError($"An error ocurred while trying running the job: {ex.Message}");
            }
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            //Job Processing
        }
    }
}
