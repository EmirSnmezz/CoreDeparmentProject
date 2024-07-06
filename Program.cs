using CoreDepartmentProject.Models;
using CoreDepartmentProject.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies; // bizim cookileri eklememizi ve authentication yapmamýzý saðlayan method ve classlarý bu paket saðlamaktadýr.
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;
using CoreDepartmentProject.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Context, Context>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddSingleton<IAdminRepository, AdminRepository>();

builder.Services.AddAuthentication
    (CookieAuthenticationDefaults.AuthenticationScheme) // CookieAuthenticationDefaults'un gelebilmesi için yukarýdaki Microsoft.AspNetCore.Authentication.Cookies'in using ile eklenmesi gerekemektedir.
    .AddCookie
    (
    x =>
    {
        x.LoginPath = "/Login";
    });
var app = builder.Build();
app.UseAuthorization ();

app.UseStaticFiles();

app.MapControllerRoute
    (
    name:"Default",
    pattern: "{controller=Home}/{action=Index}" // route parametresi olarak id koyunca uygulama niyeyse sapýtýyor breakpoint mode a geçiyor bunu bi araþtýr bakalým neden oluyor bu, büyük ihtimal route parametre tanýmlamasýnda dikkat edilmesi gereken bir husus var.
    );

app.Run();
