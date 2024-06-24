using CoreDepartmentProject.Models;
using CoreDepartmentProject.Repositories;
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using CoreDepartmentProject.Repositories.Concrete.BaseRepository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<Context, Context>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IDepartmentRepository, DepartmentRepository>();
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute
    (
    name:"Default",
    pattern:"{controller=Home}/{action=Index}"
    );
app.Run();
