using CoreDepartmentProject.Core.Constants;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartmentProject.Controllers
{
    public class DepartmentController : Controller
    {
        public IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var result = _departmentRepository.GetAll().Data;
            return View(result);
        }

        public IActionResult GetDetails(int id)
        {
            return null;
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _departmentRepository.GetEntity(id).Data;
            if (result == null)
            {
                throw new Exception(Messages.GetDataErrorMessage);
            }
            return View(result);
        }
        public IActionResult Update(Department department)
        {
            var result = _departmentRepository.Update(department).IsSuccess;
            return result == true
                ? RedirectToAction("Index")
                : Content("");


        }

        public IActionResult Delete(int id)
        {
            var result = _departmentRepository.GetEntity(id).Data;
            
            if (result == null)
            {
                throw new Exception(Messages.GetDataErrorMessage);
            }
            _departmentRepository.Delete(result);
            
            return RedirectToAction("Index");
        }
    }
}
