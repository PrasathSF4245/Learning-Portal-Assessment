
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBookRepository, SqlDataBaseForLibrary>();

builder.Services.AddDbContext<LibraryDataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryDataBaseConnection")));

var app = builder.Build();

// Apply database migrations and create the database if it doesn't exist
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<LibraryDataBaseContext>();

 
    dbContext.Database.EnsureCreated();

  if(dbContext.Database == null) {  dbContext.Database.Migrate(); } 
   
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
