using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmentProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() 
        { 
            return View(); 
        }

        public IActionResult SignUp() 
        { 
            return View(); 
        }
    }
}
