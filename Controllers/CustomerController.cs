using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDepartmentProject.Controllers
{
    public class CustomerController : Controller
    {

        ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            var data = _customerRepository.GetAllDto();
            return View(data);
        }
    }
}
