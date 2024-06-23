using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

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
            //var Data = _customerRepository.GetAll().Data;

            var Data = new List<Customer>()
            {
                new Customer{ID = 1,  FirstName = "Emir", LastName = "Sönmez", DepartmentId = 1},
                new Customer{ID = 2,  FirstName = "Görkem", LastName = "Bulut", DepartmentId = 1},
                new Customer{ID = 3,  FirstName = "Mert", LastName = "Yılmaz", DepartmentId = 1},
                new Customer{ID = 4,  FirstName = "Mustafa", LastName = "çAMlı", DepartmentId = 1}
            };
            return View(Data);
        }
    }
}
