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
        IDepartmentRepository _departmentRepository;
        ICustomerRepository _customerRepository;
        public HomeController(IDepartmentRepository departmentRepository, ICustomerRepository customerRepository)
            {
            _departmentRepository = departmentRepository;
            _customerRepository = customerRepository;
            }
        public IActionResult Index()
        {
            var result = (_departmentRepository.GetAll().Data, _customerRepository.GetAllDto());
            return View(result);
        }
    }
}
