using Hangfire;
using HF.Jobs.RecurrentJobs.Daily;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF.Service.Schedules
{
    internal static class WeeklySchedule
    {
        public static void ScheduleJobs(CancellationToken cancellationToken)
        {
            RecurringJob.AddOrUpdate<DailyRecurrentJobExample>(
                "weeklyExample1",
                x => x.ExecuteProcessAsync(cancellationToken),
                Cron.Weekly());
        }
    }
}
