var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/healthcheck");

app.MapGet("/", async context => {
    
        var response = new {
            datetime = DateTime.Now,
            env = Environment.GetEnvironmentVariable("env"),
            localhost = Environment.MachineName,
            architecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString(),
            requestHost = context.Request.Host.Value
        };

        System.Diagnostics.Trace.WriteLine("Response: " + response);
        await context.Response.WriteAsJsonAsync(response);
    });

    System.Diagnostics.Trace.WriteLine("Starting EchoServer service");

app.Run();
