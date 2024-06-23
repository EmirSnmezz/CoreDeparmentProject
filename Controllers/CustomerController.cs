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

        public IActionResult GetDetails(int id)
        {
            var result = _customerRepository.GetDetailOfDto(id);

            return View("Detail", result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            TempData["departments"] = _customerRepository.SelectOfDepartmentData();
            return View();
        }

        public IActionResult Add(Customer customer)
        {
            _customerRepository.Add(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Update(Customer customer)
        {
            return RedirectToAction("Index");
        }
    }
}
