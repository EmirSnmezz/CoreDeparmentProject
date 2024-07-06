using CoreDepartmentProject.Core.Constants;
using CoreDepartmentProject.Core.Constants.Results;
using CoreDepartmentProject.Core.Utilities.DataResults;
using CoreDepartmentProject.Models;
using CoreDepartmentProject.Models.Entites.Concrete;
using CoreDepartmentProject.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CoreDepartmentProject.Controllers
{

	[Authorize]
	public class DepartmentController : Controller
    {
        public IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository) => _departmentRepository = departmentRepository;

        public IActionResult Index()
        {
            var result = _departmentRepository.GetAll().Data ;
            return View(result);
        }

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

        [HttpGet]
        public IActionResult Update(int Id)
        {
            var result = _departmentRepository.GetEntity(Id).Data;
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

        public IActionResult Delete(int Id)
        {
            var result = _departmentRepository.GetEntity(Id).Data;

            if (result == null)
            {
                throw new Exception(Messages.GetDataErrorMessage);
            }
            _departmentRepository.Delete(result);

            return RedirectToAction("Index");
        }

        public IActionResult GetDetail(int Id)
        {
            var result = (_departmentRepository.GetEntity(Id).Data , _departmentRepository.GetCustomersById(Id).Data);
            return View(result);
        }
    }
}
