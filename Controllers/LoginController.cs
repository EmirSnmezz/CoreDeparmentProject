using CoreDepartmentProject.Models.Entites.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmentProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Login(Admin admin)  // Identity kullanacağımız için asenkron ifadesini kullanmamız gerekmektedir. Eğer bir methodda async ifadesi varsa orada Task<dönüşTipi> olması gerekmektedir.
        { 
            
            return View(); 
        }

        public IActionResult SignUp() 
        { 
            return View(); 
        }
    }
}
