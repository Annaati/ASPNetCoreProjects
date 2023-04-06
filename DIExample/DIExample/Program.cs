using IServices;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICountriesService, CountriesService>();

builder.Services.AddControllersWithViews();



var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
