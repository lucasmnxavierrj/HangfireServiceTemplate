using Hangfire;
using Hangfire.SqlServer;
using HF.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(config =>
{
    var connectionString = builder.Configuration.GetConnectionString("Default");

    config.UseSqlServerStorage(connectionString);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapEndpoints();

app.UseHttpsRedirection();

app.Run();