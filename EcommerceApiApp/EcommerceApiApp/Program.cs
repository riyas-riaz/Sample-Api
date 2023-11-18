using EcommerceApiApp.Extension_Methods;
using EcommerceApiApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();
app.UseRouting();
app.MapControllers();

app.Run();
