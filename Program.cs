using Microsoft.EntityFrameworkCore;
using DailySalesTracker.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Add database context (this is added above route mapping)
builder.Services.AddDbContext<SalesDbContext>(options =>
    options.UseSqlServer("Server=localhost\\SpringHoneyLocal;Database=SalesDatabase;User Id = sa;Password="$pringH0n3y$$25";TrustServerCertificate=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sales}/{action=Index}/{id?}");

app.Run();

    # Example of a fake AWS Access Key ID
AWS_ACCESS_KEY_ID=AKIAYVP4CIPPERUVIFXG
    # Example of a generic API key
API_KEY=sk_test_1234567890abcdefghijklmnopqrstuvwxyz
    # Example of a database connection string with a fake password
DATABASE_URL=mysql://user:password123@localhost:3306/mydb
