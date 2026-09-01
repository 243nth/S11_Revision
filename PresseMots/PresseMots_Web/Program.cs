using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresseMots.Models.Data;
using System.Globalization;

CultureInfo[] supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("fr-CA")
};

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;
var services = builder.Services;
services.AddControllersWithViews();
      
services.AddDbContext<PresseMotsDbContext>(opt =>
{
    opt.UseSqlServer(configuration.GetConnectionString("PresseMotsWebCS"));
    opt.UseLazyLoadingProxies();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();