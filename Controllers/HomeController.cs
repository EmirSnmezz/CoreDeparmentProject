using CoreDepartmentProject.Repositories;
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmentProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ICustomerRepository _customerRepository;
        IDepartmentRepository _departmentRepository;
        public HomeController(ICustomerRepository customerRepository, IDepartmentRepository departmentRepository)
        {
            _customerRepository = customerRepository;
            _departmentRepository = departmentRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            var result = _customerRepository.GetAllDto();
            return View(result);
        }
    }
}
