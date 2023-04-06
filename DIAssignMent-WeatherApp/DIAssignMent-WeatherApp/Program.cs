using Services;
using ServicesInterface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IWeatherService, WeatherService>();

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
