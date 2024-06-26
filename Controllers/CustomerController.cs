using CoreDepartmentProject.Core.Constants;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using CoreDepartmentProject.Repositories.Concrete;
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
            var result = _customerRepository.GetEntity(id).Data;
            _customerRepository.Delete(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _customerRepository.GetEntity(id).Data;
            if (result == null)
            {
                throw new Exception(Messages.GetDataErrorMessage);
            }

            ViewBag.Departments = _customerRepository.SelectOfDepartmentData();
            return View(result);
        }

        public IActionResult Update(Customer customer)
        {
            _customerRepository.Update(customer);
            return RedirectToAction("Index");
        }
    }
}
