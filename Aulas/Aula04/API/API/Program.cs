var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "\t\tHello World!");

app.Run();
