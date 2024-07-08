using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateApplication.Models;
using RealEstateApplication.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HomeContext>(opt => opt.UseSqlite("Data Source=bsr.db"));

builder.Services.AddScoped<HomeService>();
builder.Services.AddRazorPages(options =>
{
    // use the ignore antiforgery token attribute to ensure that the form submission works
    options.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
});
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<HomeContext>();
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}

app.UseStaticFiles();

app.MapRazorPages();
app.Run();
