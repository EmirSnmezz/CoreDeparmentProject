using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmentProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
