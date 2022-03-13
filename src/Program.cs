var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"Hello EchoServer [{Environment.MachineName}] {DateTime.Now}" );

app.Run();
