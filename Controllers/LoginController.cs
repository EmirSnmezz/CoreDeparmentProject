using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDepartmentProject.Controllers
{
    public class LoginController : Controller
    {
        IAdminRepository _adminRepository;
        public LoginController(IAdminRepository adminRepository) 
        {
            _adminRepository = adminRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Login(Admin admin)  // Identity kullanacağımız için asenkron ifadesini kullanmamız gerekmektedir. Eğer bir methodda async ifadesi varsa orada Task<dönüşTipi> olması gerekmektedir.
        {        
            var result = _adminRepository.Login(admin);

            if(!result.IsSuccess)
            {
                 throw new Exception("Hata!");
            }


            var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, admin.UserName)
                };

            var userIdentity = new ClaimsIdentity(claims, "Login");

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(claimsPrincipal);

            return RedirectToAction("Index", "Customer");
        }
    }
}
