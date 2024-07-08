using Hangfire;
using HF.Jobs.ImmediateJobs;

namespace HF.Api
{
    public static class EndpointsMapping
    {
        public static WebApplication MapEndpoints(this WebApplication app)
        {
            app.MapPost("/immediate-jobs/example1",
                (IBackgroundJobClient job,
                CancellationToken cancellationToken) =>
            {
                try
                {
                    var queueNumber = job.Enqueue<ImmediateJobExample>(x => x.StartAsync(cancellationToken));

                    return Results.Ok(new { Message = "Job triggered successfully", QueueNumber = queueNumber });
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: ex.Message, title: "Error triggering job");
                }
            })
            .WithName("Immediate Job - Example 1")
            .WithOpenApi();

            return app;
        }
    }
}
