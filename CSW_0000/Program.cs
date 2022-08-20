var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello C# Web!");

app.Run();

app.MapGet("/about", () => RouteMethods.About());

app.MapGet("/hi/{name}", (string name) => RouteMethods.Hi(name));

app.MapGet("/calc/{x},{y}", (int x, int y) => RouteMethods.Sum(x, y));