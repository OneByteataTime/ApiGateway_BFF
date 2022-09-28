using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();

var app = builder.Build();

app.UseOcelot().Wait();
app.Urls.Add("http://localhost:8000");

//app.MapGet("/", () => "Hello World!");

app.Run();
