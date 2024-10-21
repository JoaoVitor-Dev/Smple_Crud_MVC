using Microsoft.EntityFrameworkCore;
using Smple_Crud_MVC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer("Server=localhost;Database=SimpleCrudMVC;User Id=sa;Password=macro01;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true"));

var app = builder.Build();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
