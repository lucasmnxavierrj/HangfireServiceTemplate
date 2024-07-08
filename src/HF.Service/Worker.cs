using Hangfire;
using Hangfire.Server;
using HF.Service.Schedules;
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
            DailySchedule.ScheduleJobs(cancellationToken);
            WeeklySchedule.ScheduleJobs(cancellationToken);
            MonthlySchedule.ScheduleJobs(cancellationToken);
        }
    }
}
