using CoreDepartmentProject.Core.Constants;
using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CoreDepartmentProject.Controllers
{
    public class DepartmentController : Controller
    {
        public IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository) => _departmentRepository = departmentRepository;

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Department department)
        {
            _departmentRepository.Add(department);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var result = _departmentRepository.GetAll().Data ;
            return View(result);
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
        [HttpPost]
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

        public IActionResult GetDetail(int id)
        {
            Department result = (Department)_departmentRepository.GetEntity(id).Data;
            ViewBag.CustomersOfDepartment = _departmentRepository.GetCustomersById(id).Data;
            return View(result);
        }

        public JsonResult jsonTest()
        {
            var result = _departmentRepository.GetAll().Data;

            List<JsonResult>? jsonResult = new List<JsonResult>();
            foreach (var item in result)
            {
                jsonResult.Add(Json(item));
            }

            return Json(jsonResult);
        }
    }
}
