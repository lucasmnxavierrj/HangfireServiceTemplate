using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Jobs.RecurrentJobs
{
    public class MonthlyRecurrentJobExample : MyBackgroundJob
    {
        private readonly ILogger<MonthlyRecurrentJobExample> _logger;
        public MonthlyRecurrentJobExample(ILogger<MonthlyRecurrentJobExample> logger)
        {
            _logger = logger;
        }

        public override async Task ExecuteProcessAsync(CancellationToken cancellationToken)
        {
            try
            {
                _logger.LogInformation("Start execution of Monthly Recurrent Job");

                await StartAsync(cancellationToken);

                _logger.LogInformation("End execution of Monthly Recurrent Job");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error ocurred while trying running the job: {ex.Message}");
            }
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            // Job Processing
        }
    }
}
