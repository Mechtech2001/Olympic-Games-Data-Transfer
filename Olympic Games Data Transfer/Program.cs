using Microsoft.EntityFrameworkCore;
using Olympic_Games_Data_Transfer.Models;

var builder = WebApplication.CreateBuilder(args);
//add session state
builder.Services.AddMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
    options.Cookie.HttpOnly = false;
    options.Cookie.IsEssential = true;
});

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CountryContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("OlympicContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//adds session state
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "custom",
    pattern: "{controller}/{action}/{activeEvent}/{activeSport}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
