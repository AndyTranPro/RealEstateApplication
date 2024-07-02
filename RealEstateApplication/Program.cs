using Microsoft.AspNetCore.Mvc;
using RealEstateApplication.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<HomeService>();
builder.Services.AddRazorPages(options =>
{
    // use the ignore antiforgery token attribute to ensure that the form submission works
    options.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
});
var app = builder.Build();
app.UseStaticFiles();

app.MapRazorPages();
app.Run();
