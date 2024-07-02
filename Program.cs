using CoreDepartmentProject.Models;
using CoreDepartmentProject.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies; // bizim cookileri eklememizi ve authentication yapmam�z� sa�layan method ve classlar� bu paket sa�lamaktad�r.
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Context, Context>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddSingleton<IAdminRepository, AdminRepository>();
builder.Services.AddAuthentication
    (CookieAuthenticationDefaults.AuthenticationScheme) // CookieAuthenticationDefaults'un gelebilmesi i�in yukar�daki Microsoft.AspNetCore.Authentication.Cookies'in using ile eklenmesi gerekemektedir.
    .AddCookie
    (
    x =>
    {
        x.LoginPath = "/Login";
    });
var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();

app.MapControllerRoute
    (
    name:"Default",
    pattern:"{controller=Home}/{action=Index}/{Id?}"
    );

app.MapControllerRoute
    (
    name: "Detail",
    pattern: "{controller=Customer}/{Action=GetDetails}/{id?}"
    );
app.Run();
