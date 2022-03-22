var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/healthcheck");

app.MapGet("/", async context => {
    
        var response = new {
            datetime = DateTime.Now,
            env = Environment.GetEnvironmentVariable("env"),
            localhost = Environment.MachineName,
            OSDescription = System.Runtime.InteropServices.RuntimeInformation.OSDescription.ToString(),
            OSArchitecture = System.Runtime.InteropServices.RuntimeInformation.OSArchitecture.ToString(),
            ProcessArchitecture = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString(),
            RuntimeIdentifier = System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier.ToString(),
            requestHost = context.Request.Host.Value
        };

        System.Diagnostics.Trace.WriteLine("Response: " + response);
        await context.Response.WriteAsJsonAsync(response);
    });

    System.Diagnostics.Trace.WriteLine("Starting EchoServer service");

app.Run();
