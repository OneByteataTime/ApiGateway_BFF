var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/start", () => "Hello World!");

app.Run();
